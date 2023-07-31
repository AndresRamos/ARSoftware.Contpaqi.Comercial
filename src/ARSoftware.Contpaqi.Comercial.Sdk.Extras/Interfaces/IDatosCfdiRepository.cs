using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface IDatosCfdiRepository
{
    DatosCfdi BuscarPorDocumentoId(int idDocumento);
}
