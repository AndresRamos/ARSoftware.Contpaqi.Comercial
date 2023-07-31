using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.Movimientos;

public class EditarMovimientoViewModel : ObservableRecipient
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IMovimientoRepository<Movimiento> _movimientoRepository;
    private readonly IMovimientoService _movimientoService;
    private readonly IProductoRepository<Producto> _productoRepository;
    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private Movimiento _movimiento;

    public EditarMovimientoViewModel(IMovimientoRepository<Movimiento> movimientoRepository, IMovimientoService movimientoService,
        IDialogCoordinator dialogCoordinator, IAlmacenRepository<Almacen> almacenRepository,
        IProductoRepository<Producto> productoRepository, IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _movimientoRepository = movimientoRepository;
        _movimientoService = movimientoService;
        _dialogCoordinator = dialogCoordinator;
        _almacenRepository = almacenRepository;
        _productoRepository = productoRepository;
        _valorClasificacionRepository = valorClasificacionRepository;

        GuardarMovimientoCommand = new AsyncRelayCommand(ActualizarMovimientoAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public IRelayCommand CancelarCommand { get; }

    public int DocumentoId { get; private set; }

    public IAsyncRelayCommand GuardarMovimientoCommand { get; }

    public Movimiento Movimiento
    {
        get => _movimiento;
        private set => SetProperty(ref _movimiento, value);
    }

    public string Title { get; } = "Editar Movimiento";

    private async Task ActualizarMovimientoAsync()
    {
        try
        {
            int idMovimiento = Movimiento.CIDMOVIMIENTO;
            Dictionary<string, string> datosMovimiento = Movimiento.ToDatosDictionary<admMovimientos>();
            _movimientoService.Actualizar(idMovimiento, datosMovimiento);
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    private void CargarRelaciones(Movimiento movimiento)
    {
        _movimiento.Almacen = _almacenRepository.BuscarPorId(movimiento.CIDALMACEN);
        _movimiento.Producto = _productoRepository.BuscarPorId(movimiento.CIDPRODUCTO);
        _movimiento.ValorClasificacion = _valorClasificacionRepository.BuscarPorId(movimiento.CIDVALORCLASIFICACION);
    }

    private void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public void Inicializar(int documentoId, int movimientoId)
    {
        DocumentoId = documentoId;
        Movimiento = _movimientoRepository.BuscarPorId(movimientoId);
        CargarRelaciones(Movimiento);
    }
}
