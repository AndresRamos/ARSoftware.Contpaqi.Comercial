namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

public class Empresa
{
    public string Nombre { get; set; } = string.Empty;
    public string Ruta { get; set; } = string.Empty;
    public string BaseDatos { get; set; } = string.Empty;
    public Parametros? Parametros { get; set; }
}