using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Agentes
{
    public class EditarAgenteViewModel : ObservableRecipient
    {
        private readonly IAgenteRepository<Agente> _agenteRepository;
        private readonly IAgenteService _agenteService;
        private readonly IDialogCoordinator _dialogCoordinator;
        private Agente _agente;

        public EditarAgenteViewModel(IAgenteService agenteService, IAgenteRepository<Agente> agenteRepository, IDialogCoordinator dialogCoordinator)
        {
            _agenteService = agenteService;
            _agenteRepository = agenteRepository;
            _dialogCoordinator = dialogCoordinator;

            GuardarCommand = new AsyncRelayCommand(GudardarAsync);
            CancelarCommand = new RelayCommand(CerrarVista);
        }

        public string Title { get; } = "Editar Agente";

        public IEnumerable<TipoAgenteEnum> TiposAgente { get; } = Enum.GetValues(typeof(TipoAgenteEnum)).Cast<TipoAgenteEnum>().ToList();

        public Agente Agente
        {
            get => _agente;
            private set => SetProperty(ref _agente, value);
        }

        public IAsyncRelayCommand GuardarCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public void Inicializar()
        {
            Agente = new Agente
            {
                Tipo = TipoAgenteEnum.VentasCobro
            };
        }

        public void Inicializar(int idAgente)
        {
            CargarAgente(idAgente);
        }

        public async Task GudardarAsync()
        {
            var datosAgente = Agente.ToDatosDictionary();

            if (Agente.Id == 0)
            {
                datosAgente.Remove("CIDDIRECCION");
                var agenteId = _agenteService.Crear(datosAgente);

                CargarAgente(agenteId);
                await _dialogCoordinator.ShowMessageAsync(this, "Agente Creado", "Agente creado exitosamente.");
            }
            else
            {
                datosAgente.Remove("CIDAGENTE");
                _agenteService.Actualizar(Agente.Id, datosAgente);
                CargarAgente(Agente.Id);
                await _dialogCoordinator.ShowMessageAsync(this, "Agente Guardado", "Agente guardado exitosamente.");
            }
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        private void CargarAgente(int idAgente)
        {
            Agente = _agenteRepository.BuscarPorId(idAgente);
        }
    }
}