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
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar direcciones.
/// </summary>
/// <typeparam name="T">
///     El tipo de direccion utilizado por el repositorio.
/// </typeparam>
public class DireccionSdkRepository<T> : IDireccionRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public DireccionSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorCliente(string codigoClienteProveedor, TipoDireccion tipoDireccion)
    {
        return _sdk.fBuscaDireccionCteProv(codigoClienteProveedor, (byte)tipoDireccion) == SdkResultConstants.Success
            ? LeerDatosDireccionActual()
            : null;
    }

    /// <inheritdoc />
    public T? BuscarPorDocumento(int idDocumento, TipoDireccion tipoDireccion)
    {
        return _sdk.fBuscaDireccionDocumento(idDocumento, (byte)tipoDireccion) == SdkResultConstants.Success
            ? LeerDatosDireccionActual()
            : null;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idDireccion)
    {
        var idDireccionDato = new StringBuilder(12);

        _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
        if (idDireccion == int.Parse(idDireccionDato.ToString())) return LeerDatosDireccionActual();

        while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoDireccion("CIDDIRECCION", idDireccionDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (idDireccion == int.Parse(idDireccionDato.ToString())) return LeerDatosDireccionActual();

            if (_sdk.fPosEOFDireccion() == 1) break;
        }

        return null;
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoCatalogoDireccion tipoCatalogoDireccion)
    {
        var lista = new List<T>();

        var tipoCatalogo = new StringBuilder(7);

        _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
        if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()))
            lista.Add(LeerDatosDireccionActual());

        while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()))
                lista.Add(LeerDatosDireccionActual());

            if (_sdk.fPosEOFDireccion() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerPorTipoYIdCatalogo(TipoCatalogoDireccion tipoCatalogoDireccion, int idCatalogo)
    {
        var lista = new List<T>();

        var tipoCatalogo = new StringBuilder(7);
        var idCatalogoDato = new StringBuilder(12);

        _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
        _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
        if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()) &&
            idCatalogo == int.Parse(idCatalogoDato.ToString()))
            lista.Add(LeerDatosDireccionActual());

        while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoDireccion("CTIPOCATALOGO", tipoCatalogo, 7).ToResultadoSdk(_sdk).ThrowIfError();
            _sdk.fLeeDatoDireccion("CIDCATALOGO", idCatalogoDato, SdkConstantes.kLongId).ToResultadoSdk(_sdk).ThrowIfError();
            if (tipoCatalogoDireccion == TipoCatalogoDireccionHelper.ConvertFromSdkValue(tipoCatalogo.ToString()) &&
                idCatalogo == int.Parse(idCatalogoDato.ToString()))
                lista.Add(LeerDatosDireccionActual());

            if (_sdk.fPosEOFDireccion() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerDireccion().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosDireccionActual());

        while (_sdk.fPosSiguienteDireccion() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosDireccionActual());

            if (_sdk.fPosEOFDireccion() == 1) break;
        }

        return lista;
    }

    private T LeerDatosDireccionActual()
    {
        var direccion = new T();

        LeerYAsignarDatos(direccion);

        return direccion;
    }

    private void LeerYAsignarDatos(T direccion)
    {
        Type sqlModelType = typeof(admDomicilios);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
        {
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(direccion,
                    _sdk.LeeDatoDireccion(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
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
