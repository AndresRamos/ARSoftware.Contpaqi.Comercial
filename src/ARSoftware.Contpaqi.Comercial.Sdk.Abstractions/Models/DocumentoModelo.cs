namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class DocumentoModelo
{
    /// <summary>
    ///     Id del documento modelo.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Descripción del documento modelo.
    /// </summary>
    public string Descripcion { get; set; } = string.Empty;
}
