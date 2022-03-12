using System.Collections.Generic;
using Contpaqi.Sdk.DatosAbstractos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IUnidadMedidaService
    {
        void Actualizar(string nombreUnidad, tUnidad unidad);
        void Actualizar(int idUnidad, Dictionary<string, string> datosUnidad);
        int Crear(tUnidad unidad);
        int Crear(Dictionary<string, string> datosUnidad);
        void Eliminar(int idUnidad);
        void Eliminar(string codigoUnidad);
    }
}
