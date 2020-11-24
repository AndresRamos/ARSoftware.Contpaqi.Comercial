using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Clientes
{
    public class ListadoProveedoresViewModel : ObservableRecipient
    {
        private readonly IClienteProveedorRepositorio _clienteProveedorRepositorio;
        private readonly IDialogCoordinator _dialogCoordinator;
        private ClienteProveedor _proveedorSeleccionado;
        private string _duracionBusqueda;
        private string _filtro;
        private bool _buscarObjectosRelacionados = true;

        public ListadoProveedoresViewModel(IClienteProveedorRepositorio clienteProveedorRepositorio, IDialogCoordinator dialogCoordinator)
        {
            _clienteProveedorRepositorio = clienteProveedorRepositorio;
            _dialogCoordinator = dialogCoordinator;
            Proveedores = new ObservableCollection<ClienteProveedor>();
            ProveedoresView = CollectionViewSource.GetDefaultView(Proveedores);
            ProveedoresView.Filter = ClientesView_Filter;

            BuscarProveedoresCommand = new AsyncRelayCommand(BuscarProveedoresAsync);
        }

        public string Title => "Proveedores";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ProveedoresView.Refresh();
            }
        }

        public ObservableCollection<ClienteProveedor> Proveedores { get; }

        public ICollectionView ProveedoresView { get; }

        public ClienteProveedor ProveedorSeleccionado
        {
            get => _proveedorSeleccionado;
            set => SetProperty(ref _proveedorSeleccionado, value);
        }

        public bool BuscarObjectosRelacionados
        {
            get => _buscarObjectosRelacionados;
            set => SetProperty(ref _buscarObjectosRelacionados , value);
        }

        public int NumeroProveedores => ProveedoresView.Cast<object>().Count();

        public string DuracionBusqueda
        {
            get => _duracionBusqueda;
            private set => SetProperty(ref _duracionBusqueda, value);
        }

        public IAsyncRelayCommand BuscarProveedoresCommand { get; }

        public async Task BuscarProveedoresAsync()
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                Proveedores.Clear();
                foreach (var proveedor in _clienteProveedorRepositorio.TraerProveedores(BuscarObjectosRelacionados))
                {
                    Proveedores.Add(proveedor);
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
                OnPropertyChanged(nameof(NumeroProveedores));
            }
        }

        private bool ClientesView_Filter(object obj)
        {
            var proveedor = obj as ClienteProveedor;
            if (proveedor is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return string.IsNullOrWhiteSpace(Filtro) ||
                   proveedor.Id.ToString().IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   proveedor.Codigo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   proveedor.RazonSocial.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   proveedor.NombreLargo.IndexOf(Filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}