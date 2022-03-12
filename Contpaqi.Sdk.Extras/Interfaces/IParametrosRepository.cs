namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IParametrosRepository<T> where T : class, new()
    {
        T Buscar();
    }
}
