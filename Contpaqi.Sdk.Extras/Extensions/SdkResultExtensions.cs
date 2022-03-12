using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Extensions
{
    public static class SdkResultExtensions
    {
        public static SdkResult ToResultadoSdk(this int numeroResultadoSdk, IContpaqiSdk sdk)
        {
            return new SdkResult(sdk) { Result = numeroResultadoSdk };
        }
    }
}
