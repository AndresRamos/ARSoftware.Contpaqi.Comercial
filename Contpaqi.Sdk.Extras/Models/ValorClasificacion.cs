using System;
using Contpaqi.Comercial.Sql.Models.Empresa;
using Contpaqi.Sdk.DatosAbstractos;

namespace Contpaqi.Sdk.Extras.Models
{
    public class ValorClasificacion : admClasificacionesValores
    {
        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CCODIGOVALORCLASIFICACION.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CVALORCLASIFICACION.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public override string ToString()
        {
            return $"{CCODIGOVALORCLASIFICACION} - {CVALORCLASIFICACION}";
        }

        public tValorClasificacion ToTValorClasificacion()
        {
            return new tValorClasificacion
            {
                cNumClasificacion = CIDVALORCLASIFICACION,
                cClasificacionDe = CIDCLASIFICACION,
                cCodigoValorClasificacion = CCODIGOVALORCLASIFICACION,
                cValorClasificacion = CVALORCLASIFICACION
            };
        }
    }
}
