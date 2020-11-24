using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Data;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Modelos;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.Clientes
{
    public class ListadoClientesViewModel : ObservableRecipient
    {
        private readonly IClienteProveedorRepositorio _clienteProveedorRepositorio;
        private readonly IDialogCoordinator _dialogCoordinator;
        private ClienteProveedor _clienteSeleccionado;
        private string _filtro;

        public ListadoClientesViewModel(IClienteProveedorRepositorio clienteProveedorRepositorio, IDialogCoordinator dialogCoordinator)
        {
            _clienteProveedorRepositorio = clienteProveedorRepositorio;
            _dialogCoordinator = dialogCoordinator;
            Clientes = new ObservableCollection<ClienteProveedor>();
            ClientesView = CollectionViewSource.GetDefaultView(Clientes);
            ClientesView.Filter = ClientesView_Filter;

            BuscarClientesCommand = new AsyncRelayCommand(BuscarClientesAsync);
        }

        public string Title => "Clientes";

        public string Filtro
        {
            get => _filtro;
            set
            {
                SetProperty(ref _filtro, value);
                ClientesView.Refresh();
            }
        }

        public ObservableCollection<ClienteProveedor> Clientes { get; }

        public ICollectionView ClientesView { get; }

        public ClienteProveedor ClienteSeleccionado
        {
            get => _clienteSeleccionado;
            set => SetProperty(ref _clienteSeleccionado, value);
        }

        public IAsyncRelayCommand BuscarClientesCommand { get; }

        public async Task BuscarClientesAsync()
        {
            try
            {
                Clientes.Clear();
                foreach (var cliente in _clienteProveedorRepositorio.TraerClientes(true))
                {
                    Clientes.Add(cliente);
                }
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        private bool ClientesView_Filter(object obj)
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