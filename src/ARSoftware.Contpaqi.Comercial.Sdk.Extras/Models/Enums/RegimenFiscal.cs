using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums
{
    public class RegimenFiscal
    {
        /// <summary>
        ///     601 - General de Ley Personas Morales
        /// </summary>
        public static readonly RegimenFiscal _601 = new RegimenFiscal("601", "General de Ley Personas Morales");

        /// <summary>
        ///     603 - Personas Morales con Fines no Lucrativos
        /// </summary>
        public static readonly RegimenFiscal _603 = new RegimenFiscal("603", "Personas Morales con Fines no Lucrativos");

        /// <summary>
        ///     605 - Sueldos y Salarios e Ingresos Asimilados a Salarios"
        /// </summary>
        public static readonly RegimenFiscal _605 = new RegimenFiscal("605", "Sueldos y Salarios e Ingresos Asimilados a Salarios");

        /// <summary>
        ///     606 - Arrendamiento
        /// </summary>
        public static readonly RegimenFiscal _606 = new RegimenFiscal("606", "Arrendamiento");

        /// <summary>
        ///     607 - Régimen de Enajenación o Adquisición de Bienes
        /// </summary>
        public static readonly RegimenFiscal _607 = new RegimenFiscal("607", "Régimen de Enajenación o Adquisición de Bienes");

        /// <summary>
        ///     608 - Demás ingresos
        /// </summary>
        public static readonly RegimenFiscal _608 = new RegimenFiscal("608", "Demás ingresos");

        /// <summary>
        ///     610 - Residentes en el Extranjero sin Establecimiento Permanente en México
        /// </summary>
        public static readonly RegimenFiscal _610 = new RegimenFiscal("610",
            "Residentes en el Extranjero sin Establecimiento Permanente en México");

        /// <summary>
        ///     611 - Ingresos por Dividendos (socios y accionistas)
        /// </summary>
        public static readonly RegimenFiscal _611 = new RegimenFiscal("611", "Ingresos por Dividendos (socios y accionistas)");

        /// <summary>
        ///     612 - Personas Físicas con Actividades Empresariales y Profesionales
        /// </summary>
        public static readonly RegimenFiscal _612 = new RegimenFiscal("612",
            "Personas Físicas con Actividades Empresariales y Profesionales");

        /// <summary>
        ///     614 - Ingresos por intereses
        /// </summary>
        public static readonly RegimenFiscal _614 = new RegimenFiscal("614", "Ingresos por intereses");

        /// <summary>
        ///     615 - Régimen de los ingresos por obtención de premios
        /// </summary>
        public static readonly RegimenFiscal _615 = new RegimenFiscal("615", "Régimen de los ingresos por obtención de premios");

        /// <summary>
        ///     616 - Sin obligaciones fiscales
        /// </summary>
        public static readonly RegimenFiscal _616 = new RegimenFiscal("616", "Sin obligaciones fiscales");

        /// <summary>
        ///     620 - Sociedades Cooperativas de Producción que optan por diferir sus ingresos
        /// </summary>
        public static readonly RegimenFiscal _620 = new RegimenFiscal("620",
            "Sociedades Cooperativas de Producción que optan por diferir sus ingresos");

        /// <summary>
        ///     621 - Incorporación Fiscal
        /// </summary>
        public static readonly RegimenFiscal _621 = new RegimenFiscal("621", "Incorporación Fiscal");

        /// <summary>
        ///     622 - Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras
        /// </summary>
        public static readonly RegimenFiscal _622 = new RegimenFiscal("622", "Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras");

        /// <summary>
        ///     623 - Opcional para Grupos de Sociedades
        /// </summary>
        public static readonly RegimenFiscal _623 = new RegimenFiscal("623", "Opcional para Grupos de Sociedades");

        /// <summary>
        ///     624 - Coordinados
        /// </summary>
        public static readonly RegimenFiscal _624 = new RegimenFiscal("624", "Coordinados");

        /// <summary>
        ///     625 - Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas
        /// </summary>
        public static readonly RegimenFiscal _625 = new RegimenFiscal("625",
            "Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas");

        /// <summary>
        ///     626 - Régimen Simplificado de Confianza
        /// </summary>
        public static readonly RegimenFiscal _626 = new RegimenFiscal("626", "Régimen Simplificado de Confianza");

        private RegimenFiscal(string clave, string descripcion)
        {
            Descripcion = descripcion;
            Clave = clave;
        }

        public string Clave { get; }
        public string Descripcion { get; }

        public static RegimenFiscal FromDescripcion(string descripcion)
        {
            return ToList().SingleOrDefault(r => string.Equals(r.Descripcion, descripcion, StringComparison.OrdinalIgnoreCase));
        }

        public static RegimenFiscal FromClave(string clave)
        {
            return ToList().SingleOrDefault(r => r.Clave == clave);
        }

        public static List<RegimenFiscal> ToList()
        {
            return typeof(RegimenFiscal).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.FieldType == typeof(RegimenFiscal))
                .Select(pi => (RegimenFiscal)pi.GetValue(null))
                .OrderBy(p => p.Clave)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Clave} - {Descripcion}";
        }
    }
}
