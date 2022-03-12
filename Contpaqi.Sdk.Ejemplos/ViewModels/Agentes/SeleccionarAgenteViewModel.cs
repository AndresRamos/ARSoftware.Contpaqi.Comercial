using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Agentes;

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

    public string Title => "Seleccionar Agente";

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            AgentesView.Refresh();
        }
    }

    public ObservableCollection<Agente> Agentes { get; }

    public ICollectionView AgentesView { get; }

    public Agente AgenteSeleccionado
    {
        get => _agenteSeleccionado;
        set
        {
            SetProperty(ref _agenteSeleccionado, value);
            RaiseGuards();
        }
    }

    public bool SeleccionoAgente { get; private set; }

    public IRelayCommand SeleccionarCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public void Inicializar()
    {
        Agentes.Clear();
        foreach (Agente agente in _agenteRepository.TraerTodo())
        {
            Agentes.Add(agente);
        }
    }

    public void Seleccionar()
    {
        SeleccionoAgente = true;
        CerrarVista();
    }

    public bool CanSeleccionar()
    {
        return AgenteSeleccionado != null;
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private void RaiseGuards()
    {
        SeleccionarCommand.NotifyCanExecuteChanged();
        CancelarCommand.NotifyCanExecuteChanged();
    }

    private bool AgentesView_Filter(object obj)
    {
        var agente = obj as Agente;
        if (agente is null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        return agente.Contains(Filtro);
    }
}
