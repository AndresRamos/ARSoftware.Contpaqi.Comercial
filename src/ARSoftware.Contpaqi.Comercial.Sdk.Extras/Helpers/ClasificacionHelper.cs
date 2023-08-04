using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;

public static class ClasificacionHelper
{
    public static int BuscarNumeroPorId(int idClasificacion)
    {
        return idClasificacion == 1 ? 1 :
            idClasificacion == 2 ? 2 :
            idClasificacion == 3 ? 3 :
            idClasificacion == 4 ? 4 :
            idClasificacion == 5 ? 5 :
            idClasificacion == 6 ? 6 :
            idClasificacion == 7 ? 1 :
            idClasificacion == 8 ? 2 :
            idClasificacion == 9 ? 3 :
            idClasificacion == 10 ? 4 :
            idClasificacion == 11 ? 5 :
            idClasificacion == 12 ? 6 :
            idClasificacion == 13 ? 1 :
            idClasificacion == 14 ? 2 :
            idClasificacion == 15 ? 3 :
            idClasificacion == 16 ? 4 :
            idClasificacion == 17 ? 5 :
            idClasificacion == 18 ? 6 :
            idClasificacion == 19 ? 1 :
            idClasificacion == 20 ? 2 :
            idClasificacion == 21 ? 3 :
            idClasificacion == 22 ? 4 :
            idClasificacion == 23 ? 5 :
            idClasificacion == 24 ? 6 :
            idClasificacion == 25 ? 1 :
            idClasificacion == 26 ? 2 :
            idClasificacion == 27 ? 3 :
            idClasificacion == 28 ? 4 :
            idClasificacion == 29 ? 5 :
            idClasificacion == 30 ? 6 :
            idClasificacion == 31 ? 1 : throw new ArgumentException("El id no es un un id valido.");
    }
}
