using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

/// <summary>
///     Repositorio de SDK para consultar productos.
/// </summary>
/// <typeparam name="T">
///     El tipo de producto utilizado por el repositorio.
/// </typeparam>
public class ProductoSdkRepository<T> : IProductoRepository<T> where T : class, new()
{
    private readonly IContpaqiSdk _sdk;

    public ProductoSdkRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    /// <inheritdoc />
    public T? BuscarPorCodigo(string codigoProducto)
    {
        return _sdk.fBuscaProducto(codigoProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
    }

    /// <inheritdoc />
    public T? BuscarPorId(int idProducto)
    {
        return _sdk.fBuscaIdProducto(idProducto) == SdkResultConstants.Success ? LeerDatosProductoActual() : null;
    }

    /// <inheritdoc />
    public double BuscaExistencias(string codigoProducto, string codigoAlmacen, DateOnly fecha)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistencia(codigoProducto, codigoAlmacen, fecha.Year.ToString(), fecha.Month.ToString(), fecha.Day.ToString(),
                ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCaracteristicas(string codigoProducto, string codigoAlmacen, DateOnly fecha,
        string valorCaracteristica1, string valorCaracteristica2, string valorCaracteristica3)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistenciaCaracteristicas(codigoProducto, codigoAlmacen, fecha.Year.ToString(), fecha.Month.ToString(),
                fecha.Day.ToString(), valorCaracteristica1, valorCaracteristica2, valorCaracteristica3, ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }

    /// <inheritdoc />
    public double BuscaExistenciasConCapas(string codigoProducto, string codigoAlmacen, string pedimento, string lote)
    {
        var existencias = 0.0;
        _sdk.fRegresaExistenciaLotePedimento(codigoProducto, codigoAlmacen, pedimento, lote, ref existencias)
            .ToResultadoSdk(_sdk)
            .ThrowIfError();
        return existencias;
    }

    /// <inheritdoc />
    public List<T> TraerPorTipo(TipoProducto tipoProducto)
    {
        var lista = new List<T>();

        _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();

        var tipoProductoDato = new StringBuilder(7);
        _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();
        if (tipoProducto == TipoProductoHelper.ConvertFromSdkValue(tipoProductoDato.ToString())) lista.Add(LeerDatosProductoActual());

        while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
        {
            _sdk.fLeeDatoProducto("CTIPOPRODUCTO", tipoProductoDato, 7).ToResultadoSdk(_sdk).ThrowIfError();

            if (tipoProducto == TipoProductoHelper.ConvertFromSdkValue(tipoProductoDato.ToString())) lista.Add(LeerDatosProductoActual());

            if (_sdk.fPosEOFProducto() == 1) break;
        }

        return lista;
    }

    /// <inheritdoc />
    public List<T> TraerTodo()
    {
        var lista = new List<T>();

        _sdk.fPosPrimerProducto().ToResultadoSdk(_sdk).ThrowIfError();
        lista.Add(LeerDatosProductoActual());
        while (_sdk.fPosSiguienteProducto() == SdkResultConstants.Success)
        {
            lista.Add(LeerDatosProductoActual());
            if (_sdk.fPosEOFProducto() == 1) break;
        }

        return lista;
    }

    private T LeerDatosProductoActual()
    {
        var productoComercial = new T();

        LeerYAsignarDatos(productoComercial);

        return productoComercial;
    }

    private void LeerYAsignarDatos(T producto)
    {
        Type sqlModelType = typeof(admProductos);

        foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(typeof(T)))
            try
            {
                if (!sqlModelType.HasProperty(propertyDescriptor.Name)) continue;

                propertyDescriptor.SetValue(producto,
                    _sdk.LeeDatoProducto(propertyDescriptor.Name).Trim().ConvertFromSdkValueString(propertyDescriptor.PropertyType));
            }
            catch (ContpaqiSdkException e)
            {
                throw new ContpaqiSdkInvalidOperationException(
                    $"Error al leer el dato {propertyDescriptor.Name} de tipo {propertyDescriptor.PropertyType}. Error: {e.MensajeErrorSdk}",
                    e);
            }
    }
}
