using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.Clientes;
using Agente = Sdk.Extras.WpfApp.Models.Agente;
using Almacen = Sdk.Extras.WpfApp.Models.Almacen;
using ClienteProveedor = Sdk.Extras.WpfApp.Models.ClienteProveedor;

namespace Sdk.Extras.WpfApp.ViewModels.Clientes;

public class ListadoClientesViewModel : ObservableRecipient
{
    private readonly IAgenteRepository<Agente> _agenteRepository;
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IMonedaRepository<Moneda> _monedaRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private ClienteProveedor _clienteProveedorSeleccionado;
    private string _duracionBusqueda;
    private string _filtro;

    public ListadoClientesViewModel(IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository,
        IDialogCoordinator dialogCoordinator, IAlmacenRepository<Almacen> almacenRepository, IAgenteRepository<Agente> agenteRepository,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository, IMonedaRepository<Moneda> monedaRepository)
    {
        _clienteProveedorRepository = clienteProveedorRepository;
        _dialogCoordinator = dialogCoordinator;
        _almacenRepository = almacenRepository;
        _agenteRepository = agenteRepository;
        _valorClasificacionRepository = valorClasificacionRepository;
        _monedaRepository = monedaRepository;
        ClientesProveedores = new ObservableCollection<ClienteProveedor>();
        ClientesProveedoresView = CollectionViewSource.GetDefaultView(ClientesProveedores);
        ClientesProveedoresView.Filter = ClientesProveedoresView_Filter;

        BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
        BuscarClientesCommand = new AsyncRelayCommand(BuscarClientesAsync);
        BuscarProveedoresCommand = new AsyncRelayCommand(BuscarProveedoresAsync);
        CrearClienteProveedorCommand = new AsyncRelayCommand(CrearClienteProveedorAsync);
        EditarClienteProveedorCommand = new AsyncRelayCommand(EditarClienteProveedorAsync, CanEditarClienteProveedorAsync);
    }

    public IAsyncRelayCommand BuscarClientesCommand { get; }
    public IAsyncRelayCommand BuscarProveedoresCommand { get; }

    public IAsyncRelayCommand BuscarTodoCommand { get; }

    public ClienteProveedor ClienteProveedorSeleccionado
    {
        get => _clienteProveedorSeleccionado;
        set
        {
            SetProperty(ref _clienteProveedorSeleccionado, value);
            RaiseGuards();
        }
    }

    public ObservableCollection<ClienteProveedor> ClientesProveedores { get; }

    public ICollectionView ClientesProveedoresView { get; }
    public IAsyncRelayCommand CrearClienteProveedorCommand { get; }

    public string DuracionBusqueda
    {
        get => _duracionBusqueda;
        private set => SetProperty(ref _duracionBusqueda, value);
    }

    public IAsyncRelayCommand EditarClienteProveedorCommand { get; }

    public string Filtro
    {
        get => _filtro;
        set
        {
            SetProperty(ref _filtro, value);
            ClientesProveedoresView.Refresh();
            OnPropertyChanged(nameof(NumeroClientesProveedores));
        }
    }

    public int NumeroClientesProveedores => ClientesProveedoresView.Cast<object>().Count();

    public string Title => "Clientes/Proveedores";

    public async Task BuscarClientesAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            ClientesProveedores.Clear();
            foreach (ClienteProveedor cliente in _clienteProveedorRepository.TraerClientes())
            {
                CargarRelaciones(cliente);
                ClientesProveedores.Add(cliente);
                progressDialogController.SetMessage($"Numero de clientes: {ClientesProveedores.Count}");
                await Task.Delay(20);
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
            OnPropertyChanged(nameof(NumeroClientesProveedores));
        }
    }

    public async Task BuscarProveedoresAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);
        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            ClientesProveedores.Clear();
            foreach (ClienteProveedor proveedor in _clienteProveedorRepository.TraerProveedores())
            {
                CargarRelaciones(proveedor);
                ClientesProveedores.Add(proveedor);
                progressDialogController.SetMessage($"Numero de proveedores: {ClientesProveedores.Count}");
                await Task.Delay(20);
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
            OnPropertyChanged(nameof(NumeroClientesProveedores));
        }
    }

    public async Task BuscarTodoAsync()
    {
        ProgressDialogController progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
        await Task.Delay(1000);

        try
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            ClientesProveedores.Clear();

            foreach (ClienteProveedor cliente in _clienteProveedorRepository.TraerTodo())
            {
                CargarRelaciones(cliente);
                ClientesProveedores.Add(cliente);
                progressDialogController.SetMessage($"Numero de clientes: {ClientesProveedores.Count}");
                await Task.Delay(20);
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
            OnPropertyChanged(nameof(NumeroClientesProveedores));
        }
    }

    public bool CanEditarClienteProveedorAsync()
    {
        return ClienteProveedorSeleccionado != null;
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

    private bool ClientesProveedoresView_Filter(object obj)
    {
        if (obj is not ClienteProveedor cliente) throw new ArgumentNullException(nameof(obj));

        return cliente.Contains(Filtro);
    }

    public async Task CrearClienteProveedorAsync()
    {
        try
        {
            var window = new EditarClienteProveedorView();
            window.ViewModel.Inicializar();
            window.ShowDialog();

            await _dialogCoordinator.ShowMessageAsync(this, "Volver A Buscar Catalogo",
                "Para ver los cambios reflejados volver a buscar el catalogo.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public async Task EditarClienteProveedorAsync()
    {
        try
        {
            var window = new EditarClienteProveedorView();
            window.ViewModel.Inicializar(ClienteProveedorSeleccionado.CIDCLIENTEPROVEEDOR);
            window.ShowDialog();

            await _dialogCoordinator.ShowMessageAsync(this, "Volver A Buscar Catalogo",
                "Para ver los cambios reflejados volver a buscar el catalogo.");
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private void RaiseGuards()
    {
        BuscarTodoCommand.NotifyCanExecuteChanged();
        BuscarClientesCommand.NotifyCanExecuteChanged();
        BuscarProveedoresCommand.NotifyCanExecuteChanged();
        CrearClienteProveedorCommand.NotifyCanExecuteChanged();
        EditarClienteProveedorCommand.NotifyCanExecuteChanged();
    }
}
