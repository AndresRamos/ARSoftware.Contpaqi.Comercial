using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

namespace Sdk.Extras.WpfApp.ViewModels.UnidadesMedida;

public class EditarUnidadMedidaViewModel : ObservableRecipient
{
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IUnidadMedidaRepository<UnidadMedida> _unidadMedidaRepository;
    private readonly IUnidadMedidaService _unidadMedidaService;

    public EditarUnidadMedidaViewModel(IUnidadMedidaRepository<UnidadMedida> unidadMedidaRepository,
        IUnidadMedidaService unidadMedidaService, IDialogCoordinator dialogCoordinator)
    {
        _unidadMedidaRepository = unidadMedidaRepository;
        _unidadMedidaService = unidadMedidaService;
        _dialogCoordinator = dialogCoordinator;

        GuardarCommand = new AsyncRelayCommand(GuardarAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public IRelayCommand CancelarCommand { get; }

    public IAsyncRelayCommand GuardarCommand { get; }

    public string Title => "Editar Unidad De Medida";

    public UnidadMedida UnidadMedida { get; private set; } = new();

    private void CargarUnidadMedida(int idUnidadMedida)
    {
        UnidadMedida = _unidadMedidaRepository.BuscarPorId(idUnidadMedida);
    }

    private void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task GuardarAsync()
    {
        try
        {
            if (UnidadMedida.CIDUNIDAD == 0)
            {
                tUnidad unidad = UnidadMedida.ToTUnidad();
                int nuevaUnidadId = _unidadMedidaService.Crear(unidad);
                UnidadMedida = _unidadMedidaRepository.BuscarPorId(nuevaUnidadId);
                await _dialogCoordinator.ShowMessageAsync(this, "Unidad De Medida Creada", "Unida De Medida creada exitosamente.");
            }
            else
            {
                Dictionary<string, string> datosUnidadMedida = UnidadMedida.ToDatosDictionary<admUnidadesMedidaPeso>();
                datosUnidadMedida.Remove("CIDUNIDAD");
                _unidadMedidaService.Actualizar(UnidadMedida.CIDUNIDAD, datosUnidadMedida);
                UnidadMedida = _unidadMedidaRepository.BuscarPorId(UnidadMedida.CIDUNIDAD);
                await _dialogCoordinator.ShowMessageAsync(this, "Unidad De Medida Guardada", "Unida De Medida guardada exitosamente.");
            }
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar()
    {
        UnidadMedida = new UnidadMedida();
    }

    public void Inicializar(int idUnidadMedida)
    {
        CargarUnidadMedida(idUnidadMedida);
    }
}
