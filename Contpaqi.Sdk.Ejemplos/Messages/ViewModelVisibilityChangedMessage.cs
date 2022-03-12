﻿namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;

public class ViewModelVisibilityChangedMessage
{
    public ViewModelVisibilityChangedMessage(object sender, bool isOpen)
    {
        Sender = sender;
        IsOpen = isOpen;
    }

    public object Sender { get; }

    public bool IsOpen { get; }
}
