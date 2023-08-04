using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.Almacenes;

public class SeleccionarAlmacenViewModel : ObservableRecipient
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private Almacen _almacenSeleccionado;
    private string _filtro;

    public SeleccionarAlmacenViewModel(IAlmacenRepository<Almacen> almacenRepository)
    {
        _almacenRepository = almacenRepository;
        Almacenes = new ObservableCollection<Almacen>();
        AlmacenesView = CollectionViewSource.GetDefaultView(Almacenes);
        AlmacenesView.Filter = AlmacenesView_Filter;

        SeleccionarCommand = new RelayCommand(Seleccionar, CanSelccionar);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public ObservableCollection<Almacen> Almacenes { get; }

    public ICollectionView AlmacenesView { get; }

    public Almacen AlmacenSeleccionado
    {
        get => _almacenSeleccionado;
        set
        {
            SetProperty(ref _almacenSeleccionado, value);
            RaiseGuards();
        }
    }

    public IRelayCommand CancelarCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            AlmacenesView.Refresh();
        }
    }

    public IRelayCommand SeleccionarCommand { get; }

    public bool SeleccionoAlmacen { get; private set; }

    public string Title => "Seleccionar Almacen";

    private bool AlmacenesView_Filter(object obj)
    {
        if (!(obj is Almacen almacen)) throw new ArgumentNullException(nameof(obj));

        return almacen.Contains(Filtro);
    }

    public bool CanSelccionar()
    {
        return AlmacenSeleccionado != null;
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public void Inicializar()
    {
        Almacenes.Clear();
        foreach (Almacen almacen in _almacenRepository.TraerTodo()) Almacenes.Add(almacen);
    }

    private void RaiseGuards()
    {
        SeleccionarCommand.NotifyCanExecuteChanged();
        CancelarCommand.NotifyCanExecuteChanged();
    }

    public void Seleccionar()
    {
        SeleccionoAlmacen = true;
        CerrarVista();
    }
}
