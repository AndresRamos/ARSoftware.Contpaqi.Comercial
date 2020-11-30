using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ResultadoSdkHelper
    {
        public static SdkResult ToResultadoSdk(this int numeroResultadoSdk, IContpaqiSdk sdk)
        {
            return new SdkResult(sdk) {Result = numeroResultadoSdk};
        }
    }
}