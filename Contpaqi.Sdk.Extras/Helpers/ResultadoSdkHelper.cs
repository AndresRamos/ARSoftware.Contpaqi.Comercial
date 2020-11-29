using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class ResultadoSdkHelper
    {
        public static SdkResult ToResultadoSdk(this int numeroResultadoSdk, IContpaqiSdk sdk)
        {
            var resultadoSDk = new SdkResult(sdk) {Result = numeroResultadoSdk};
            return resultadoSDk;
        }
    }
}