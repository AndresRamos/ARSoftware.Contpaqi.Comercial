// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Configuración de descuentos e impuestos para un concepto.
///     Este modelo se puede utilizar para consultar la configuración de descuentos e impuestos para un concepto.
/// </summary>
public class ConfiguracionDescuentosImpuestosConceptoDto
{
    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de descuento 1 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEDESCUENTO1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del descuento 1 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSADESCUENTO1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de descuento 2 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEDESCUENTO2 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del descuento 2 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSADESCUENTO2 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de descuento 3 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEDESCUENTO3 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del descuento 3 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSADESCUENTO3 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de descuento 4 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEDESCUENTO4 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del descuento 4 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSADESCUENTO4 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de descuento 5 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEDESCUENTO5 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del descuento 5 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSADESCUENTO5 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de impuesto 1 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEIMPUESTO1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del impuesto 1 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSAIMPUESTO1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de impuesto 2 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEIMPUESTO2 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del impuesto 2 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSAIMPUESTO2 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de impuesto 3 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJEIMPUESTO3 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del impuesto 3 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSAIMPUESTO3 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de retención 1 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJERETENCION1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del retención 1 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSARETENCION1 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del porcentaje de retención 2 en los movimientos del
    ///     documento para este concepto: 1 = No se usa. 2 = No es visible (no se captura). 3 = Es visible y no es capturable
    ///     (sólo lectura). 4 = Es visible y se captura.
    /// </summary>
    public int CUSAPORCENTAJERETENCION2 { get; set; }

    /// <summary>
    ///     Atributo utilizado para hacer visible y utilizar la columna del retención 2 en los movimientos del documento para
    ///     este concepto. 1 = No se usa 2 = No es visible (no se captura) 3 = Es visible y no es capturable (sólo lectura) 4 =
    ///     Es visible y se captura
    /// </summary>
    public int CUSARETENCION2 { get; set; }
}
