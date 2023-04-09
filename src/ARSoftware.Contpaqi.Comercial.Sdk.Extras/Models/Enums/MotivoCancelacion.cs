using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums
{
    public sealed class MotivoCancelacion
    {
        /// <summary>
        ///     01 - Comprobantes emitidos con errores con relación.
        /// </summary>
        public static readonly MotivoCancelacion _01 = new MotivoCancelacion("01", "Comprobantes emitidos con errores con relación.");

        /// <summary>
        ///     02 - Comprobantes emitidos con errores sin relación.
        /// </summary>
        public static readonly MotivoCancelacion _02 = new MotivoCancelacion("02", "Comprobantes emitidos con errores sin relación.");

        /// <summary>
        ///     03 - No se llevó a cabo la operación.
        /// </summary>
        public static readonly MotivoCancelacion _03 = new MotivoCancelacion("03", "No se llevó a cabo la operación.");

        /// <summary>
        ///     04 - Operación nominativa relacionada en una factura global.
        /// </summary>
        public static readonly MotivoCancelacion _04 =
            new MotivoCancelacion("04", "Operación nominativa relacionada en una factura global.");

        public MotivoCancelacion(string clave, string descripcion)
        {
            Clave = clave;
            Descripcion = descripcion;
        }

        public string Clave { get; }
        public string Descripcion { get; }

        public static MotivoCancelacion FromClave(string clave)
        {
            return ToList().SingleOrDefault(r => r.Clave == clave);
        }

        public static MotivoCancelacion FromDescripcion(string descripcion)
        {
            return ToList().SingleOrDefault(r => string.Equals(r.Descripcion, descripcion, StringComparison.OrdinalIgnoreCase));
        }

        public static List<MotivoCancelacion> ToList()
        {
            return typeof(MotivoCancelacion).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(p => p.FieldType == typeof(MotivoCancelacion))
                .Select(pi => (MotivoCancelacion)pi.GetValue(null))
                .OrderBy(p => p.Clave)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Clave} - {Descripcion}";
        }
    }
}
