using System;
using System.Collections.Generic;
using System.ComponentModel;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar clasificaciones.
/// </summary>
/// <typeparam name="T">
///     El tipo de clasificación utilizado por el repositorio.
/// </typeparam>
public class ClasificacionSdkRepository<T> : IClasificacionRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public ClasificacionSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idClasificacion)
    {
        return _sdk.fBuscaIdClasificacion(idClasificacion) == SdkResultConstants.Success ? LeerDatosClasificacionActual() : null;
    }

    /// <inheritdoc />
    public T? BuscarPorTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        return _sdk.fBuscaClasificacion((int)tipoClasificacion, (int)numeroClasificacion) == SdkResultConstants.Success
            ? LeerDatosClasificacionActual()
            : null;
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoClasificacion tipoClasificacion)
    {
        return new List<T>
        {
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Uno) ?? throw new InvalidOperationException(),
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Dos) ?? throw new InvalidOperationException(),
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Tres) ?? throw new InvalidOperationException(),
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Cuatro) ?? throw new InvalidOperationException(),
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Cinco) ?? throw new InvalidOperationException(),
            BuscarPorTipoYNumero(tipoClasificacion, NumeroClasificacion.Seis) ?? throw new InvalidOperationException()
        };
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerClasificacion().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosClasificacionActual());

        while (_sdk.fPosSiguienteClasificacion() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosClasificacionActual());
            if (_sdk.fPosEOFClasificacion() == 1) break;
        }

        return lista;
    }

    private T LeerDatosClasificacionActual()
    {
        var clasificacion = new T();

        LeerYAsignarDatos(clasificacion);

        return clasificacion;
    }

    private void LeerYAsignarDatos(T clasificacion)
    {
        Type sqlModelType = typeof(admClasificaciones);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(clasificacion,
                    _sdk.LeeDatoClasificacion(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
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
