using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Repositories;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Helpers;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MahApps.Metro.Controls.Dialogs;
using Sdk.Extras.WpfApp.Messages;
using Sdk.Extras.WpfApp.Models;

namespace Sdk.Extras.WpfApp.ViewModels.ValoresClasificacion;

public class EditarValorClasificacionViewModel : ObservableRecipient
{
    private readonly IClasificacionRepository<Clasificacion> _clasificacionRepository;
    private readonly IDialogCoordinator _dialogCoordinator;

    private readonly IValorClasificacionRepository<ValorClasificacion> _valorClasificacionRepository;
    private readonly IValorClasificacionService _valorClasificacionService;
    private int _clasificacionId;
    private string _clasificacionNombre;
    private int _clasificacionNumero;
    private string _codigo;
    private string _valor;
    private int _valorClasificacionId;

    public EditarValorClasificacionViewModel(IValorClasificacionService valorClasificacionService,
        IClasificacionRepository<Clasificacion> clasificacionRepository, IDialogCoordinator dialogCoordinator,
        IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _valorClasificacionService = valorClasificacionService;
        _clasificacionRepository = clasificacionRepository;
        _dialogCoordinator = dialogCoordinator;
        _valorClasificacionRepository = valorClasificacionRepository;

        GuardarCommand = new AsyncRelayCommand(GuardarAsync);
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

    public IAsyncRelayCommand GuardarCommand { get; }

    public string Title { get; } = "Editar Valor De Clasificacion";

    public string Valor
    {
        get => _valor;
        set => SetProperty(ref _valor, value);
    }

    public int ValorClasificacionId
    {
        get => _valorClasificacionId;
        set => SetProperty(ref _valorClasificacionId, value);
    }

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }

    public async Task GuardarAsync()
    {
        try
        {
            var datos = new Dictionary<string, string>();
            datos.Add("CCODIGOVALORCLASIFICACION", Codigo);
            datos.Add("CVALORCLASIFICACION", Valor);

            _valorClasificacionService.Actualizar(ValorClasificacionId, datos);
            CerrarVista();
        }
        catch (Exception e)
        {
            await _dialogCoordinator.ShowMessageAsync(this, "Error", e.ToString());
        }
    }

    public void Inicializar(int valorClasificacionId)
    {
        ValorClasificacion valor = _valorClasificacionRepository.BuscarPorId(valorClasificacionId) ??
                                   throw new ArgumentException("No se encontro el valor.");
        ValorClasificacionId = valor.CIDVALORCLASIFICACION;
        Codigo = valor.CCODIGOVALORCLASIFICACION;
        Valor = valor.CVALORCLASIFICACION;

        Clasificacion clasificacion = _clasificacionRepository.BuscarPorId(valor.CIDCLASIFICACION) ??
                                      throw new ArgumentException("No se encontro la clasificacion.");
        ClasificacionId = clasificacion.CIDCLASIFICACION;
        ClasificacionNumero = ClasificacionHelper.BuscarNumeroPorId(clasificacion.CIDCLASIFICACION);
        ClasificacionNombre = clasificacion.CNOMBRECLASIFICACION;
    }
}
