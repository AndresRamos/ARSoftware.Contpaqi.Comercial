using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Producto solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar los productos cuando solo se necesitan algunas propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Producto, como por ejemplo los que
///     implementan <see cref="IProductoRepository{T}" /> de <see cref="ProductoDto" />.
/// </summary>
public class ProductoDto
{
    /// <summary>
    ///     Id del producto.
    /// </summary>
    public int CIDPRODUCTO { get; set; }

    /// <summary>
    ///     Código del producto.
    /// </summary>
    public string CCODIGOPRODUCTO { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre del producto.
    /// </summary>
    public string CNOMBREPRODUCTO { get; set; } = string.Empty;

    /// <summary>
    ///     Tipo de producto: 1 = Producto, 2 = Paquete, 3 = Servicio
    /// </summary>
    public int CTIPOPRODUCTO { get; set; }

    /// <summary>
    ///     Clave SAT para identificar al producto o servicio.
    /// </summary>
    public string CCLAVESAT { get; set; } = string.Empty;
}
