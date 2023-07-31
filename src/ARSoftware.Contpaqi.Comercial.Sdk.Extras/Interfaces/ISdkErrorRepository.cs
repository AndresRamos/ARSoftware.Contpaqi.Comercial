namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;

public interface ISdkErrorRepository<T>
{
    string BuscarMensajePorNumero(int numeroError);
    T BuscarPorNumero(int numeroError);
}
