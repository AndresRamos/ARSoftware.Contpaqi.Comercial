namespace Contpaqi.Sdk.Ejemplos.Messages;

public class MostrarDetallesFacturaMessage
{
    public MostrarDetallesFacturaMessage(int facturaId)
    {
        FacturaId = facturaId;
    }

    public int FacturaId { get; }
}
