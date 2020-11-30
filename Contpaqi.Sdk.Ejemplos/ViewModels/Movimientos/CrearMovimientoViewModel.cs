using System;
using System.Collections.ObjectModel;
using System.Linq;
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
    public class CrearMovimientoViewModel : ObservableRecipient
    {
        private readonly IAlmacenRepository<Almacen> _almacenRepository;
        private readonly IDialogCoordinator _dialogCoordinator;
        private readonly IMovimientoService _movimientoService;
        private readonly IProductoRepository<ProductoLookup> _productoRepository;
        private Almacen _almacenSeleccionado;
        private double _costo;
        private int _documentoId;
        private double _precio;
        private ProductoLookup _productoSeleccionado;
        private string _referencia;
        private double _unidades;

        public CrearMovimientoViewModel(IMovimientoService movimientoService, IDialogCoordinator dialogCoordinator, IProductoRepository<ProductoLookup> productoRepository, IAlmacenRepository<Almacen> almacenRepository)
        {
            _movimientoService = movimientoService;
            _dialogCoordinator = dialogCoordinator;
            _productoRepository = productoRepository;
            _almacenRepository = almacenRepository;
            CrearMovimientoCommand = new AsyncRelayCommand(CrearMovimientoAsync);
            CancelarCommand = new RelayCommand(CerrarVista);
        }

        public string Title { get; } = "Crear Movimiento";

        public int DocumentoId
        {
            get => _documentoId;
            set => SetProperty(ref _documentoId, value);
        }

        public ObservableCollection<ProductoLookup> Productos { get; } = new ObservableCollection<ProductoLookup>();

        public ProductoLookup ProductoSeleccionado
        {
            get => _productoSeleccionado;
            set => SetProperty(ref _productoSeleccionado, value);
        }

        public ObservableCollection<Almacen> Almacenes { get; } = new ObservableCollection<Almacen>();

        public Almacen AlmacenSeleccionado
        {
            get => _almacenSeleccionado;
            set => SetProperty(ref _almacenSeleccionado, value);
        }

        public double Unidades
        {
            get => _unidades;
            set => SetProperty(ref _unidades, value);
        }

        public double Precio
        {
            get => _precio;
            set => SetProperty(ref _precio, value);
        }

        public double Costo
        {
            get => _costo;
            set => SetProperty(ref _costo, value);
        }

        public string Referencia
        {
            get => _referencia;
            set => SetProperty(ref _referencia, value);
        }

        public IAsyncRelayCommand CrearMovimientoCommand { get; }
        public IRelayCommand CancelarCommand { get; }

        public void Inicializar(int documentoId)
        {
            DocumentoId = documentoId;
            CargarProductos();
            CargarAlmacenes();
        }

        public async Task CrearMovimientoAsync()
        {
            try
            {
                var movimiento = new tMovimiento
                {
                    aCodProdSer = ProductoSeleccionado.Codigo,
                    aCodAlmacen = AlmacenSeleccionado.Codigo,
                    aUnidades = Unidades,
                    aPrecio = Precio,
                    aReferencia = Referencia
                };

                _movimientoService.Crear(DocumentoId, movimiento);
                CerrarVista();
            }
            catch (Exception e)
            {
                await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
            }
        }

        public void CargarProductos()
        {
            Productos.Clear();
            foreach (var producto in _productoRepository.TraerTodo().OrderBy(p => p.Nombre))
            {
                Productos.Add(producto);
            }

            ProductoSeleccionado = Productos.FirstOrDefault();
        }

        public void CargarAlmacenes()
        {
            Almacenes.Clear();
            foreach (var almacen in _almacenRepository.TraerTodo().OrderBy(a => a.Nombre
            ))
            {
                Almacenes.Add(almacen);
            }

            AlmacenSeleccionado = Almacenes.FirstOrDefault(a => a.Codigo == "1");
        }

        public void CerrarVista()
        {
            Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
        }
    }
}