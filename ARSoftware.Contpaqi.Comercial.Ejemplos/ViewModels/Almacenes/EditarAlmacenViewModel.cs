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

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.ViewModels.Almacenes;

public class EditarAlmacenViewModel : ObservableRecipient
{
    private readonly IAlmacenRepository<Almacen> _almacenRepository;
    private readonly IAlmacenService _almacenService;
    private readonly IDialogCoordinator _dialogCoordinator;
    private Almacen _almacen;

    public EditarAlmacenViewModel(IAlmacenRepository<Almacen> almacenRepository,
                                  IDialogCoordinator dialogCoordinator,
                                  IAlmacenService almacenService)
    {
        _almacenRepository = almacenRepository;
        _dialogCoordinator = dialogCoordinator;
        _almacenService = almacenService;

        GuardarCommand = new AsyncRelayCommand(GuardarAsync);
        CancelarCommand = new RelayCommand(CloseView);
    }

    public string Title => "Editar Almacen";

    public Almacen Almacen
    {
        get => _almacen;
        private set => SetProperty(ref _almacen, value);
    }

    public IAsyncRelayCommand GuardarCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    private void CargarAlmacen(int almacenId)
    {
        Almacen = _almacenRepository.BuscarPorId(almacenId);
    }

    private void CloseView()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    private async Task GuardarAsync()
    {
        try
        {
            int almacenId = Almacen.CIDALMACEN;
            Dictionary<string, string> almacenDatos = Almacen.ToDatosDictionary<admAlmacenes>();

            if (almacenId == 0)
            {
                almacenId = _almacenService.Crear(almacenDatos);
            }
            else
            {
                _almacenService.Actualizar(almacenId, almacenDatos);
            }

            await _dialogCoordinator.ShowMessageAsync(this, "Almacen Guardado", "Almacen guardado exitosamente.");

            CargarAlmacen(almacenId);
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

    public void Inicializar(int? almacenId = null)
    {
        if (almacenId is null)
        {
            Almacen = new Almacen();
        }
        else
        {
            CargarAlmacen(almacenId.Value);
        }
    }

    private void RaiseGuards()
    {
        GuardarCommand.NotifyCanExecuteChanged();
    }
}
