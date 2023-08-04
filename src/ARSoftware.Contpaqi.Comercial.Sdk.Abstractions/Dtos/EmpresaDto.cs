using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Empresa solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de empresas cuando solo se necesitan algunas propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Empresas, como por ejemplo los que
///     implementan <see cref="IEmpresaRepository{T}" /> de <see cref="EmpresaDto" />.
/// </summary>
public class EmpresaDto
{
    /// <summary>
    ///     Id de la empresa.
    /// </summary>
    public int CIDEMPRESA { get; set; }

    /// <summary>
    ///     Nombre de la empresa.
    /// </summary>
    public string CNOMBREEMPRESA { get; set; } = string.Empty;

    /// <summary>
    ///     Ruta de la empresa.
    /// </summary>
    public string CRUTADATOS { get; set; } = string.Empty;
}
