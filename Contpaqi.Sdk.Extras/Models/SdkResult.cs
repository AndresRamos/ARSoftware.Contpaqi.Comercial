using Contpaqi.Sdk.Extras.Exceptions;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Repositories;

namespace Contpaqi.Sdk.Extras.Models
{
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

        public SdkError SdkError { get; set; } = new SdkError();

        public void ThrowIfError()
        {
            if (!IsSuccess)
            {
                throw new ContpaqiSdkException(SdkError.Numero, SdkError.MensajeConNumero);
            }
        }
    }
}
