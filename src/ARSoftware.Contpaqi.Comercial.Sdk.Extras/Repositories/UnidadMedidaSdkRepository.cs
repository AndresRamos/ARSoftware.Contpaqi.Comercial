using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar unidades de medida.
/// </summary>
/// <typeparam name="T">
///     El tipo de unidad de medida utilizado por el repositorio.
/// </typeparam>
public class UnidadMedidaSdkRepository<T> : IUnidadMedidaRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public UnidadMedidaSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idUnidad)
    {
        return _sdk.fBuscaIdUnidad(idUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
    }

    /// <inheritdoc />
    public T? BuscarPorNombre(string nombreUnidad)
    {
        return _sdk.fBuscaUnidad(nombreUnidad) == SdkResultConstants.Success ? LeerDatosUnindadActual() : null;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerUnidad().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosUnindadActual());
        while (_sdk.fPosSiguienteUnidad() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosUnindadActual());
            if (_sdk.fPosEOFUnidad() == 1) break;
        }

        return lista;
    }

    private T LeerDatosUnindadActual()
    {
        var unidad = new T();

        LeerYAsignarDatos(unidad);

        return unidad;
    }

    private void LeerYAsignarDatos(T unidad)
    {
        Type sqlModelType = typeof(admUnidadesMedidaPeso);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(unidad,
                    _sdk.LeeDatoUnidad(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
        }
    }
}
