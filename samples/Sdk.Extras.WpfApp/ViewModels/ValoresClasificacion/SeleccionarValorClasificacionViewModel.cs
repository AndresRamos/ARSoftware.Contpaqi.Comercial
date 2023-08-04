using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

public class SeleccionarValorClasificacionViewModel : ObservableRecipient
{
    private string _filtro;
    private ValorClasificacion _valorSeleccionado;

    public SeleccionarValorClasificacionViewModel()
    {
        ValoresView = CollectionViewSource.GetDefaultView(Valores);
        ValoresView.Filter = ValoresView_Filter;

        SeleccionarCommand = new RelayCommand(Seleccionar, CanSeleccionar);
        CancelarCommand = new RelayCommand(Cancelar);
    }

    public IRelayCommand CancelarCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            ValoresView.Refresh();
        }
    }

    public IRelayCommand SeleccionarCommand { get; }

    public bool SeleccionoValor { get; private set; }

    public string Title { get; } = "Seleccionar Valor De Clasificacion";

    public ObservableCollection<ValorClasificacion> Valores { get; } = new();

    public ICollectionView ValoresView { get; }

    public ValorClasificacion ValorSeleccionado
    {
        get => _valorSeleccionado;
        set
        {
            SetProperty(ref _valorSeleccionado, value);
            RaiseGuards();
        }
    }

    public void Cancelar()
    {
        SeleccionoValor = false;
        ValorSeleccionado = null;
        CerrarVista();
    }

    public bool CanSeleccionar()
    {
        return ValorSeleccionado != null;
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public void Inicializar(IEnumerable<ValorClasificacion> valores)
    {
        SeleccionoValor = false;
        Valores.Clear();
        foreach (ValorClasificacion valor in valores) Valores.Add(valor);

        ValorSeleccionado = Valores.FirstOrDefault();
    }

    private void RaiseGuards()
    {
        SeleccionarCommand.NotifyCanExecuteChanged();
    }

    public void Seleccionar()
    {
        SeleccionoValor = true;
        CerrarVista();
    }

    private bool ValoresView_Filter(object obj)
    {
        var valor = obj as ValorClasificacion;
        if (valor is null) throw new ArgumentException("El parametro no es un tipo valido", nameof(obj));

        return valor.Contains(Filtro);
    }
}
