using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contpaqi.Sdk.Ejemplos.Messages;
using Contpaqi.Sdk.Extras.Helpers;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;
using MahApps.Metro.Controls.Dialogs;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace Contpaqi.Sdk.Ejemplos.ViewModels.ValoresClasificacion;

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
                                             IClasificacionRepository<Clasificacion> clasificacionRepository,
                                             IDialogCoordinator dialogCoordinator,
                                             IValorClasificacionRepository<ValorClasificacion> valorClasificacionRepository)
    {
        _valorClasificacionService = valorClasificacionService;
        _clasificacionRepository = clasificacionRepository;
        _dialogCoordinator = dialogCoordinator;
        _valorClasificacionRepository = valorClasificacionRepository;

        GuardarCommand = new AsyncRelayCommand(GuardarAsync);
        CancelarCommand = new RelayCommand(CerrarVista);
    }

    public string Title { get; } = "Editar Valor De Clasificacion";

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

    public int ValorClasificacionId
    {
        get => _valorClasificacionId;
        set => SetProperty(ref _valorClasificacionId, value);
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

    public IAsyncRelayCommand GuardarCommand { get; }
    public IRelayCommand CancelarCommand { get; }

    public void Inicializar(int valorClasificacionId)
    {
        ValorClasificacion valor = _valorClasificacionRepository.BuscarPorId(valorClasificacionId);
        ValorClasificacionId = valor.CIDVALORCLASIFICACION;
        Codigo = valor.CCODIGOVALORCLASIFICACION;
        Valor = valor.CVALORCLASIFICACION;

        Clasificacion clasificacion = _clasificacionRepository.BuscarPorId(valor.CIDCLASIFICACION);
        ClasificacionId = clasificacion.CIDCLASIFICACION;
        ClasificacionNumero = ClasificacionHelper.BuscarNumeroPorId(clasificacion.CIDCLASIFICACION);
        ClasificacionNombre = clasificacion.CNOMBRECLASIFICACION;
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

    public void CerrarVista()
    {
        Messenger.Send(new ViewModelVisibilityChangedMessage(this, false));
    }
}
