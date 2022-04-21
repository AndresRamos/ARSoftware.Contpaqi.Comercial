﻿using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IMovimientoService
    {
        void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento);
        int Crear(int idDocumento, tMovimiento movimiento);
        int Crear(Dictionary<string, string> datosMovimiento);
        void Eliminar(int idDocumento, int idMovimiento);
    }
}