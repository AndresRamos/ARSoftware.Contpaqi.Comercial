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

namespace Sdk.Extras.WpfApp.ViewModels.Agentes;

public class SeleccionarAgenteViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private Agente _agenteSeleccionado;
    private string _filtro;

    public SeleccionarAgenteViewModel(IAgenteRepository<Agente> agenteRepository)
    {
        _agenteRepository = agenteRepository;
        Agentes = new ObservableCollection<Agente>();
        AgentesView = CollectionViewSource.GetDefaultView(Agentes);
        AgentesView.Filter = AgentesView_Filter;

        SeleccionarCommand = new RelayCommand(Seleccionar, CanSeleccionar);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public ObservableCollection<Agente> Agentes { get; }

    public Agente AgenteSeleccionado
    {
        get => _agenteSeleccionado;
        set
        {
            SetProperty(ref _agenteSeleccionado, value);
            RaiseGuards();
        }
    }

    public ICollectionView AgentesView { get; }
    public IRelayCommand CancelarCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            AgentesView.Refresh();
        }
    }

    public IRelayCommand SeleccionarCommand { get; }

    public bool SeleccionoAgente { get; private set; }

    public string Title => "Seleccionar Agente";

    private bool AgentesView_Filter(object obj)
    {
        var agente = obj as Agente;
        if (agente is null) throw new ArgumentNullException(nameof(obj));

        return agente.Contains(Filtro);
    }

    public bool CanSeleccionar()
    {
        return AgenteSeleccionado != null;
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public void Inicializar()
    {
        Agentes.Clear();
        foreach (Agente agente in _agenteRepository.TraerTodo()) Agentes.Add(agente);
    }

    private void RaiseGuards()
    {
        SeleccionarCommand.NotifyCanExecuteChanged();
        CancelarCommand.NotifyCanExecuteChanged();
    }

    public void Seleccionar()
    {
        SeleccionoAgente = true;
        CerrarVista();
    }
}
