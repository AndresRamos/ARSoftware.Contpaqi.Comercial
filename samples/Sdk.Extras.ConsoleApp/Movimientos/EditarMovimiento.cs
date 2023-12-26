using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Dtos;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Models;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;
using AutoMapper;

namespace Sdk.Extras.ConsoleApp;

public class EditarMovimiento
{
    private readonly IContpaqiSdk _contpaqiSdk;
    private readonly IMapper _mapper;
    private readonly IMovimientoRepository<MovimientoDto> _movimientoRepository;
    private readonly IMovimientoService _movimientoService;

    public EditarMovimiento(IMovimientoService movimientoService, IMovimientoRepository<MovimientoDto> movimientoRepository, IMapper mapper,
        IContpaqiSdk contpaqiSdk)
    {
        _movimientoService = movimientoService;
        _movimientoRepository = movimientoRepository;
        _mapper = mapper;
        _contpaqiSdk = contpaqiSdk;
    }

    public void Editar(int movimientoId)
    {
        MovimientoDto? movimientoDto = _movimientoRepository.BuscarPorId(movimientoId);

        if (movimientoDto is null) throw new Exception($"No se encontró el movimiento con Id {movimientoId}");

        var movimiento = _mapper.Map<Movimiento>(movimientoDto);

        movimiento.Precio = 200; // No se puede editar el precio por sdk
        movimiento.Unidades = 2; // No se pueden editar las unidades por sdk
        movimiento.Referencia = "Referencia modificada";
        movimiento.Observaciones = "Observaciones modificadas";
        movimiento.DatosExtra.Add(nameof(admMovimientos.CTEXTOEXTRA1), "Texto extra modificado");

        _movimientoService.Actualizar(movimiento);
    }

    public void EditarConDatosDiccionario(int movimientoId)
    {
        var datosMovimiento = new Dictionary<string, string>
        {
            { nameof(admMovimientos.CTEXTOEXTRA1), "Texto Extra 1" },
            { nameof(admMovimientos.CTEXTOEXTRA2), "Texto Extra 2" },
            { nameof(admMovimientos.CTEXTOEXTRA3), "Texto Extra 3" },
            { nameof(admMovimientos.CREFERENCIA), "Referencia" },
            { nameof(admMovimientos.COBSERVAMOV), "Observaciones" },
            { nameof(admMovimientos.CUNIDADES), "Observaciones" }
        };

        _movimientoService.Actualizar(movimientoId, datosMovimiento);
    }

    public void Prueba()
    {
        var idMovimiento = 1;
        _contpaqiSdk.fBuscarIdMovimiento(idMovimiento);
        _contpaqiSdk.fEditarMovimiento();
        _contpaqiSdk.fSetDatoMovimiento("CUNIDADES", "2");
        _contpaqiSdk.fGuardaMovimiento();
    }
}
