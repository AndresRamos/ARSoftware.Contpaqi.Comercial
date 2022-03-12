using System;
using System.Threading.Tasks;
using Contpaqi.Sdk.DatosAbstractos;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion;

public class CrearValorClasificacionViewModel : ObservableRecipient
{
    private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
    private readonly IDialogCoordinator _dialogCoordinator;
    private readonly IValorClasificacionService _valorClasificacionService;
    private int _clasificacionId;
    private string _clasificacionNombre;
    private int _clasificacionNumero;
    private string _codigo;
    private string _valor;

    public CrearValorClasificacionViewModel(IValorClasificacionService valorClasificacionService,
                                            IClasificacionRepository<Clasificacion> clasificacionRepository,
                                            IDialogCoordinator dialogCoordinator)
    {
        _valorClasificacionService = valorClasificacionService;
        _clasificacionRepository = clasificacionRepository;
        _dialogCoordinator = dialogCoordinator;

        CrearCommand = new AsyncRelayCommand(CrearAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public string Title { get; } = "Crear Valor De Clasificacion";

    public int ClasificacionId
    {
        get => _clasificacionId;
        private set => SetProperty(ref _clasificacionId, value);
    }

    public int ClasificacionNumero
    {
        get => _clasificacionNumero;
        private set => SetProperty(ref _clasificacionNumero, value);
    }

    public string ClasificacionNombre
    {
        get => _clasificacionNombre;
        private set => SetProperty(ref _clasificacionNombre, value);
    }

    public string Codigo
    {
        get => _codigo;
        set => SetProperty(ref _codigo, value);
    }

    public string Valor
    {
        get => _valor;
        set => SetProperty(ref _valor, value);
    }

    public IAsyncRelayCommand CrearCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public async Task CrearAsync()
    {
        try
        {
            var valorClasificacion = new tValorClasificacion
            {
                cNumClasificacion = ClasificacionId + 1, cCodigoValorClasificacion = Codigo, cValorClasificacion = Valor
            }; // Al parece se necesita agregar +1 al id para que cree el valor en la clasificacion correcta.
            _valorClasificacionService.Crear(valorClasificacion);
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar(int clasificacionId)
    {
        Clasificacion clasificacion = _clasificacionRepository.BuscarPorId(clasificacionId);
        ClasificacionId = clasificacion.CIDCLASIFICACION;
        ClasificacionNumero = ClasificacionHelper.BuscarNumeroPorId(clasificacionId);
        ClasificacionNombre = clasificacion.CNOMBRECLASIFICACION;
    }
}
