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

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Clientes
{
    public class ListadoClientesViewModel : ObservableRecipient
    {
        private readonly IClienteProveedorRepository<ClienteProveedor> _clienteProveedorRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private ClienteProveedor _clienteProveedorSeleccionado;
        private string _duracionBusqueda;
        private string _filtro;

        public ListadoClientesViewModel(IClienteProveedorRepository<ClienteProveedor> clienteProveedorRepository, IDialogCoordinator dialogCoordinator)
        {
            _clienteProveedorRepository = clienteProveedorRepository;
            _dialogCoordinator = dialogCoordinator;
            ClientesProveedores = new ObservableCollection<ClienteProveedor>();
            ClientesProveedoresView = CollectionViewSource.GetDefaultView(ClientesProveedores);
            ClientesProveedoresView.Filter = ClientesProveedoresView_Filter;

            BuscarTodoCommand = new AsyncRelayCommand(BuscarTodoAsync);
            BuscarClientesCommand = new AsyncRelayCommand(BuscarClientesAsync);
            BuscarProveedoresCommand = new AsyncRelayCommand(BuscarProveedoresAsync);
        }

        public string Title => "Clientes/Proveedores";

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

        public ObservableCollection<ClienteProveedor> ClientesProveedores { get; }

        public ICollectionView ClientesProveedoresView { get; }

        public ClienteProveedor ClienteProveedorSeleccionado
        {
            get => _clienteProveedorSeleccionado;
            set => SetProperty(ref _clienteProveedorSeleccionado, value);
        }

        public int NumeroClientesProveedores => ClientesProveedoresView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarTodoCommand { get; }
        public IAsyncRelayCommand BuscarClientesCommand { get; }
        public IAsyncRelayCommand BuscarProveedoresCommand { get; }

        public async Task BuscarTodoAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                ClientesProveedores.Clear();
                foreach (var cliente in _clienteProveedorRepository.TraerTodo())
                {
                    ClientesProveedores.Add(cliente);
                    progressDialogController.SetMessage($"Numero de clientes: {ClientesProveedores.Count}");
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
                OnPropertyChanged(nameof(NumeroClientesProveedores));
            }
        }

        public async Task BuscarClientesAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                ClientesProveedores.Clear();
                foreach (var cliente in _clienteProveedorRepository.TraerClientes())
                {
                    ClientesProveedores.Add(cliente);
                    progressDialogController.SetMessage($"Numero de clientes: {ClientesProveedores.Count}");
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
                OnPropertyChanged(nameof(NumeroClientesProveedores));
            }
        }

        public async Task BuscarProveedoresAsync()
        {
            var progressDialogController = await _dialogCoordinator.ShowProgressAsync(this, "Buscando", "Buscando");
            await Task.Delay(1000);
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                ClientesProveedores.Clear();
                foreach (var proveedor in _clienteProveedorRepository.TraerProveedores())
                {
                    ClientesProveedores.Add(proveedor);
                    progressDialogController.SetMessage($"Numero de proveedores: {ClientesProveedores.Count}");
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
                OnPropertyChanged(nameof(NumeroClientesProveedores));
            }
        }

        private bool ClientesProveedoresView_Filter(object obj)
        {
            var cliente = obj as ClienteProveedor;
            if (cliente is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   cliente.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   cliente.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   cliente.RazonSocial.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   cliente.NombreLargo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}