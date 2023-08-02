using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Parametros solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar los parametros de la empresa cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Parametros, como por ejemplo los que
///     implementan <see cref="IParametrosRepository{T}" /> de <see cref="ParametrosDto" />.
/// </summary>
public class ParametrosDto
{
    /// <summary>
    ///     RFC de la empresa.
    /// </summary>
    public string CRFCEMPRESA { get; set; } = string.Empty;

    /// <summary>
    ///     Identificador global único de la empresa en el Administrador de Documentos Digitales (ADD).
    /// </summary>
    public string CGUIDDSL { get; set; } = string.Empty;
}
