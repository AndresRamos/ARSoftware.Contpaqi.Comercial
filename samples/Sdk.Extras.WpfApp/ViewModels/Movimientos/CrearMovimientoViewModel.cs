using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.Movimientos;

public class CrearMovimientoViewModel : ObservableRecipient
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IMovimientoService _movimientoService;
    private readonly IProductoRepository<ProductoLookup> _productoRepository;
    private CrearMovimientoModel _movimiento;

    public CrearMovimientoViewModel(IMovimientoService movimientoService, IDialogCoordinator dialogCoordinator,
        IProductoRepository<ProductoLookup> productoRepository, IAlmacenRepository<Almacen> almacenRepository)
    {
        _movimientoService = movimientoService;
        _dialogCoordinator = dialogCoordinator;
        _productoRepository = productoRepository;
        _almacenRepository = almacenRepository;
        CrearMovimientoCommand = new AsyncRelayCommand(CrearMovimientoAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public ObservableCollection<Almacen> Almacenes { get; } = new();
    public IRelayCommand CancelarCommand { get; }

    public IAsyncRelayCommand CrearMovimientoCommand { get; }

    public CrearMovimientoModel Movimiento
    {
        get => _movimiento;
        private set
        {
            SetProperty(ref _movimiento, value);
            RaiseGuards();
        }
    }

    public ObservableCollection<ProductoLookup> Productos { get; } = new();

    public string Title { get; } = "Crear Movimiento";

    public void CargarAlmacenes()
    {
        Almacenes.Clear();
        foreach (Almacen almacen in _almacenRepository.TraerTodo().OrderBy(a => a.CNOMBREALMACEN)) Almacenes.Add(almacen);

        Movimiento.Almacen = Almacenes.FirstOrDefault(a => a.CNOMBREALMACEN == "1");
    }

    public void CargarProductos()
    {
        Productos.Clear();
        foreach (ProductoLookup producto in _productoRepository.TraerTodo().OrderBy(p => p.CNOMBREPRODUCTO)) Productos.Add(producto);

        Movimiento.Producto = Productos.FirstOrDefault();
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task CrearMovimientoAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Usar funciones de Alto Nivel o de Bajo Nivel?", "Usar funciones de Alto Nivel o de Bajo Nivel?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Alto Nivel", NegativeButtonText = "Bajo Nivel" });

            _ = messageDialogResult == MessageDialogResult.Affirmative ? GuardarUsandoAltoNivel() : GuardarUsandoBajoNivel();

            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private int GuardarUsandoAltoNivel()
    {
        int idDocumento = Movimiento.CIDDOCUMENTO;
        var tmovimiento = new tMovimiento
        {
            aCodProdSer = Movimiento.Producto.CCODIGOPRODUCTO,
            aCodAlmacen = Movimiento.Almacen.CCODIGOALMACEN,
            aUnidades = Movimiento.CUNIDADESCAPTURADAS,
            aPrecio = Movimiento.CPRECIO,
            aReferencia = Movimiento.CREFERENCIA
        };

        int idMovimiento = _movimientoService.Crear(idDocumento, tmovimiento);

        return idMovimiento;
    }

    private int GuardarUsandoBajoNivel()
    {
        // TODO: revisar por que no se guarda correctamente el movimiento si las proiedades no estan en un orden especifico
        // Si se crea el diccionario de esta manera no se guarda el precio
        // De hecho ni usando el orden especifico lo guarda correctamente. se recomienda usar de alto nivel por lo pronto
        //Dictionary<string, string> datosCliente = Movimiento.ToDatosDictionary<admMovimientos>();

        // Si se crea el diccionario en este orden si se guarda el precio del movimiento
        var datosCliente = new Dictionary<string, string>();
        datosCliente.Add(nameof(Movimiento.CIDDOCUMENTO), Movimiento.CIDDOCUMENTO.ToString());
        datosCliente.Add(nameof(Movimiento.CIDPRODUCTO), Movimiento.CIDPRODUCTO.ToString());
        datosCliente.Add(nameof(Movimiento.CIDALMACEN), Movimiento.CIDALMACEN.ToString());
        datosCliente.Add(nameof(Movimiento.CUNIDADESCAPTURADAS), Movimiento.CUNIDADESCAPTURADAS.ToString(CultureInfo.InvariantCulture));
        datosCliente.Add(nameof(Movimiento.CPRECIO), Movimiento.CPRECIO.ToString(CultureInfo.InvariantCulture));
        datosCliente.Add(nameof(Movimiento.CREFERENCIA), Movimiento.CREFERENCIA);

        int idMovimiento = _movimientoService.Crear(datosCliente);

        return idMovimiento;
    }

    public void Inicializar(int idDocumento)
    {
        Movimiento = new CrearMovimientoModel { CIDDOCUMENTO = idDocumento };
        CargarProductos();
        CargarAlmacenes();
    }

    private void RaiseGuards()
    {
    }
}
