using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.Empresas;

public class SeleccionarEmpresaViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IEmpresaRepository<Empresa> _empresaRepository;
    private string _duracionBusqueda;
    private Empresa _empresaSeleccionada;
    private string _filtro;

    public SeleccionarEmpresaViewModel(IEmpresaRepository<Empresa> empresaRepository, IDialogCoordinator dialogCoordinator)
    {
        _empresaRepository = empresaRepository;
        _dialogCoordinator = dialogCoordinator;

        Empresas = new ObservableCollection<Empresa>();
        EmpresasView = CollectionViewSource.GetDefaultView(Empresas);
        EmpresasView.Filter = EmpresasView_Filter;

        BuscarEmpresasCommand = new AsyncRelayCommand(BuscarEmpresasAsync);
        SeleccionarCommand = new RelayCommand(Seleccionar, CanSeleccionar);
        CancelarCommand = new RelayCommand(Cancelar);
    }

    public IAsyncRelayCommand BuscarEmpresasCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        set => SetProperty(ref _duracionBusqueda, value);
    }

    public ObservableCollection<Empresa> Empresas { get; }

    public Empresa EmpresaSeleccionada
    {
        get => _empresaSeleccionada;
        set
        {
            SetProperty(ref _empresaSeleccionada, value);
            SeleccionarCommand.NotifyCanExecuteChanged();
        }
    }

    public ICollectionView EmpresasView { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            EmpresasView.Refresh();
        }
    }

    public IRelayCommand SeleccionarCommand { get; }

    public bool SeleccionoEmpresa { get; private set; }

    public string Title { get; } = "Seleccionar Empresa";

    public async Task BuscarEmpresasAsync()
    {
        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Empresas.Clear();
            foreach (Empresa empresa in _empresaRepository.TraerTodo().OrderBy(e => e.CNOMBREEMPRESA)) Empresas.Add(empresa);

            stopwatch.Stop();
            DuracionBusqueda = stopwatch.Elapsed.ToString("g");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Cancelar()
    {
        SeleccionoEmpresa = false;
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public bool CanSeleccionar()
    {
        return EmpresaSeleccionada != null;
    }

    private bool EmpresasView_Filter(object obj)
    {
        if (!(obj is Empresa empresa)) throw new ArgumentNullException(nameof(obj));

        return empresa.Contains(Filtro);
    }

    public void Seleccionar()
    {
        SeleccionoEmpresa = true;
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }
}
