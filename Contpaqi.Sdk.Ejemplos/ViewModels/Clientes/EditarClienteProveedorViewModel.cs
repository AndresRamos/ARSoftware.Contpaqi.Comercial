using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Ejemplos.Views.Agentes;
using Contpaqi.Sdk.Ejemplos.Views.Almacenes;
using Contpaqi.Sdk.Ejemplos.Views.Direcciones;
using Contpaqi.Sdk.Ejemplos.Views.ValoresClasificacion;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Clientes
{
    public class EditarClienteProveedorViewModel : ObservableRecipient
    {
        private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
        private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
        private readonly IClienteProveedorService _clienteProveedorService;
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IDireccionRepository<Direccion> _direccionRepository;
        private ClienteProveedor _clienteProveedor;
        private Direccion _direccionSeleccionada;

        public EditarClienteProveedorViewModel(IDialogCoordinator dialogCoordinator, IClienteProveedorService clienteProveedorService, IClasificacionRepository<Clasificacion> clasificacionRepository, IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository, IDireccionRepository<Direccion> direccionRepository)
        {
            _dialogCoordinator = dialogCoordinator;
            _clienteProveedorService = clienteProveedorService;
            _clasificacionRepository = clasificacionRepository;
            _clienteProveedorRepository = clienteProveedorRepository;
            _direccionRepository = direccionRepository;

            GuardarCommand = new AsyncRelayCommand(Guardar);
            CancelarCommand = new RelayCommand(CerrarVista);
            BuscarValorClasificacionCommand = new AsyncRelayCommand<string>(BuscarValorClasificacionAsync);
            CrearDireccionCommand = new AsyncRelayCommand(CrearDireccionAsync);
            EditarDireccionCommand = new AsyncRelayCommand(EditarDireccionAsync, CanEditarDireccionAsync);

            BuscarAlmacenCommand = new AsyncRelayCommand(BuscarAlmacenAsync);
            BuscarAgenteVentaCommand = new AsyncRelayCommand(BuscarAgenteVentaAsync);
            BuscarAgenteCobroCommand = new AsyncRelayCommand(BuscarAgenteCobroAsync);
        }

        public string Title { get; } = "Crear Cliente/Proveedor";

        public ClienteProveedor ClienteProveedor
        {
            get => _clienteProveedor;
            private set => SetProperty(ref _clienteProveedor, value);
        }

        public IEnumerable<Moneda> Monedas { get; } = Moneda.ToList();

        public IEnumerable<TipoClienteEnum> TiposCliente { get; } = Enum.GetValues(typeof(TipoClienteEnum)).Cast<TipoClienteEnum>().ToList();

        public ObservableCollection<Direccion> Direcciones { get; } = new ObservableCollection<Direccion>();

        public IRelayCommand GuardarCommand { get; }
        public IRelayCommand CancelarCommand { get; }
        public IRelayCommand<string> BuscarValorClasificacionCommand { get; }
        public IRelayCommand CrearDireccionCommand { get; }
        public IRelayCommand EditarDireccionCommand { get; }
        public IAsyncRelayCommand BuscarAlmacenCommand { get; }
        public IAsyncRelayCommand BuscarAgenteVentaCommand { get; }
        public IAsyncRelayCommand BuscarAgenteCobroCommand { get; }

        public Direccion DireccionSeleccionada
        {
            get => _direccionSeleccionada;
            set
            {
                SetProperty(ref _direccionSeleccionada, value);
                RaiseGuards();
            }
        }

        public async Task Guardar()
        {
            try
            {
                if (ClienteProveedor.Id == 0)
                {
                    var clienteProveedor = ClienteProveedor.ToTCteProv();
                    var nuevoClienteProveedorId = _clienteProveedorService.Crear(clienteProveedor);

                    ClienteProveedor = _clienteProveedorRepository.BuscarPorId(nuevoClienteProveedorId);

                    await _dialogCoordinator.ShowMessageAsync(this, "Cliente/Proveedor Creado", "Cliente/Proveedor creado exitosamente.");
                }
                else
                {
                    _clienteProveedorService.Actualizar(ClienteProveedor.ToTCteProv());

                    var datos = new Dictionary<string, string>();
                    datos.Add("CMETODOPAG", ClienteProveedor.FormaPago);
                    datos.Add("CNUMCTAPAG", ClienteProveedor.NumeroCuentaPago);
                    datos.Add("CUSOCFDI", ClienteProveedor.UsoCfdi);
                    datos.Add("CEMAIL1", ClienteProveedor.Email1);
                    datos.Add("CEMAIL2", ClienteProveedor.Email2);
                    datos.Add("CEMAIL3", ClienteProveedor.Email3);
                    datos.Add("CCOMVENTA", ClienteProveedor.ComisionVenta.ToString(CultureInfo.InvariantCulture));
                    datos.Add("CCOMCOBRO", ClienteProveedor.ComisionCobro.ToString(CultureInfo.InvariantCulture));
                    _clienteProveedorService.Actualizar(ClienteProveedor.Id, datos);

                    ClienteProveedor = _clienteProveedorRepository.BuscarPorId(ClienteProveedor.Id);

                    await _dialogCoordinator.ShowMessageAsync(this, "Cliente/Proveedor Guardado", "Cliente/Proveedor guardado exitosamente.");
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public void Inicializar()
        {
            ClienteProveedor = new ClienteProveedor();
            Direcciones.Clear();
            OnPropertyChanged();
        }

        public void Inicializar(int idCliente)
        {
            ClienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente);
            CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.Id);

            OnPropertyChanged();
        }

        public async Task BuscarValorClasificacionAsync(string propertyName)
        {
            try
            {
                var window = new SeleccionarValorClasificacionView();

                switch (propertyName)
                {
                    case nameof(ClienteProveedor.ValorClasificacionCliente1):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 1).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente1 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionCliente2):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 2).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente2 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionCliente3):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 3).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente3 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionCliente4):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 4).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente4 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionCliente5):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 5).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente5 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionCliente6):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Cliente, 6).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionCliente6 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor1):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 1).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor1 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor2):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 2).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor2 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor3):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 3).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor3 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor4):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 4).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor4 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor5):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 5).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor5 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                    case nameof(ClienteProveedor.ValorClasificacionProveedor6):
                        window.ViewModel.Inicializar(_clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacionEnum.Proveedor, 6).Valores);
                        window.ShowDialog();
                        if (window.ViewModel.SeleccionoValor)
                        {
                            ClienteProveedor.ValorClasificacionProveedor6 = window.ViewModel.ValorSeleccionado;
                        }

                        break;
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                OnPropertyChanged(string.Empty);
            }
        }

        private void CargarDirecciones(TipoClienteEnum tipoCliente, int id)
        {
            var tipo = tipoCliente == TipoClienteEnum.Cliente ? TipoCatalogoDireccion.Clientes
                : tipoCliente == TipoClienteEnum.Proveedor ? TipoCatalogoDireccion.Proveedores
                : TipoCatalogoDireccion.Clientes;

            Direcciones.Clear();
            foreach (var direccion in _direccionRepository.TraerPorTipoYIdCatalogo(tipo, id))
            {
                Direcciones.Add(direccion);
            }
        }

        public async Task CrearDireccionAsync()
        {
            try
            {
                var window = new EditarDireccionView();
                window.ViewModel.Inicializar(BuscarTipoDireccion(ClienteProveedor.Tipo), ClienteProveedor.Codigo, ClienteProveedor.Id);
                window.ShowDialog();
                CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.Id);
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public async Task EditarDireccionAsync()
        {
            try
            {
                var window = new EditarDireccionView();
                window.ViewModel.Inicializar(DireccionSeleccionada.Id);
                window.ShowDialog();
                CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.Id);
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public bool CanEditarDireccionAsync()
        {
            return DireccionSeleccionada != null;
        }

        public TipoCatalogoDireccion BuscarTipoDireccion(TipoClienteEnum tipoCliente)
        {
            return tipoCliente == TipoClienteEnum.Cliente ? TipoCatalogoDireccion.Clientes
                : tipoCliente == TipoClienteEnum.Proveedor ? TipoCatalogoDireccion.Proveedores
                : TipoCatalogoDireccion.Clientes;
        }

        public async Task BuscarAlmacenAsync()
        {
            try
            {
                var window = new SeleccionarAlmacenView();
                window.ViewModel.Inicializar();
                window.ShowDialog();
                if (window.ViewModel.SeleccionoAlmacen)
                {
                    ClienteProveedor.IdAlmacen = window.ViewModel.AlmacenSeleccionado.Id;
                    ClienteProveedor.Almacen = window.ViewModel.AlmacenSeleccionado;
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                OnPropertyChanged(string.Empty);
            }
        }

        public async Task BuscarAgenteVentaAsync()
        {
            try
            {
                var window = new SeleccionarAgenteView();
                window.ViewModel.Inicializar();
                window.ShowDialog();
                if (window.ViewModel.SeleccionoAgente)
                {
                    ClienteProveedor.IdAgenteVenta = window.ViewModel.AgenteSeleccionado.Id;
                    ClienteProveedor.AgenteVenta = window.ViewModel.AgenteSeleccionado;
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                OnPropertyChanged(string.Empty);
            }
        }

        public async Task BuscarAgenteCobroAsync()
        {
            try
            {
                var window = new SeleccionarAgenteView();
                window.ViewModel.Inicializar();
                window.ShowDialog();
                if (window.ViewModel.SeleccionoAgente)
                {
                    ClienteProveedor.IdAgenteCobro = window.ViewModel.AgenteSeleccionado.Id;
                    ClienteProveedor.AgenteCobro = window.ViewModel.AgenteSeleccionado;
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
            finally
            {
                OnPropertyChanged(string.Empty);
            }
        }

        private void RaiseGuards()
        {
            EditarDireccionCommand.NotifyCanExecuteChanged();
        }

        private void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }
    }
}