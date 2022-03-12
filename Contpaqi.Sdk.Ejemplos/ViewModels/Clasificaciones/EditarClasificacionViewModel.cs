using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Ejemplos.Messages;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Extensions;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Contpaqi.Comercial.Sql.Models.Empresa;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Clasificaciones;

public class EditarClasificacionViewModel : ObservableRecipient
{
    private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
    private readonly IClasificacionService _clasificacionService;
    private readonly IDialogCoordinator _dialogCoordinator;
    private Clasificacion _clasificacion;

    public EditarClasificacionViewModel(IClasificacionRepository<Clasificacion> clasificacionRepository,
                                        IClasificacionService clasificacionService,
                                        IDialogCoordinator dialogCoordinator)
    {
        _clasificacionRepository = clasificacionRepository;
        _clasificacionService = clasificacionService;
        _dialogCoordinator = dialogCoordinator;

        GuardarCommand = new AsyncRelayCommand(GudardarAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public string Title => "Editar Clasificacion";

    public Clasificacion Clasificacion
    {
        get => _clasificacion;
        private set => SetProperty(ref _clasificacion, value);
    }

    public IAsyncRelayCommand GuardarCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    private void CargarClasificacion(int idClasificacion)
    {
        Clasificacion = _clasificacionRepository.BuscarPorId(idClasificacion);
    }

    private void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task GudardarAsync()
    {
        try
        {
            int idClasificacion = Clasificacion.CIDCLASIFICACION;
            Dictionary<string, string> agenteDatos = Clasificacion.ToDatosDictionary<admClasificaciones>();

            _clasificacionService.Actualizar(idClasificacion, agenteDatos);

            await _dialogCoordinator.ShowMessageAsync(this, "Agente Guardado", "Agente guardado exitosamente.");

            CargarClasificacion(idClasificacion);
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar(int idClasificacion)
    {
        CargarClasificacion(idClasificacion);
    }
}
