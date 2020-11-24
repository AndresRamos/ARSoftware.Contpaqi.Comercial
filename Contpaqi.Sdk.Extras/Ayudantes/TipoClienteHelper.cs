using Contpaqi.Sdk.Extras.Modelos.Enums;

namespace Contpaqi.Sdk.Extras.Ayudantes
{
    public static class TipoClienteHelper
    {
        public static string ToSdkString(this TipoClienteEnum tipo)
        {
            return ((int) tipo).ToString();
        }

        public static bool EsCliente(string tipoDeCliente)
        {
            return tipoDeCliente == TipoClienteEnum.Cliente.ToSdkString() || tipoDeCliente == TipoClienteEnum.ClienteProveedor.ToSdkString();
        }

        public static bool EsProveedor(string tipoDeCliente)
        {
            return tipoDeCliente == TipoClienteEnum.Proveedor.ToSdkString() || tipoDeCliente == TipoClienteEnum.ClienteProveedor.ToSdkString();
        }
    }
}