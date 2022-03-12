namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface ISdkErrorRepository<T>
    {
        string BuscarMensajePorNumero(int numeroError);
        T BuscarPorNumero(int numeroError);
    }
}
