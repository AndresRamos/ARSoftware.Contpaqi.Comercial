using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;

public static class SdkResultExtensions
{
    public static SdkResult ToResultadoSdk(this int numeroResultadoSdk, IContpaqiSdk sdk)
    {
        return new SdkResult(sdk) { Result = numeroResultadoSdk };
    }
}
