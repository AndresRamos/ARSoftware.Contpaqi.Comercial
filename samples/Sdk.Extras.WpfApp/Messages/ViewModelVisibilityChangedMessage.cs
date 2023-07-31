namespace Sdk.Extras.WpfApp.Messages;

public class ViewModelVisibilityChangedMessage
{
    public ViewModelVisibilityChangedMessage(object sender, bool isOpen)
    {
        Sender = sender;
        IsOpen = isOpen;
    }

    public bool IsOpen { get; }

    public object Sender { get; }
}
