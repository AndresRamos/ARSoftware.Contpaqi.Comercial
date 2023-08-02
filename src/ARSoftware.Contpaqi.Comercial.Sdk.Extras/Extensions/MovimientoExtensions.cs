using System.Collections.Generic;
using System.Globalization;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

public static class MovimientoExtensions
{
    /// <summary>
    ///     Agrega los descuentos del movimiento al diccionario de datos del movimiento.
    /// </summary>
    /// <param name="movimiento">
    ///     Movimiento del cual se obtendran los descuentos.
    /// </param>
    /// <param name="datosMovimiento">
    ///     Diccionario de datos del movimiento.
    /// </param>
    public static void AddDescuentosToDictionary(this Movimiento movimiento, Dictionary<string, string> datosMovimiento)
    {
        if (movimiento.Descuentos is null) return;

        if (movimiento.Descuentos.Descuento1.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEDESCUENTO1),
                movimiento.Descuentos.Descuento1.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento1.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CDESCUENTO1),
                movimiento.Descuentos.Descuento1.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento2.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEDESCUENTO2),
                movimiento.Descuentos.Descuento2.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento2.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CDESCUENTO2),
                movimiento.Descuentos.Descuento2.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento3.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEDESCUENTO3),
                movimiento.Descuentos.Descuento3.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento3.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CDESCUENTO3),
                movimiento.Descuentos.Descuento3.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento4.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEDESCUENTO4),
                movimiento.Descuentos.Descuento4.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento4.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CDESCUENTO4),
                movimiento.Descuentos.Descuento4.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento5.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEDESCUENTO5),
                movimiento.Descuentos.Descuento5.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Descuentos.Descuento5.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CDESCUENTO5),
                movimiento.Descuentos.Descuento5.Importe.ToString(CultureInfo.InvariantCulture));
        }
    }

    /// <summary>
    ///     Agrega los impuestos del movimiento al diccionario de datos del movimiento.
    /// </summary>
    /// <param name="movimiento">
    ///     Movimiento del cual se obtendran los impuestos.
    /// </param>
    /// <param name="datosMovimiento">
    ///     Diccionario de datos del movimiento.
    /// </param>
    public static void AddImpuestosToDictionary(this Movimiento movimiento, Dictionary<string, string> datosMovimiento)
    {
        if (movimiento.Impuestos is null) return;

        if (movimiento.Impuestos.Impuesto1.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJEIMPUESTO1),
                movimiento.Impuestos.Impuesto1.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Impuestos.Impuesto1.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CIMPUESTO1),
                movimiento.Impuestos.Impuesto1.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Impuestos.Impuesto2.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CIMPUESTO2),
                movimiento.Impuestos.Impuesto2.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Impuestos.Impuesto2.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CIMPUESTO2),
                movimiento.Impuestos.Impuesto2.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Impuestos.Impuesto3.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CIMPUESTO3),
                movimiento.Impuestos.Impuesto3.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Impuestos.Impuesto3.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CIMPUESTO3),
                movimiento.Impuestos.Impuesto3.Importe.ToString(CultureInfo.InvariantCulture));
        }
    }

    /// <summary>
    ///     Agrega las retenciones del movimiento al diccionario de datos del movimiento.
    /// </summary>
    /// <param name="movimiento">
    ///     Movimiento del cual se obtendran las retenciones.
    /// </param>
    /// <param name="datosMovimiento">
    ///     Diccionario de datos del movimiento.
    /// </param>
    public static void AddRetencionesToDictionary(this Movimiento movimiento, Dictionary<string, string> datosMovimiento)
    {
        if (movimiento.Retenciones is null) return;

        if (movimiento.Retenciones.Retencion1.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJERETENCION1),
                movimiento.Retenciones.Retencion1.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Retenciones.Retencion1.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CRETENCION1),
                movimiento.Retenciones.Retencion1.Importe.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Retenciones.Retencion2.Tasa != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CPORCENTAJERETENCION2),
                movimiento.Retenciones.Retencion2.Tasa.ToString(CultureInfo.InvariantCulture));
        }

        if (movimiento.Retenciones.Retencion2.Importe != 0)
        {
            datosMovimiento.TryAdd(nameof(admMovimientos.CRETENCION2),
                movimiento.Retenciones.Retencion2.Importe.ToString(CultureInfo.InvariantCulture));
        }
    }
}
