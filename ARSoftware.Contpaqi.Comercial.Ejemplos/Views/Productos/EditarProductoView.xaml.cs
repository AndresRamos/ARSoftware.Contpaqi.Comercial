﻿using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Productos;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Views.Productos;

public partial class EditarProductoView
{
    public EditarProductoView()
    {
        InitializeComponent();
        DataContext = Ioc.Default.GetService<EditarProductoViewModel>();
        WeakReferenceMessenger.Default.Register<ViewModelVisibilityChangedMessage>(this,
            (recipient, message) =>
            {
                if (message.Sender == ViewModel && message.IsOpen == false)
                {
                    var view = (EditarProductoView)recipient;
                    view.Close();
                }
            });
    }

    public EditarProductoViewModel ViewModel => (EditarProductoViewModel)DataContext;
}