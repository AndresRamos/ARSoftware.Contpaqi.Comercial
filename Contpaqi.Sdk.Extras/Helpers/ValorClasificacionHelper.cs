using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ValorClasificacionHelper
    {
        public static tValorClasificacion ToTValorClasificacion(this ValorClasificacion valorClasificacion)
        {
            return new tValorClasificacion
            {
                cNumClasificacion = valorClasificacion.Id,
                cClasificacionDe = valorClasificacion.IdClasificacion,
                cCodigoValorClasificacion = valorClasificacion.Codigo,
                cValorClasificacion = valorClasificacion.Valor
            };
        }
    }
}