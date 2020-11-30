namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface ISdkErrorRepository<T> where T : ISdkError
    {
        string BuscarMensajePorNumero(int numeroError);
        T BuscarPorNumero(int numeroError);
    }
}