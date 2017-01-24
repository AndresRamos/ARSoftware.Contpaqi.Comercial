using System.Text;

namespace Contpaqi.SistemasComerciales.Sdk.Extras
{
    public static class ErroresAdminpaq
    {
        public static string LeerError(int error)
        {
            StringBuilder mensageDelError = new StringBuilder(512);
            AdminpaqSdk.fError(error, mensageDelError, 512);
            return mensageDelError.ToString();
        }
    }
}