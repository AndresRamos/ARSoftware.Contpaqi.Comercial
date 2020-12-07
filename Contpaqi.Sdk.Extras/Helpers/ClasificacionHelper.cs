using System;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ClasificacionHelper
    {
        public static int BuscarNumeroPorId(int idClasificacion)
        {
            var id = idClasificacion;
            return
                id == 1 ? 1 :
                id == 2 ? 2 :
                id == 3 ? 3 :
                id == 4 ? 4 :
                id == 5 ? 5 :
                id == 6 ? 6 :
                id == 7 ? 1 :
                id == 8 ? 2 :
                id == 9 ? 3 :
                id == 10 ? 4 :
                id == 11 ? 5 :
                id == 12 ? 6 :
                id == 13 ? 1 :
                id == 14 ? 2 :
                id == 15 ? 3 :
                id == 16 ? 4 :
                id == 17 ? 5 :
                id == 18 ? 6 :
                id == 19 ? 1 :
                id == 20 ? 2 :
                id == 21 ? 3 :
                id == 22 ? 4 :
                id == 23 ? 5 :
                id == 24 ? 6 :
                id == 25 ? 1 :
                id == 26 ? 2 :
                id == 27 ? 3 :
                id == 28 ? 4 :
                id == 29 ? 5 :
                id == 30 ? 6 :
                id == 31 ? 1 : throw new ArgumentException("El id no es un un id valido.");
        }
    }
}