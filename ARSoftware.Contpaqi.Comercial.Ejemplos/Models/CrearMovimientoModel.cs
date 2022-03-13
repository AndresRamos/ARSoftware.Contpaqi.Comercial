using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Ejemplos.Models;

public class CrearMovimientoModel : ObservableObject
{
    private Almacen _almacen;
    private int _cidalmacen;
    private int _ciddocumento;
    private int _cidproducto;
    private double _cprecio;
    private string _creferencia;
    private double _cunidadescapturadas;
    private ProductoLookup _producto;

    public int CIDDOCUMENTO
    {
        get => _ciddocumento;
        set => SetProperty(ref _ciddocumento, value);
    }

    public int CIDPRODUCTO
    {
        get => _cidproducto;
        set => SetProperty(ref _cidproducto, value);
    }

    public int CIDALMACEN
    {
        get => _cidalmacen;
        set => SetProperty(ref _cidalmacen, value);
    }

    public double CUNIDADESCAPTURADAS
    {
        get => _cunidadescapturadas;
        set => SetProperty(ref _cunidadescapturadas, value);
    }

    public double CPRECIO
    {
        get => _cprecio;
        set => SetProperty(ref _cprecio, value);
    }

    public string CREFERENCIA
    {
        get => _creferencia;
        set => SetProperty(ref _creferencia, value);
    }

    public ProductoLookup Producto
    {
        get => _producto;
        set
        {
            SetProperty(ref _producto, value);
            CIDPRODUCTO = value?.CIDPRODUCTO ?? 0;
        }
    }

    public Almacen Almacen
    {
        get => _almacen;
        set
        {
            SetProperty(ref _almacen, value);
            CIDALMACEN = value?.CIDALMACEN ?? 0;
        }
    }
}
