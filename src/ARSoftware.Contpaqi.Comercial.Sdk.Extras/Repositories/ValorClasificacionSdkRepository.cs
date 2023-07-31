using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar valores de clasificaciones.
/// </summary>
/// <typeparam name="T">
///     El tipo de valor de clasificación utilizado por el repositorio.
/// </typeparam>
public class ValorClasificacionSdkRepository<T> : IValorClasificacionRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public ValorClasificacionSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idValorClasificacion)
    {
        return _sdk.fBuscaIdValorClasif(idValorClasificacion) == SdkResultConstants.Success ? LeerDatosValorClasificacionActual() : null;
    }

    /// <inheritdoc />
    public T? BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion,
        string codigoValorClasificacion)
    {
        return _sdk.fBuscaValorClasif((int)tipoClasificacion, (int)numeroClasificacion, codigoValorClasificacion) ==
               SdkResultConstants.Success
            ? LeerDatosValorClasificacionActual()
            : null;
    }

    /// <inheritdoc />
    public List<T> TraerPorClasificacionId(int idClasificacion)
    {
        var lista = new List<T>();
        _sdk.fPosPrimerValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        var id = new StringBuilder(12);
        _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
        if (idClasificacion == int.Parse(id.ToString())) lista.Add(LeerDatosValorClasificacionActual());

        while (_sdk.fPosSiguienteValorClasif() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoValorClasif("CIDCLASIFICACION", id, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (idClasificacion == int.Parse(id.ToString())) lista.Add(LeerDatosValorClasificacionActual());

            if (_sdk.fPosEOFValorClasif() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion)
    {
        _sdk.fBuscaClasificacion((int)tipoClasificacion, (int)numeroClasificacion).ToResultadoSdk(_sdk).ThrowIfError();
        string idClasificacion = _sdk.LeeDatoClasificacion(nameof(admClasificaciones.CIDCLASIFICACION));
        return TraerPorClasificacionId(int.Parse(idClasificacion));
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerValorClasif().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosValorClasificacionActual());
        while (_sdk.fPosSiguienteValorClasif() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosValorClasificacionActual());
            if (_sdk.fPosEOFValorClasif() == 1) break;
        }

        return lista;
    }

    private T LeerDatosValorClasificacionActual()
    {
        var valorClasificacion = new T();

        LeerYAsignarDatos(valorClasificacion);

        return valorClasificacion;
    }

    private void LeerYAsignarDatos(T valor)
    {
        Type sqlModelType = typeof(admClasificacionesValores);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(valor,
                    _sdk.LeeDatoValorClasificacion(propertyDescriptor.Name)
                        .Trim()
                        .ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                // Hay propiedades en Comercial que no estan en el esquema de la base de datos de Factura Electronica
                if (e.CodigoErrorSdk == SdkErrorConstants.NombreCampoInvalido) continue;

                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
        }
    }
}
