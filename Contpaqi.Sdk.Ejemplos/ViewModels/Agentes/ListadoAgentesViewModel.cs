using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Agentes
{
    public class ListadoAgentesViewModel : ObservableRecipient
    {
        private readonly IAgenteRepository<Agente> _agenteRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private Agente _agenteSeleccionado;
        private bool _buscarObjectosRelacionados = true;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoAgentesViewModel(IAgenteRepository<Agente> agenteRepository, IDialogCoordinator dialogCoordinator)
        {
            _agenteRepository = agenteRepository;
            _dialogCoordinator = dialogCoordinator;
            Agentes = new ObservableCollection<Agente>();
            AgentesView = CollectionViewSource.GetDefaultView(Agentes);
            AgentesView.Filter = AgentesView_Filter;

            BuscarAgentesCommand = new AsyncRelayCommand(BuscarAgentesAsync);
        }

        public string Title => "Agentes";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                AgentesView.Refresh();
                OnPropertyChanged(nameof(NumeroAgentes));
            }
        }

        public ObservableCollection<Agente> Agentes { get; }

        public ICollectionView AgentesView { get; }

        public Agente AgenteSeleccionado
        {
            get => _agenteSeleccionado;
            set => SetProperty(ref _agenteSeleccionado, value);
        }

        public bool BuscarObjectosRelacionados
        {
            get => _buscarObjectosRelacionados;
            set => SetProperty(ref _buscarObjectosRelacionados, value);
        }

        public int NumeroAgentes => AgentesView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarAgentesCommand { get; }

        public async Task BuscarAgentesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Agentes.Clear();
                foreach (var agente in _agenteRepository.GetAll())
                {
                    Agentes.Add(agente);
                    progressDialogController.SetMessage($"Numero de agentes: {Agentes.Count}");
                    await Task.Delay(50);
                }

                stopwatch.Stop();
                DuracionBusqueda = stopwatch.Elapsed.ToString("g");
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                await progressDialogController.CloseAsync();
                OnPropertyChanged(nameof(NumeroAgentes));
            }
        }

        private bool AgentesView_Filter(object obj)
        {
            var agente = obj as Agente;
            if (agente is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   agente.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   agente.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   agente.Nombre.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   agente.Tipo.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}