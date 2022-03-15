using System;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class Almacen : admAlmacenes
    {
        public Almacen()
        {
            CFECHAALTAALMACEN = DateTime.Today;
            CFECHAEXTRA = SdkDateTimeHelper.CreateDefaultSdkFecha();
            CSISTORIG = 205;
        }

        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CIDALMACEN.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CCODIGOALMACEN.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CNOMBREALMACEN.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public override string ToString()
        {
            return $"{CCODIGOALMACEN} - {CNOMBREALMACEN}";
        }
    }
}
