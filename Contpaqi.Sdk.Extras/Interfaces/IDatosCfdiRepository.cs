using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDatosCfdiRepository
    {
        DatosCfdi BuscarPorDocumentoId(int documentoId);
    }
}