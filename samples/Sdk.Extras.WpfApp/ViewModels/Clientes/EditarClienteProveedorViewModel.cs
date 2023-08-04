using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models.Enums;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Agentes;
using Sdk.Extras.WpfApp.Views.Almacenes;
using Sdk.Extras.WpfApp.Views.Direcciones;
using Sdk.Extras.WpfApp.Views.ValoresClasificacion;
using Agente = Sdk.Extras.WpfApp.Models.Agente;
using Almacen = Sdk.Extras.WpfApp.Models.Almacen;
using ClienteProveedor = Sdk.Extras.WpfApp.Models.ClienteProveedor;
using Direccion = Sdk.Extras.WpfApp.Models.Direccion;

namespace Sdk.Extras.WpfApp.ViewModels.Clientes;

public class EditarClienteProveedorViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IClienteProveedorService _clienteProveedorService;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IDireccionRepository<Direccion> _direccionRepository;
    private readonly IMonedaRepository<Moneda> _monedaRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private ClienteProveedor _clienteProveedor;
    private Direccion _direccionSeleccionada;

    public EditarClienteProveedorViewModel(IDialogCoordinator dialogCoordinator, IClienteProveedorService clienteProveedorService,
        IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository, IDireccionRepository<Direccion> direccionRepository,
        IAgenteRepository<Agente> agenteRepository, IAlmacenRepository<Almacen> almacenRepository,
        IMonedaRepository<Moneda> monedaRepository, IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _dialogCoordinator = dialogCoordinator;
        _clienteProveedorService = clienteProveedorService;
        _clienteProveedorRepository = clienteProveedorRepository;
        _direccionRepository = direccionRepository;
        _agenteRepository = agenteRepository;
        _almacenRepository = almacenRepository;
        _monedaRepository = monedaRepository;
        _valorClasificacionRepository = valorClasificacionRepository;

        GuardarCommand = new AsyncRelayCommand(Guardar);
        CancelarCommand = new RelayCommand(CerrarVista);
        BuscarValorClasificacionCommand = new AsyncRelayCommand<string>(BuscarValorClasificacionAsync);
        CrearDireccionCommand = new AsyncRelayCommand(CrearDireccionAsync);
        EditarDireccionCommand = new AsyncRelayCommand(EditarDireccionAsync, CanEditarDireccionAsync);

        BuscarAlmacenCommand = new AsyncRelayCommand(BuscarAlmacenAsync);
        BuscarAgenteVentaCommand = new AsyncRelayCommand(BuscarAgenteVentaAsync);
        BuscarAgenteCobroCommand = new AsyncRelayCommand(BuscarAgenteCobroAsync);
    }

    public IAsyncRelayCommand BuscarAgenteCobroCommand { get; }
    public IAsyncRelayCommand BuscarAgenteVentaCommand { get; }
    public IAsyncRelayCommand BuscarAlmacenCommand { get; }
    public IRelayCommand<string> BuscarValorClasificacionCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public ClienteProveedor ClienteProveedor
    {
        get => _clienteProveedor;
        private set => SetProperty(ref _clienteProveedor, value);
    }

    public IRelayCommand CrearDireccionCommand { get; }

    public ObservableCollection<Direccion> Direcciones { get; } = new();

    public Direccion DireccionSeleccionada
    {
        get => _direccionSeleccionada;
        set
        {
            SetProperty(ref _direccionSeleccionada, value);
            RaiseGuards();
        }
    }

    public IRelayCommand EditarDireccionCommand { get; }

    public IRelayCommand GuardarCommand { get; }

    public IEnumerable<Moneda> Monedas { get; } = MonedaEnum.List.Select(m => m.ToMoneda()).ToList();

    public IEnumerable<TipoCliente> TiposCliente { get; } = Enum.GetValues(typeof(TipoCliente)).Cast<TipoCliente>().ToList();

    public string Title { get; } = "Crear Cliente/Proveedor";

    private async Task BuscarAgenteCobroAsync()
    {
        try
        {
            var window = new SeleccionarAgenteView();
            window.ViewModel.Inicializar();
            window.ShowDialog();
            if (window.ViewModel.SeleccionoAgente)
            {
                ClienteProveedor.CIDAGENTECOBRO = window.ViewModel.AgenteSeleccionado.CIDAGENTE;
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

    private async Task BuscarAgenteVentaAsync()
    {
        try
        {
            var window = new SeleccionarAgenteView();
            window.ViewModel.Inicializar();
            window.ShowDialog();
            if (window.ViewModel.SeleccionoAgente)
            {
                ClienteProveedor.CIDAGENTEVENTA = window.ViewModel.AgenteSeleccionado.CIDAGENTE;
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

    private async Task BuscarAlmacenAsync()
    {
        try
        {
            var window = new SeleccionarAlmacenView();
            window.ViewModel.Inicializar();
            window.ShowDialog();
            if (window.ViewModel.SeleccionoAlmacen)
            {
                ClienteProveedor.CIDALMACEN = window.ViewModel.AlmacenSeleccionado.CIDALMACEN;
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

    private TipoCatalogoDireccion BuscarTipoDireccion(TipoCliente tipoCliente)
    {
        return tipoCliente == TipoCliente.Cliente ? TipoCatalogoDireccion.Clientes :
            tipoCliente == TipoCliente.Proveedor ? TipoCatalogoDireccion.Proveedores : TipoCatalogoDireccion.Clientes;
    }

    private async Task BuscarValorClasificacionAsync(string propertyName)
    {
        try
        {
            var window = new SeleccionarValorClasificacionView();

            switch (propertyName)
            {
                case nameof(ClienteProveedor.ValorClasificacionCliente1):

                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente, NumeroClasificacion.Uno));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente1 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionCliente2):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente, NumeroClasificacion.Dos));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente2 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionCliente3):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente,
                            NumeroClasificacion.Tres));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente3 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionCliente4):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente,
                            NumeroClasificacion.Cuatro));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente4 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionCliente5):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente,
                            NumeroClasificacion.Cinco));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente5 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionCliente6):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Cliente,
                            NumeroClasificacion.Seis));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) ClienteProveedor.ValorClasificacionCliente6 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor1):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Uno));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor1 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor2):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Dos));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor2 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor3):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Tres));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor3 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor4):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Cuatro));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor4 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor5):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Cinco));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor5 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(ClienteProveedor.ValorClasificacionProveedor6):
                    window.ViewModel.Inicializar(
                        _valorClasificacionRepository.TraerPorClasificacionTipoYNumero(TipoClasificacion.Proveedor,
                            NumeroClasificacion.Seis));
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor)
                        ClienteProveedor.ValorClasificacionProveedor6 = window.ViewModel.ValorSeleccionado;

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

    private bool CanEditarDireccionAsync()
    {
        return DireccionSeleccionada != null;
    }

    private void CargarCliente(int idCliente)
    {
        ClienteProveedor = _clienteProveedorRepository.BuscarPorId(idCliente) ?? throw new ArgumentException("No se encontro el cliente.");
        CargarRelaciones(ClienteProveedor);
        CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.CIDCLIENTEPROVEEDOR);
    }

    private void CargarDirecciones(TipoCliente tipoCliente, int id)
    {
        TipoCatalogoDireccion tipo = tipoCliente == TipoCliente.Cliente ? TipoCatalogoDireccion.Clientes :
            tipoCliente == TipoCliente.Proveedor ? TipoCatalogoDireccion.Proveedores : TipoCatalogoDireccion.Clientes;

        Direcciones.Clear();
        foreach (Direccion direccion in _direccionRepository.TraerPorTipoYIdCatalogo(tipo, id)) Direcciones.Add(direccion);
    }

    private void CargarRelaciones(ClienteProveedor clienteProveedor)
    {
        clienteProveedor.Moneda = _monedaRepository.BuscarPorId(clienteProveedor.CIDMONEDA);
        clienteProveedor.Almacen = _almacenRepository.BuscarPorId(clienteProveedor.CIDALMACEN);
        clienteProveedor.AgenteVenta = _agenteRepository.BuscarPorId(clienteProveedor.CIDAGENTEVENTA);
        clienteProveedor.AgenteCobro = _agenteRepository.BuscarPorId(clienteProveedor.CIDAGENTECOBRO);
        clienteProveedor.ValorClasificacionCliente1 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE1);
        clienteProveedor.ValorClasificacionCliente2 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE2);
        clienteProveedor.ValorClasificacionCliente3 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE3);
        clienteProveedor.ValorClasificacionCliente4 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE4);
        clienteProveedor.ValorClasificacionCliente5 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE5);
        clienteProveedor.ValorClasificacionCliente6 = _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFCLIENTE6);
        clienteProveedor.ValorClasificacionProveedor1 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR1);
        clienteProveedor.ValorClasificacionProveedor2 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR2);
        clienteProveedor.ValorClasificacionProveedor3 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR3);
        clienteProveedor.ValorClasificacionProveedor4 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR4);
        clienteProveedor.ValorClasificacionProveedor5 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR5);
        clienteProveedor.ValorClasificacionProveedor6 =
            _valorClasificacionRepository.BuscarPorId(clienteProveedor.CIDVALORCLASIFPROVEEDOR6);
    }

    private void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task CrearDireccionAsync()
    {
        try
        {
            var window = new EditarDireccionView();
            window.ViewModel.Inicializar(BuscarTipoDireccion(ClienteProveedor.Tipo), ClienteProveedor.CCODIGOCLIENTE,
                ClienteProveedor.CIDCLIENTEPROVEEDOR);
            window.ShowDialog();
            CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.CIDCLIENTEPROVEEDOR);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task EditarDireccionAsync()
    {
        try
        {
            var window = new EditarDireccionView();
            window.ViewModel.Inicializar(DireccionSeleccionada.CIDDIRECCION, ClienteProveedor.CCODIGOCLIENTE);
            window.ShowDialog();
            CargarDirecciones(ClienteProveedor.Tipo, ClienteProveedor.CIDCLIENTEPROVEEDOR);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private async Task Guardar()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Usar funciones de Alto Nivel o de Bajo Nivel?", "Usar funciones de Alto Nivel o de Bajo Nivel?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Alto Nivel", NegativeButtonText = "Bajo Nivel" });

            int idCliente = messageDialogResult == MessageDialogResult.Affirmative ? GuardarUsandoAltoNivel() : GuardarUsandoBajoNivel();

            await _dialogCoordinator.ShowMessageAsync(this, "Cliente/Proveedor Guardado", "Cliente/Proveedor guardado exitosamente.");

            CargarCliente(idCliente);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
        finally
        {
            RaiseGuards();
        }
    }

    private int GuardarUsandoAltoNivel()
    {
        int idCliente = ClienteProveedor.CIDCLIENTEPROVEEDOR;
        tCteProv tCliente = ClienteProveedor.ToTCteProv();

        if (idCliente == 0)
            idCliente = _clienteProveedorService.Crear(tCliente);
        else
        {
            _clienteProveedorService.Actualizar(tCliente);

            var datosCliente = new Dictionary<string, string>
            {
                { "CMETODOPAG", ClienteProveedor.CMETODOPAG },
                { "CREGIMFISC", ClienteProveedor.CREGIMFISC },
                { "CUSOCFDI", ClienteProveedor.CUSOCFDI }
            };

            _clienteProveedorService.Actualizar(idCliente, datosCliente);
        }

        return idCliente;
    }

    private int GuardarUsandoBajoNivel()
    {
        int idCliente = ClienteProveedor.CIDCLIENTEPROVEEDOR;
        Dictionary<string, string> datosCliente = ClienteProveedor.ToDatosDictionary<admClientes>();

        if (idCliente == 0)
            idCliente = _clienteProveedorService.Crear(datosCliente);
        else
            _clienteProveedorService.Actualizar(idCliente, datosCliente);

        return idCliente;
    }

    public void Inicializar(int? idCliente = null)
    {
        if (idCliente is null)
        {
            ClienteProveedor = new ClienteProveedor();
            Direcciones.Clear();
        }
        else
            CargarCliente(idCliente.Value);

        OnPropertyChanged();
    }

    private void RaiseGuards()
    {
        EditarDireccionCommand.NotifyCanExecuteChanged();
    }
}
