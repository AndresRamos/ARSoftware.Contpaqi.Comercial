using System.Collections.Generic;
using System.Globalization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.ValueObjects;
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

    public static Dictionary<string, string> ToDatosDictionary(this Documento documento)
    {
        return new Dictionary<string, string>(documento.DatosExtra)
        {
            { nameof(admDocumentos.CIDDOCUMENTO), documento.Id.ToString() },
            { nameof(admDocumentos.CIDCONCEPTODOCUMENTO), documento.Concepto.Id.ToString() },
            { nameof(admDocumentos.CSERIEDOCUMENTO), documento.Serie },
            { nameof(admDocumentos.CFOLIO), documento.Folio.ToString() },
            { nameof(admDocumentos.CFECHA), documento.Fecha.ToSdkFecha() },
            { nameof(admDocumentos.CIDCLIENTEPROVEEDOR), documento.Cliente?.Id.ToString() ?? string.Empty },
            { nameof(admDocumentos.CIDMONEDA), documento.Moneda.Id.ToString() },
            { nameof(admDocumentos.CTIPOCAMBIO), documento.TipoCambio.ToString(CultureInfo.InvariantCulture) },
            { nameof(admDocumentos.CIDAGENTE), documento.Agente?.Id.ToString() ?? string.Empty },
            { nameof(admDocumentos.CREFERENCIA), documento.Referencia },
            { nameof(admDocumentos.COBSERVACIONES), documento.Observaciones },
            { nameof(admDocumentos.CTOTAL), documento.Total.ToString(CultureInfo.InvariantCulture) },
            { nameof(admDocumentos.CMETODOPAG), documento.FormaPago is not null ? documento.FormaPago.Value : string.Empty },
            {
                nameof(admDocumentos.CCANTPARCI),
                documento.MetodoPago is not null ? MetodoPagoHelper.ConvertToSdkValue(documento.MetodoPago).ToString() : string.Empty
            }
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

    public static Dictionary<string, string> ToDatosDictionary(this Movimiento movimiento)
    {
        var datosMovimiento = new Dictionary<string, string>(movimiento.DatosExtra)
        {
            { nameof(admMovimientos.CIDMOVIMIENTO), movimiento.Id.ToString() },
            { nameof(admMovimientos.CIDPRODUCTO), movimiento.Producto.Id.ToString() },
            { nameof(admMovimientos.CIDALMACEN), movimiento.Almacen?.Id.ToString() ?? "0" },
            { nameof(admMovimientos.CUNIDADES), movimiento.Unidades.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPRECIO), movimiento.Precio.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CNETO), movimiento.Subtotal.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CTOTAL), movimiento.Total.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CREFERENCIA), movimiento.Referencia },
            { nameof(admMovimientos.COBSERVAMOV), movimiento.Observaciones ?? string.Empty }
        };

        if (movimiento.Descuentos is not null)
            foreach ((string key, string value) in movimiento.Descuentos.ToDatosDictionary())
                datosMovimiento.TryAdd(key, value);

        if (movimiento.Impuestos is not null)
            foreach ((string key, string value) in movimiento.Impuestos.ToDatosDictionary())
                datosMovimiento.TryAdd(key, value);

        if (movimiento.Retenciones is not null)
            foreach ((string key, string value) in movimiento.Retenciones.ToDatosDictionary())
                datosMovimiento.TryAdd(key, value);

        return datosMovimiento;
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

    public static Dictionary<string, string> ToDatosDictionary(this Producto producto)
    {
        return new Dictionary<string, string>(producto.DatosExtra)
        {
            { nameof(admProductos.CIDPRODUCTO), producto.Id.ToString() },
            { nameof(admProductos.CCODIGOPRODUCTO), producto.Codigo },
            { nameof(admProductos.CNOMBREPRODUCTO), producto.Nombre },
            { nameof(admProductos.CTIPOPRODUCTO), TipoProductoHelper.ConvertToSdkValue(producto.Tipo).ToString() },
            { nameof(admProductos.CCONTROLEXISTENCIA), ((int)producto.ControlExistencias).ToString() },
            { nameof(admProductos.CIDUNIDADBASE), producto.UnidadMedida.Id.ToString() },
            { nameof(admProductos.CCLAVESAT), producto.ClaveSat }
        };
    }

    public static tProducto ToSdkProducto(this Producto producto)
    {
        return new tProducto
        {
            cCodigoProducto = producto.Codigo,
            cNombreProducto = producto.Nombre,
            cTipoProducto = TipoProductoHelper.ConvertToSdkValue(producto.Tipo),
            cControlExistencia = (int)producto.ControlExistencias,
            cCodigoUnidadBase = producto.UnidadMedida.Nombre
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
            cTipoDireccion = direccion.Tipo == TipoDireccion.Fiscal ? 1 : 2,
            cNombreCalle = direccion.Calle,
            cNumeroExterior = direccion.NumeroExterior,
            cNumeroInterior = direccion.NumeroInterior,
            cColonia = direccion.Colonia,
            cCiudad = direccion.Ciudad,
            cEstado = direccion.Estado,
            cCodigoPostal = direccion.CodigoPostal,
            cPais = direccion.Pais,
            cTelefono1 =
                direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CTELEFONO1), out string? telefono1) ? telefono1 : string.Empty,
            cTelefono2 =
                direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CTELEFONO2), out string? telefono2) ? telefono2 : string.Empty,
            cTelefono3 =
                direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CTELEFONO3), out string? telefono3) ? telefono3 : string.Empty,
            cTelefono4 =
                direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CTELEFONO4), out string? telefono4) ? telefono4 : string.Empty,
            cDireccionWeb =
                direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CDIRECCIONWEB), out string? direccionWeb)
                    ? direccionWeb
                    : string.Empty,
            cEmail = direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CEMAIL), out string? email) ? email : string.Empty,
            cTextoExtra = direccion.DatosExtra.TryGetValue(nameof(admDomicilios.CTEXTOEXTRA), out string? textoExtra)
                ? textoExtra
                : string.Empty
        };
    }

    public static Moneda ToMoneda(this MonedaEnum monedaEnum)
    {
        return new Moneda { Id = monedaEnum.Value, Nombre = monedaEnum.Name };
    }

    public static Dictionary<string, string> ToDatosDictionary(this DescuentosMovimiento descuentosMovimiento)
    {
        return new Dictionary<string, string>
        {
            {
                nameof(admMovimientos.CPORCENTAJEDESCUENTO1), descuentosMovimiento.Descuento1.Tasa.ToString(CultureInfo.InvariantCulture)
            },
            { nameof(admMovimientos.CDESCUENTO1), descuentosMovimiento.Descuento1.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEDESCUENTO2), descuentosMovimiento.Descuento2.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CDESCUENTO2), descuentosMovimiento.Descuento2.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEDESCUENTO3), descuentosMovimiento.Descuento3.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CDESCUENTO3), descuentosMovimiento.Descuento3.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEDESCUENTO4), descuentosMovimiento.Descuento4.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CDESCUENTO4), descuentosMovimiento.Descuento4.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEDESCUENTO5), descuentosMovimiento.Descuento5.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CDESCUENTO5), descuentosMovimiento.Descuento5.Importe.ToString(CultureInfo.InvariantCulture) }
        };
    }

    public static Dictionary<string, string> ToDatosDictionary(this ImpuestosMovimiento impuestosMovimiento)
    {
        return new Dictionary<string, string>
        {
            { nameof(admMovimientos.CPORCENTAJEIMPUESTO1), impuestosMovimiento.Impuesto1.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CIMPUESTO1), impuestosMovimiento.Impuesto1.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEIMPUESTO2), impuestosMovimiento.Impuesto2.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CIMPUESTO2), impuestosMovimiento.Impuesto2.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJEIMPUESTO3), impuestosMovimiento.Impuesto3.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CIMPUESTO3), impuestosMovimiento.Impuesto3.Importe.ToString(CultureInfo.InvariantCulture) }
        };
    }

    public static Dictionary<string, string> ToDatosDictionary(this RetencionesMovimiento retencionesMovimiento)
    {
        return new Dictionary<string, string>
        {
            {
                nameof(admMovimientos.CPORCENTAJERETENCION1), retencionesMovimiento.Retencion1.Tasa.ToString(CultureInfo.InvariantCulture)
            },
            { nameof(admMovimientos.CRETENCION1), retencionesMovimiento.Retencion1.Importe.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CPORCENTAJERETENCION2), retencionesMovimiento.Retencion2.Tasa.ToString(CultureInfo.InvariantCulture) },
            { nameof(admMovimientos.CRETENCION2), retencionesMovimiento.Retencion2.Importe.ToString(CultureInfo.InvariantCulture) }
        };
    }
}
