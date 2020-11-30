namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IDireccionRepository<T> where T : IDireccion
    {
        T BuscarPorCliente(string codigoClienteProveedor, byte tipoDireccion);
        T BuscarPorDocumento(int idDocumento, byte tipoDireccion);
    }
}