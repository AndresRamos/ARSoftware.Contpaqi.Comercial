namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

public interface IParametrosRepository<T> where T : class, new()
{
    T Buscar();
}