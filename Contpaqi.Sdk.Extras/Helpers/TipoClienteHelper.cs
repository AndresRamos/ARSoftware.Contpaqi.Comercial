using System;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class TipoClienteHelper
    {
        public static TipoClienteEnum ConvertToTipoClienteEnum(string tipo)
        {
            var result = Enum.TryParse(tipo, true, out TipoClienteEnum tipoCliente);

            if (result)
            {
                return tipoCliente;
            }

            throw new InvalidOperationException($"El tipo {tipo} no es un tipo de cliente valido.");
        }

        public static bool IsCliente(string tipoDeCliente)
        {
            return ConvertToTipoClienteEnum(tipoDeCliente) == TipoClienteEnum.Cliente || ConvertToTipoClienteEnum(tipoDeCliente) == TipoClienteEnum.ClienteProveedor;
        }

        public static bool IsProveedor(string tipoDeCliente)
        {
            return ConvertToTipoClienteEnum(tipoDeCliente) == TipoClienteEnum.Proveedor || ConvertToTipoClienteEnum(tipoDeCliente) == TipoClienteEnum.ClienteProveedor;
        }
    }
}