using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums
{
    public class UsoCfdi
    {
        /// <summary>
        ///     G01 - Adquisición de mercancías.
        /// </summary>
        public static readonly UsoCfdi G01 = new UsoCfdi("G01",
            "Adquisición de mercancías.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     G02 - Devoluciones, descuentos o bonificaciones.
        /// </summary>
        public static readonly UsoCfdi G02 = new UsoCfdi("G02",
            "Devoluciones, descuentos o bonificaciones.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     G03 - Gastos en general.
        /// </summary>
        public static readonly UsoCfdi G03 = new UsoCfdi("G03",
            "Gastos en general.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I01 - Construcciones.
        /// </summary>
        public static readonly UsoCfdi I01 = new UsoCfdi("I01",
            "Construcciones.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I02 - Mobiliario y equipo de oficina por inversiones.
        /// </summary>
        public static readonly UsoCfdi I02 = new UsoCfdi("I02",
            "Mobiliario y equipo de oficina por inversiones.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I03 - Equipo de transporte.
        /// </summary>
        public static readonly UsoCfdi I03 = new UsoCfdi("I03",
            "Equipo de transporte.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I04 - Equipo de computo y accesorios.
        /// </summary>
        public static readonly UsoCfdi I04 = new UsoCfdi("I04",
            "Equipo de computo y accesorios.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I05 - Dados, troqueles, moldes, matrices y herramental.
        /// </summary>
        public static readonly UsoCfdi I05 = new UsoCfdi("I05",
            "Dados, troqueles, moldes, matrices y herramental.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I06 - Comunicaciones telefónicas.
        /// </summary>
        public static readonly UsoCfdi I06 = new UsoCfdi("I06",
            "Comunicaciones telefónicas.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I07 - Comunicaciones satelitales.
        /// </summary>
        public static readonly UsoCfdi I07 = new UsoCfdi("I07",
            "Comunicaciones satelitales.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     I08 - Otra maquinaria y equipo.
        /// </summary>
        public static readonly UsoCfdi I08 = new UsoCfdi("I08",
            "Otra maquinaria y equipo.",
            new[] { "601", "603", "606", "612", "620", "621", "622", "623", "624", "625", "626" });

        /// <summary>
        ///     D01 - Honorarios médicos, dentales y gastos hospitalarios.
        /// </summary>
        public static readonly UsoCfdi D01 = new UsoCfdi("D01",
            "Honorarios médicos, dentales y gastos hospitalarios.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D02 - Gastos médicos por incapacidad o discapacidad.
        /// </summary>
        public static readonly UsoCfdi D02 = new UsoCfdi("D02",
            "Gastos médicos por incapacidad o discapacidad.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D03 - Gastos funerales.
        /// </summary>
        public static readonly UsoCfdi D03 = new UsoCfdi("D03",
            "Gastos funerales.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D04 - Donativos.
        /// </summary>
        public static readonly UsoCfdi D04 = new UsoCfdi("D04",
            "Donativos.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D05 - Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).
        /// </summary>
        public static readonly UsoCfdi D05 = new UsoCfdi("D05",
            "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D06 - Aportaciones voluntarias al SAR.
        /// </summary>
        public static readonly UsoCfdi D06 = new UsoCfdi("D06",
            "Aportaciones voluntarias al SAR.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D07 - Primas por seguros de gastos médicos.
        /// </summary>
        public static readonly UsoCfdi D07 = new UsoCfdi("D07",
            "Primas por seguros de gastos médicos.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D08 - Gastos de transportación escolar obligatoria.
        /// </summary>
        public static readonly UsoCfdi D08 = new UsoCfdi("D08",
            "Gastos de transportación escolar obligatoria.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D09 - Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.
        /// </summary>
        public static readonly UsoCfdi D09 = new UsoCfdi("D09",
            "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     D10 - Pagos por servicios educativos (colegiaturas).
        /// </summary>
        public static readonly UsoCfdi D10 = new UsoCfdi("D10",
            "Pagos por servicios educativos (colegiaturas).",
            new[] { "605", "606", "607", "608", "611", "612", "614", "615", "625" });

        /// <summary>
        ///     S01 - Sin efectos fiscales.
        /// </summary>
        public static readonly UsoCfdi S01 = new UsoCfdi("S01",
            "Sin efectos fiscales.",
            new[]
            {
                "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626"
            });

        /// <summary>
        ///     CP01 - Pagos
        /// </summary>
        public static readonly UsoCfdi CP01 = new UsoCfdi("CP01",
            "Pagos",
            new[]
            {
                "601", "603", "605", "606", "607", "608", "610", "611", "612", "614", "615", "616", "620", "623", "624", "625", "626"
            });

        /// <summary>
        ///     CN01 - Nómina
        /// </summary>
        public static readonly UsoCfdi CN01 = new UsoCfdi("CN01", "Nómina", new[] { "605" });

        /// <summary>
        ///     P01 - Por definir.
        /// </summary>
        public static readonly UsoCfdi P01 = new UsoCfdi("P01", "Por definir.", new List<string>());

        private UsoCfdi(string clave, string descripcion, IEnumerable<string> regimenesFiscales)
        {
            Descripcion = descripcion;
            Clave = clave;

            foreach (string regimen in regimenesFiscales)
                RegimenesFiscales.Add(RegimenFiscal.FromClave(regimen));
        }

        public string Descripcion { get; }
        public string Clave { get; }
        public List<RegimenFiscal> RegimenesFiscales { get; } = new List<RegimenFiscal>();

        public static UsoCfdi FromClave(string clave)
        {
            return ToList().SingleOrDefault(r => r.Clave == clave);
        }

        public static UsoCfdi FromDescripcion(string descripcion)
        {
            return ToList().SingleOrDefault(r => string.Equals(r.Descripcion, descripcion, StringComparison.OrdinalIgnoreCase));
        }

        public static List<UsoCfdi> ToList()
        {
            return typeof(UsoCfdi).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.FieldType == typeof(UsoCfdi))
                .Select(pi => (UsoCfdi)pi.GetValue(null))
                .OrderBy(p => p.Clave)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Clave} - {Descripcion}";
        }
    }
}
