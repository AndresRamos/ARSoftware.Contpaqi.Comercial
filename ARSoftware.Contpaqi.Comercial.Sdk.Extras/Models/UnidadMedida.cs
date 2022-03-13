using System;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class UnidadMedida : admUnidadesMedidaPeso
    {
        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CIDUNIDAD.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CNOMBREUNIDAD.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public override string ToString()
        {
            return CNOMBREUNIDAD;
        }

        public tUnidad ToTUnidad()
        {
            return new tUnidad { cNombreUnidad = CNOMBREUNIDAD, cAbreviatura = CABREVIATURA, cDespliegue = CDESPLIEGUE };
        }
    }
}
