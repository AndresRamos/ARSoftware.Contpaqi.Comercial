using System;
using System.Collections.Generic;
using Ardalis.SmartEnum;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums.CatalogosCfdi;

public sealed class UsoCfdiEnum : SmartEnum<UsoCfdiEnum, string>
{
    /// <summary>
    ///     G01 - Adquisición de mercancías.
    /// </summary>
    public static readonly UsoCfdiEnum G01 = new("Adquisición de mercancías.", "G01",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     G02 - Devoluciones, descuentos o bonificaciones.
    /// </summary>
    public static readonly UsoCfdiEnum G02 = new("Devoluciones, descuentos o bonificaciones.", "G02",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     G03 - Gastos en general.
    /// </summary>
    public static readonly UsoCfdiEnum G03 = new("Gastos en general.", "G03",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I01 - Construcciones.
    /// </summary>
    public static readonly UsoCfdiEnum I01 = new("Construcciones.", "I01",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I02 - Mobiliario y equipo de oficina por inversiones.
    /// </summary>
    public static readonly UsoCfdiEnum I02 = new("Mobiliario y equipo de oficina por inversiones.", "I02",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I03 - Equipo de transporte.
    /// </summary>
    public static readonly UsoCfdiEnum I03 = new("Equipo de transporte.", "I03",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I04 - Equipo de computo y accesorios.
    /// </summary>
    public static readonly UsoCfdiEnum I04 = new("Equipo de computo y accesorios.", "I04",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I05 - Dados, troqueles, moldes, matrices y herramental.
    /// </summary>
    public static readonly UsoCfdiEnum I05 = new("Dados, troqueles, moldes, matrices y herramental.", "I05",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I06 - Comunicaciones telefónicas.
    /// </summary>
    public static readonly UsoCfdiEnum I06 = new("Comunicaciones telefónicas.", "I06",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I07 - Comunicaciones satelitales.
    /// </summary>
    public static readonly UsoCfdiEnum I07 = new("Comunicaciones satelitales.", "I07",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     I08 - Otra maquinaria y equipo.
    /// </summary>
    public static readonly UsoCfdiEnum I08 = new("Otra maquinaria y equipo.", "I08",
        new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

    /// <summary>
    ///     D01 - Honorarios médicos, dentales y gastos hospitalarios.
    /// </summary>
    public static readonly UsoCfdiEnum D01 = new("Honorarios médicos, dentales y gastos hospitalarios.", "D01",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D02 - Gastos médicos por incapacidad o discapacidad.
    /// </summary>
    public static readonly UsoCfdiEnum D02 = new("Gastos médicos por incapacidad o discapacidad.", "D02",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D03 - Gastos funerales.
    /// </summary>
    public static readonly UsoCfdiEnum D03 = new("Gastos funerales.", "D03",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D04 - Donativos.
    /// </summary>
    public static readonly UsoCfdiEnum D04 = new("Donativos.", "D04",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D05 - Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).
    /// </summary>
    public static readonly UsoCfdiEnum D05 = new("Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).",
        "D05", new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D06 - Aportaciones voluntarias al SAR.
    /// </summary>
    public static readonly UsoCfdiEnum D06 = new("Aportaciones voluntarias al SAR.", "D06",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D07 - Primas por seguros de gastos médicos.
    /// </summary>
    public static readonly UsoCfdiEnum D07 = new("Primas por seguros de gastos médicos.", "D07",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D08 - Gastos de transportación escolar obligatoria.
    /// </summary>
    public static readonly UsoCfdiEnum D08 = new("Gastos de transportación escolar obligatoria.", "D08",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D09 - Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.
    /// </summary>
    public static readonly UsoCfdiEnum D09 = new("Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.",
        "D09", new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     D10 - Pagos por servicios educativos (colegiaturas).
    /// </summary>
    public static readonly UsoCfdiEnum D10 = new("Pagos por servicios educativos (colegiaturas).", "D10",
        new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

    /// <summary>
    ///     S01 - Sin efectos fiscales.
    /// </summary>
    public static readonly UsoCfdiEnum S01 = new("Sin efectos fiscales.", "S01",
        new[] { "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626" });

    /// <summary>
    ///     CP01 - Pagos
    /// </summary>
    public static readonly UsoCfdiEnum CP01 = new("Pagos", "CP01",
        new[] { "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626" });

    /// <summary>
    ///     CN01 - Nómina
    /// </summary>
    public static readonly UsoCfdiEnum CN01 = new("Nómina", "CN01", new[] { "605" });

    /// <summary>
    ///     P01 - Por definir.
    /// </summary>
    public static readonly UsoCfdiEnum P01 = new("Por definir.", "P01", new List<string>());

    private UsoCfdiEnum(string descripcion, string clave, IEnumerable<string> regimenesFiscales) : base(descripcion, clave)
    {
        foreach (string regimen in regimenesFiscales)
            RegimenesFiscales.Add(RegimenFiscalEnum.TryFromValue(regimen, out RegimenFiscalEnum regimenResult)
                ? regimenResult
                : throw new InvalidOperationException($"El regimen fiscal {regimen} no es valido."));
    }

    public List<RegimenFiscalEnum> RegimenesFiscales { get; } = new();
}
