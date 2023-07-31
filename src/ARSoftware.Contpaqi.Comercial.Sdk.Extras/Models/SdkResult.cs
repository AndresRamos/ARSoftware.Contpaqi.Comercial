using ARSoftware.Contpaqi.Comercial.Sdk.Excepciones;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Constants;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class SdkResult
{
    private readonly ISdkErrorRepository<SdkError> _sdkErrorRepository;
    private int _result;

    public SdkResult(IContpaqiSdk contpaqiSdk)
    {
        _sdkErrorRepository = new SdkErrorRepository(contpaqiSdk);
    }

    public SdkResult(ISdkErrorRepository<SdkError> sdkErrorRepository)
    {
        _sdkErrorRepository = sdkErrorRepository;
    }

    public bool IsSuccess => Result == SdkResultConstants.Success;

    public int Result
    {
        get => _result;
        set
        {
            _result = value;
            SdkError = value != 0 ? _sdkErrorRepository.BuscarPorNumero(value) : new SdkError();
        }
    }

    public SdkError SdkError { get; set; } = new();

    public void ThrowIfError()
    {
        if (!IsSuccess) throw new ContpaqiSdkException(SdkError.Numero, SdkError.MensajeConNumero);
    }
}
