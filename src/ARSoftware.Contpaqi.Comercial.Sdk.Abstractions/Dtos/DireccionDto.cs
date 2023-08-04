namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;

public class DireccionDto
{
    /// <summary>
    ///     Id de la dirección.
    /// </summary>
    public int CIDDIRECCION { get; set; }

    /// <summary>
    ///     Define el tipo del catalogo asociado: 1 = Clientes, 2 = Proveedores, 3 = Documentos, 4 = Empresas
    /// </summary>
    public int CTIPOCATALOGO { get; set; }

    /// <summary>
    ///     Tipo de dirección: 0 = Fiscal, 1 = Envío
    /// </summary>
    public int CTIPODIRECCION { get; set; }

    /// <summary>
    ///     Nombre de la calle.
    /// </summary>
    public string CNOMBRECALLE { get; set; } = null!;

    /// <summary>
    ///     Número exterior de la calle.
    /// </summary>
    public string CNUMEROEXTERIOR { get; set; } = null!;

    /// <summary>
    ///     Número interior del edificio o local.
    /// </summary>
    public string CNUMEROINTERIOR { get; set; } = null!;

    /// <summary>
    ///     Colonia o fraccionamiento.
    /// </summary>
    public string CCOLONIA { get; set; } = null!;

    /// <summary>
    ///     Nombre de la ciudad.
    /// </summary>
    public string CCIUDAD { get; set; } = null!;

    /// <summary>
    ///     Nombre del estado.
    /// </summary>
    public string CESTADO { get; set; } = null!;

    /// <summary>
    ///     Código postal.
    /// </summary>
    public string CCODIGOPOSTAL { get; set; } = null!;

    /// <summary>
    ///     Nombre del país.
    /// </summary>
    public string CPAIS { get; set; } = null!;
}
