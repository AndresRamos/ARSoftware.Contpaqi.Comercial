using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IMovimientoService
    {
        int Crear(int idDocumento, tMovimiento movimiento);
        void Actualizar(int idMovimiento, Dictionary<string, string> datosMovimiento);
        void Eliminar(int idDocumento, int idMovimiento);
    }
}