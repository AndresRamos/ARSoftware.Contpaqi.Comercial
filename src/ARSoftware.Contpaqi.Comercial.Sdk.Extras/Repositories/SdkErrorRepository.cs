using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

public class SdkErrorRepository : ISdkErrorRepository<SdkError>
{
    private readonly IContpaqiSdk _sdk;

    public SdkErrorRepository(IContpaqiSdk sdk)
    {
        _sdk = sdk;
    }

    public string BuscarMensajePorNumero(int numeroError)
    {
        return _sdk.LeeMensajeError(numeroError);
    }

    public SdkError BuscarPorNumero(int numeroError)
    {
        return new SdkError { Numero = numeroError, Mensaje = BuscarMensajePorNumero(numeroError) };
    }
}
