using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;
using Sdk.Extras.WpfApp.Views.ValoresClasificacion;

namespace Sdk.Extras.WpfApp.ViewModels.Productos;

public class EditarProductoViewModel : ObservableRecipient
{
    private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IProductoService _productoService;
    private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private Producto _producto;

    public EditarProductoViewModel(IProductoRepository<Producto> productoRepository, IProductoService productoService,
        IDialogCoordinator dialogCoordinator, IClasificacionRepository<Clasificacion> clasificacionRepository,
        IUnidadMedidaRepository<UnidadMedida> unidadMedidaRepository,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _productoRepository = productoRepository;
        _productoService = productoService;
        _dialogCoordinator = dialogCoordinator;
        _clasificacionRepository = clasificacionRepository;
        _unidadMedidaRepository = unidadMedidaRepository;
        _valorClasificacionRepository = valorClasificacionRepository;
        GuardarCommand = new AsyncRelayCommand(GuardarAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
        BuscarValorClasificacionCommand = new AsyncRelayCommand<string>(BuscarValorClasificacionAsync);
    }

    public IRelayCommand<string> BuscarValorClasificacionCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public IAsyncRelayCommand GuardarCommand { get; }

    public Producto Producto
    {
        get => _producto;
        set
        {
            SetProperty(ref _producto, value);
            RaiseGuards();
        }
    }

    public IEnumerable<TipoProducto> TiposProducto { get; } = Enum.GetValues<TipoProducto>().ToList();

    public string Title => "Editar Producto";

    private async Task BuscarValorClasificacionAsync(string propertyName)
    {
        try
        {
            var window = new SeleccionarValorClasificacionView();
            switch (propertyName)
            {
                case nameof(Producto.ValorClasificacion1):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Uno)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion1 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(Producto.ValorClasificacion2):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Dos)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion2 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(Producto.ValorClasificacion3):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Tres)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion3 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(Producto.ValorClasificacion4):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Cuatro)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion4 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(Producto.ValorClasificacion5):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Cinco)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion5 = window.ViewModel.ValorSeleccionado;

                    break;
                case nameof(Producto.ValorClasificacion6):
                    window.ViewModel.Inicializar(
                        _clasificacionRepository.BuscarPorTipoYNumero(TipoClasificacion.Producto, NumeroClasificacion.Seis)!.Valores);
                    window.ShowDialog();
                    if (window.ViewModel.SeleccionoValor) Producto.ValorClasificacion6 = window.ViewModel.ValorSeleccionado;

                    break;
            }
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
        finally
        {
            RaiseGuards();
            OnPropertyChanged(string.Empty);
        }
    }

    private void CargarProducto(int productoId)
    {
        Producto = _productoRepository.BuscarPorId(productoId);
        CargarRelaciones(Producto);
    }

    private void CargarRelaciones(Producto producto)
    {
        producto.UnidadBase = _unidadMedidaRepository.BuscarPorId(producto.CIDUNIDADBASE);
        producto.UnidadNoConvertible = _unidadMedidaRepository.BuscarPorId(producto.CIDUNIDADNOCONVERTIBLE);
        producto.ValorClasificacion1 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION1);
        producto.ValorClasificacion2 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION2);
        producto.ValorClasificacion3 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION3);
        producto.ValorClasificacion4 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION4);
        producto.ValorClasificacion5 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION5);
        producto.ValorClasificacion6 = _valorClasificacionRepository.BuscarPorId(producto.CIDVALORCLASIFICACION6);
    }

    private void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task GuardarAsync()
    {
        try
        {
            MessageDialogResult messageDialogResult = await _dialogCoordinator.ShowMessageAsync(this,
                "Usar funciones de Alto Nivel o de Bajo Nivel?", "Usar funciones de Alto Nivel o de Bajo Nivel?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings { AffirmativeButtonText = "Alto Nivel", NegativeButtonText = "Bajo Nivel" });

            int productoId = messageDialogResult == MessageDialogResult.Affirmative ? GuardarUsandoAltoNivel() : GuardarUsandoBajoNivel();

            await _dialogCoordinator.ShowMessageAsync(this, "Producto Guardado", "Producto guardado exitosamente.");

            CargarProducto(productoId);
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
        int idProducto = Producto.CIDPRODUCTO;
        string codigoProducto = Producto.CCODIGOPRODUCTO;
        tProducto tproducto = Producto.ToTProducto();

        if (idProducto == 0)
            idProducto = _productoService.Crear(tproducto);
        else
            _productoService.Actualizar(codigoProducto, tproducto);

        return idProducto;
    }

    private int GuardarUsandoBajoNivel()
    {
        int idProducto = Producto.CIDPRODUCTO;
        Dictionary<string, string> datosProducto = Producto.ToDatosDictionary<admProductos>();

        if (idProducto == 0)
            idProducto = _productoService.Crear(datosProducto);
        else
            _productoService.Actualizar(idProducto, datosProducto);

        return idProducto;
    }

    public void Inicializar(int? productoId = null)
    {
        if (productoId is null)
            Producto = new Producto();
        else
            CargarProducto(productoId.Value);
    }

    private void RaiseGuards()
    {
        GuardarCommand.NotifyCanExecuteChanged();
        CancelarCommand.NotifyCanExecuteChanged();
    }
}
