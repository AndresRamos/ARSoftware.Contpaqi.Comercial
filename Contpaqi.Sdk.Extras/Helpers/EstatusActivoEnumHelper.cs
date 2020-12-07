using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class EstatusActivoEnumHelper
    {
        public static EstatusActivoEnum ConvertToEstatusActivoEnum(string estatus)
        {
            var result = Enum.TryParse(estatus, true, out EstatusActivoEnum estatusActivo);

            if (result)
            {
                return estatusActivo;
            }

            throw new InvalidOperationException($"El estatus {estatusActivo} no es un estatus valido.");
        }
    }
}