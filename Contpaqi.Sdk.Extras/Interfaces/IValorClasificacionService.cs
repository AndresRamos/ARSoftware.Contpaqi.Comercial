using System.Collections.Generic;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IValorClasificacionService
    {
        int Crear(tValorClasificacion valorClasificacion);
        void Actualizar(int idValorClasificacion, Dictionary<string, string> datosValorClasificacion);
        void Eliminar(int idValorClasificacion);
    }
}