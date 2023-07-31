namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

/// <summary>
///     Interfaz de repositorio que define métodos para consultar parámetros de la empresa.
/// </summary>
/// <typeparam name="T">
///     El tipo de parámetros utilizado por el repositorio.
/// </typeparam>
public interface IParametrosRepository<T> where T : class, new()
{
    /// <summary>
    ///     Busca los parámetros de la empresa.
    /// </summary>
    /// <returns>
    ///     Los parámetros de la empresa.
    /// </returns>
    T Buscar();
}
