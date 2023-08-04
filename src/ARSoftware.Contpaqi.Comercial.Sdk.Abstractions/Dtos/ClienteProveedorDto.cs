using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

/// <summary>
///     Cliente o proveedor solo con las propiedades mas comunes.
///     Este modelo se puede utilizar para consultar el catalogo de clientes y proveedores cuando solo se necesitan algunas
///     propiedades.
///     Las propiedades de este modelo tienen los los mismos nombres que las propiedades del modelo de SQL para facilitar
///     la asignacion de valores cuando se utiliza con los repositorios genericos de Clientes y Proveedores, como por
///     ejemplo los que implementan <see cref="IClienteProveedorRepository{T}" /> de <see cref="ClienteProveedorDto" />.
/// </summary>
public class ClienteProveedorDto
{
    /// <summary>
    ///     Id del cliente o proveedor.
    /// </summary>
    public int CIDCLIENTEPROVEEDOR { get; set; }

    /// <summary>
    ///     Código del cliente o proveedor.
    /// </summary>
    public string CCODIGOCLIENTE { get; set; } = string.Empty;

    /// <summary>
    ///     Razón Social del cliente o proveedor.
    /// </summary>
    public string CRAZONSOCIAL { get; set; } = string.Empty;

    /// <summary>
    ///     Registro Federal de Contribuyentes del cliente.
    /// </summary>
    public string CRFC { get; set; } = string.Empty;

    /// <summary>
    ///     Tipo de cliente o proveedor: 1 = Cliente, 2 = Cliente/Proveedor, 3 = Proveedor
    /// </summary>
    public int CTIPOCLIENTE { get; set; }

    /// <summary>
    ///     Uso que el cliente le dará a los CFDIs por omisión.
    /// </summary>
    public string CUSOCFDI { get; set; } = string.Empty;

    /// <summary>
    ///     Régimen Fiscal del cliente.
    /// </summary>
    public string CREGIMFISC { get; set; } = string.Empty;
}
