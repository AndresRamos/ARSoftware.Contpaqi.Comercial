namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDireccionRepository<T> where T : IDireccion
    {
        T FindByCliente(string codigoClienteProveedor, byte tipoDireccion);
        T FindByDocumento(int idDocumento, byte tipoDireccion);
    }
}