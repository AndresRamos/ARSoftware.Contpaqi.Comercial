﻿using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IClasificacionRepository<T> where T : class, new()
    {
        T BuscarPorId(int idClasificacion);
        T BuscarPorTipoYNumero(TipoClasificacion tipo, NumeroClasificacion numero);
        IEnumerable<T> TraerPorTipo(TipoClasificacion tipo);
        IEnumerable<T> TraerTodo();
    }
}