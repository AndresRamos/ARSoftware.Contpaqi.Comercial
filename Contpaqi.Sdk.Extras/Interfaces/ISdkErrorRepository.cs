namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface ISdkErrorRepository<T> where T : ISdkError
    {
        string FindMensajeByNumero(int numeroError);
        T FindByNumero(int numeroError);
    }
}