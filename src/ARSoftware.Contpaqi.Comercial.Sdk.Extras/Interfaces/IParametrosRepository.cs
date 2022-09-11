namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces
{
    public interface IParametrosRepository<T> where T : class, new()
    {
        T Buscar();
    }
}
