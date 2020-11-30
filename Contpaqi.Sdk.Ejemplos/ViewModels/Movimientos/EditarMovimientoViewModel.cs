using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Movimientos
{
    public class EditarMovimientoViewModel : ObservableRecipient
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
        private readonly IMovimientoService _movimientoService;
        private Movimiento _movimiento;

        public EditarMovimientoViewModel(IMovimientoRepository<Movimiento> movimientoRepository, IMovimientoService movimientoService, IDialogCoordinator dialogCoordinator)
        {
            _movimientoRepository = movimientoRepository;
            _movimientoService = movimientoService;
            _dialogCoordinator = dialogCoordinator;

            GuardarMovimientoCommand = new AsyncRelayCommand(ActualizarMovimientoAsync);
            CancelarCommand = new RelayCommand(CerrarVista);
        }

        public string Title { get; } = "Editar Movimiento";

        public int DocumentoId { get; private set; }

        public Movimiento Movimiento
        {
            get => _movimiento;
            private set => SetProperty(ref _movimiento, value);
        }

        public IAsyncRelayCommand GuardarMovimientoCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public void Inicializar(int documentoId, int movimientoId)
        {
            DocumentoId = documentoId;
            Movimiento = _movimientoRepository.BuscarPorId(movimientoId);
        }

        public async Task ActualizarMovimientoAsync()
        {
            try
            {
                var datos = new Dictionary<string, string>();

                // Referencia 
                datos.Add("CREFERENCIA", Movimiento.Referencia);

                // Texto Extra 1
                datos.Add("CTEXTOEXTRA1", Movimiento.TextoExtra1);

                // Texto Extra 2
                datos.Add("CTEXTOEXTRA2", Movimiento.TextoExtra2);

                // Texto Extra 3
                datos.Add("CTEXTOEXTRA3", Movimiento.TextoExtra3);

                // Observaciones
                datos.Add("COBSERVAMOV", Movimiento.Observaciones);

                _movimientoService.Actualizar(Movimiento.Id, datos);

                CerrarVista();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }
    }
}