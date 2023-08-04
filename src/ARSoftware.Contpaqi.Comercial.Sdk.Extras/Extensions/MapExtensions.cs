using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

public static class MapExtensions
{
    public static Dictionary<string, string> ToDatosDictionary(this Agente agente)
    {
        return new Dictionary<string, string>(agente.DatosExtra)
        {
            { nameof(admAgentes.CIDAGENTE), agente.Id.ToString() },
            { nameof(admAgentes.CCODIGOAGENTE), agente.Codigo },
            { nameof(admAgentes.CNOMBREAGENTE), agente.Nombre },
            { nameof(admAgentes.CTIPOAGENTE), TipoAgenteHelper.ConvertToSdkValue(agente.Tipo).ToString() }
        };
    }

    public static Dictionary<string, string> ToDatosDictionary(this Almacen almacen)
    {
        return new Dictionary<string, string>(almacen.DatosExtra)
        {
            { nameof(admAlmacenes.CIDALMACEN), almacen.Id.ToString() },
            { nameof(admAlmacenes.CCODIGOALMACEN), almacen.Codigo },
            { nameof(admAlmacenes.CNOMBREALMACEN), almacen.Nombre }
        };
    }

    public static tCteProv ToSdkCteProv(this ClienteProveedor clienteProveedor)
    {
        return new tCteProv
        {
            cCodigoCliente = clienteProveedor.Codigo,
            cRazonSocial = clienteProveedor.RazonSocial,
            cRFC = clienteProveedor.Rfc,
            cTipoCliente = TipoClienteHelper.ConvertToSdkValue(clienteProveedor.Tipo)
        };
    }

    public static Dictionary<string, string> ToDatosDictionary(this ClienteProveedor clienteProveedor)
    {
        return new Dictionary<string, string>(clienteProveedor.DatosExtra)
        {
            { nameof(admClientes.CIDCLIENTEPROVEEDOR), clienteProveedor.Id.ToString() },
            { nameof(admClientes.CCODIGOCLIENTE), clienteProveedor.Codigo },
            { nameof(admClientes.CRAZONSOCIAL), clienteProveedor.RazonSocial },
            { nameof(admClientes.CRFC), clienteProveedor.Rfc },
            { nameof(admClientes.CTIPOCLIENTE), TipoClienteHelper.ConvertToSdkValue(clienteProveedor.Tipo).ToString() },
            { nameof(admClientes.CUSOCFDI), clienteProveedor.UsoCfdi?.Value ?? string.Empty },
            { nameof(admClientes.CREGIMFISC), clienteProveedor.RegimenFiscal?.Value ?? string.Empty }
        };
    }

    public static tDocumento ToSdkDocumento(this Documento documento)
    {
        return new tDocumento
        {
            aCodConcepto = documento.Concepto.Codigo,
            aSerie = documento.Serie,
            aFolio = documento.Folio,
            aFecha = documento.Fecha.ToSdkFecha(),
            aCodigoCteProv = documento.Cliente?.Codigo ?? string.Empty,
            aNumMoneda = documento.Moneda.Id,
            aTipoCambio = (double)documento.TipoCambio,
            aImporte = (double)documento.Total,
            aCodigoAgente = documento.Agente?.Codigo ?? string.Empty,
            aReferencia = documento.Referencia
        };
    }

    public static tMovimiento ToSdkMovimiento(this Movimiento movimiento)
    {
        return new tMovimiento
        {
            aCodProdSer = movimiento.Producto.Codigo,
            aUnidades = movimiento.Unidades,
            aPrecio = (double)movimiento.Precio,
            aCodAlmacen = movimiento.Almacen?.Codigo ?? string.Empty,
            aReferencia = movimiento.Referencia
        };
    }

    public static tMovimientoDesc ToSdkMovimientoDescuento(this Movimiento movimiento)
    {
        return new tMovimientoDesc
        {
            aCodProdSer = movimiento.Producto.Codigo,
            aUnidades = movimiento.Unidades,
            aPrecio = (double)movimiento.Precio,
            aCodAlmacen = movimiento.Almacen?.Codigo ?? string.Empty,
            aReferencia = movimiento.Referencia,
            aPorcDescto1 = (double)(movimiento.Descuentos?.Descuento1.Tasa ?? 0),
            aImporteDescto1 = (double)(movimiento.Descuentos?.Descuento1.Importe ?? 0),
            aPorcDescto2 = (double)(movimiento.Descuentos?.Descuento2.Tasa ?? 0),
            aImporteDescto2 = (double)(movimiento.Descuentos?.Descuento2.Importe ?? 0),
            aPorcDescto3 = (double)(movimiento.Descuentos?.Descuento3.Tasa ?? 0),
            aImporteDescto3 = (double)(movimiento.Descuentos?.Descuento3.Importe ?? 0),
            aPorcDescto4 = (double)(movimiento.Descuentos?.Descuento4.Tasa ?? 0),
            aImporteDescto4 = (double)(movimiento.Descuentos?.Descuento4.Importe ?? 0),
            aPorcDescto5 = (double)(movimiento.Descuentos?.Descuento5.Tasa ?? 0),
            aImporteDescto5 = (double)(movimiento.Descuentos?.Descuento5.Importe ?? 0)
        };
    }

    public static tSeriesCapas ToSdkSeriesCapas(this SeriesCapas seriesCapas)
    {
        return new tSeriesCapas
        {
            aUnidades = seriesCapas.Unidades,
            aTipoCambio = (double)seriesCapas.TipoCambio,
            aSeries = seriesCapas.Series,
            aPedimento = seriesCapas.Pedimento,
            aAgencia = seriesCapas.Agencia,
            aFechaPedimento = seriesCapas.FechaPedimento?.ToSdkFecha() ?? string.Empty,
            aNumeroLote = seriesCapas.NumeroLote,
            aFechaFabricacion = seriesCapas.FechaFabricacion?.ToSdkFecha() ?? string.Empty,
            aFechaCaducidad = seriesCapas.FechaCaducidad?.ToSdkFecha() ?? string.Empty
        };
    }

    public static tProducto ToSdkProducto(this Producto producto)
    {
        return new tProducto
        {
            cCodigoProducto = producto.Codigo,
            cNombreProducto = producto.Nombre,
            cTipoProducto = TipoProductoHelper.ConvertToSdkValue(producto.Tipo)
        };
    }

    public static tUnidad ToSdkUnidad(this UnidadMedida unidad)
    {
        return new tUnidad { cAbreviatura = unidad.Abreviatura, cNombreUnidad = unidad.Nombre, cDespliegue = string.Empty };
    }

    public static tDireccion ToSdkDireccion(this Direccion direccion)
    {
        return new tDireccion
        {
            cTipoCatalogo = (int)direccion.TipoCatalogo,
            cTipoDireccion = (int)direccion.Tipo,
            cNombreCalle = direccion.Calle,
            cNumeroExterior = direccion.NumeroExterior,
            cNumeroInterior = direccion.NumeroInterior,
            cColonia = direccion.Colonia,
            cCiudad = direccion.Ciudad,
            cEstado = direccion.Estado,
            cCodigoPostal = direccion.CodigoPostal,
            cPais = direccion.Pais
        };
    }

    public static Moneda ToMoneda(this MonedaEnum monedaEnum)
    {
        return new Moneda { Id = monedaEnum.Value, Nombre = monedaEnum.Name };
    }
}
