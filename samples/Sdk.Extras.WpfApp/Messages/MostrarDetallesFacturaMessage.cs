namespace Sdk.Extras.WpfApp.Messages;

public class MostrarDetallesFacturaMessage
{
    public MostrarDetallesFacturaMessage(int facturaId)
    {
        FacturaId = facturaId;
    }

    public int FacturaId { get; }
}
