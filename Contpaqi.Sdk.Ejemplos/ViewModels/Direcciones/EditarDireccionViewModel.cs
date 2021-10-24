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

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Direcciones
{
    public class EditarDireccionViewModel : ObservableRecipient
    {
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IDireccionRepository<Direccion> _direccionRepository;
        private readonly IDireccionService _direccionService;
        private Direccion _direccion;

        public EditarDireccionViewModel(IDireccionService direccionService, IDialogCoordinator dialogCoordinator, IDireccionRepository<Direccion> direccionRepository)
        {
            _direccionService = direccionService;
            _dialogCoordinator = dialogCoordinator;
            _direccionRepository = direccionRepository;

            GuardarUsandoFuncionesAltoNivelCommand = new AsyncRelayCommand(GuardarUsandoFuncionesAltoNivelAsync);
            GuardarUsandoFuncionesBajoNivelCommand = new AsyncRelayCommand(GuardarUsandoFuncionesBajoNivelAsync);
            CancelarCommand = new RelayCommand(CerrarVista);
        }

        public string Title { get; } = "Editar Direccion";

        public Direccion Direccion
        {
            get => _direccion;
            private set => SetProperty(ref _direccion, value);
        }

        public IEnumerable<TipoDireccionEnum> TiposDireccion { get; } = Enum.GetValues(typeof(TipoDireccionEnum)).Cast<TipoDireccionEnum>().ToList();

        public IAsyncRelayCommand GuardarUsandoFuncionesAltoNivelCommand { get; }
        public IAsyncRelayCommand GuardarUsandoFuncionesBajoNivelCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public void Inicializar(TipoCatalogoDireccion tipoCatalogoDireccion, string codigoClienteProveedor, int idCatalogo)
        {
            Direccion = new Direccion
            {
                CodigoClienteProveedor = codigoClienteProveedor,
                TipoCatalogo = tipoCatalogoDireccion,
                IdCatalogo = idCatalogo
            };
        }

        public void Inicializar(int idDireccion)
        {
            CargarDireccion(idDireccion);
        }

        public async Task GuardarUsandoFuncionesAltoNivelAsync()
        {
            if (Direccion.Id == 0)
            {
                var idDireccion = _direccionService.Crear(Direccion.ToTDireccion());
                CargarDireccion(idDireccion);
                await _dialogCoordinator.ShowMessageAsync(this, "Direccion Creada", "Direccion creada exitosamente.");
            }
            else
            {
                _direccionService.Actualizar(Direccion.ToTDireccion());
                CargarDireccion(Direccion.Id);
                await _dialogCoordinator.ShowMessageAsync(this, "Direccion Guardad", "Direccion guardada exitosamente.");
            }
        }

        public async Task GuardarUsandoFuncionesBajoNivelAsync()
        {
            var datosDireccion = Direccion.ToDatosDictionary();

            if (Direccion.Id == 0)
            {
                datosDireccion.Remove("CIDDIRECCION");
                var direccionId = _direccionService.Crear(datosDireccion);

                CargarDireccion(direccionId);
                await _dialogCoordinator.ShowMessageAsync(this, "Direccion Creada", "Direccion creada exitosamente.");
            }
            else
            {
                datosDireccion.Remove("CIDDIRECCION");
                datosDireccion.Remove("CTIPOCATALOGO");
                datosDireccion.Remove("CIDCATALOGO");
                _direccionService.Actualizar(Direccion.Id, datosDireccion);
                CargarDireccion(Direccion.Id);
                await _dialogCoordinator.ShowMessageAsync(this, "Direccion Guardada", "Direccion guardada exitosamente.");
            }
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }

        private void CargarDireccion(int idDireccion)
        {
            Direccion = _direccionRepository.BuscarPorId(idDireccion);
        }
    }
}