namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;

public class Empresa
{
    /// <summary>
    ///     Id de la empresa.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     Nombre de la empresa.
    /// </summary>
    public string Nombre { get; set; } = string.Empty;

    /// <summary>
    ///     Ruta de la empresa.
    /// </summary>
    public string Ruta { get; set; } = string.Empty;

    /// <summary>
    ///     Nombre de la base de datos.
    /// </summary>
    public string BaseDatos { get; set; } = string.Empty;

    /// <summary>
    ///     Parámetros de la empresa.
    /// </summary>
    public Parametros? Parametros { get; set; }
}
