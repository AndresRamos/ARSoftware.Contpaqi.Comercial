using System;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

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
        IClasificacionRepository<Clasificacion> clasificacionRepository, IDialogCoordinator dialogCoordinator)
    {
        _valorClasificacionService = valorClasificacionService;
        _clasificacionRepository = clasificacionRepository;
        _dialogCoordinator = dialogCoordinator;

        CrearCommand = new AsyncRelayCommand(CrearAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public IRelayCommand CancelarCommand { get; }

    public int ClasificacionId
    {
        get => _clasificacionId;
        private set => SetProperty(ref _clasificacionId, value);
    }

    public string ClasificacionNombre
    {
        get => _clasificacionNombre;
        private set => SetProperty(ref _clasificacionNombre, value);
    }

    public int ClasificacionNumero
    {
        get => _clasificacionNumero;
        private set => SetProperty(ref _clasificacionNumero, value);
    }

    public string Codigo
    {
        get => _codigo;
        set => SetProperty(ref _codigo, value);
    }

    public IAsyncRelayCommand CrearCommand { get; }

    public string Title { get; } = "Crear Valor De Clasificacion";

    public string Valor
    {
        get => _valor;
        set => SetProperty(ref _valor, value);
    }

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
        Clasificacion clasificacion = _clasificacionRepository.BuscarPorId(clasificacionId) ??
                                      throw new ArgumentException("No se encontro la clasificacion.");
        ClasificacionId = clasificacion.CIDCLASIFICACION;
        ClasificacionNumero = ClasificacionHelper.BuscarNumeroPorId(clasificacionId);
        ClasificacionNombre = clasificacion.CNOMBRECLASIFICACION;
    }
}
