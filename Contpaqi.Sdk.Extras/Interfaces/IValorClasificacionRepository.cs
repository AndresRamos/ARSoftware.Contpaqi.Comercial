﻿using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IValorClasificacionRepository<T> where T : class, new()
    {
        T BuscarPorId(int idValorClasificacion);

        T BuscarPorTipoClasificacionNumeroYCodigo(TipoClasificacion tipoClasificacion,
                                                  int numeroClasificacion,
                                                  string codigoValorClasificacion);

        IEnumerable<T> TraerPorClasificacionId(int idClasificacion);
        IEnumerable<T> TraerPorClasificacionTipoYNumero(TipoClasificacion tipoClasificacion, NumeroClasificacion numeroClasificacion);
        IEnumerable<T> TraerTodo();
    }
}
