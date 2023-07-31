using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
public struct tDireccion
{
    /// <summary>
    ///     Código cliente / proveedor.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
    public string cCodCteProv;

    /// <summary>
    ///     Tipo de catálogo.
    /// </summary>
    public int cTipoCatalogo;

    /// <summary>
    ///     Tipo de dirección.
    /// </summary>
    public int cTipoDireccion;

    /// <summary>
    ///     Calle.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cNombreCalle;

    /// <summary>
    ///     Número exterior.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNumeroExtInt)]
    public string cNumeroExterior;

    /// <summary>
    ///     Número interior.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNumeroExtInt)]
    public string cNumeroInterior;

    /// <summary>
    ///     Colonia.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cColonia;

    /// <summary>
    ///     Código postal.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigoPostal)]
    public string cCodigoPostal;

    /// <summary>
    ///     Telefono 1.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
    public string cTelefono1;

    /// <summary>
    ///     Telefono 2.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
    public string cTelefono2;

    /// <summary>
    ///     Telefono 3.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
    public string cTelefono3;

    /// <summary>
    ///     Telefono 4.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
    public string cTelefono4;

    /// <summary>
    ///     Correo electrónico.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongEmailWeb)]
    public string cEmail;

    /// <summary>
    ///     Página web.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongEmailWeb)]
    public string cDireccionWeb;

    /// <summary>
    ///     Ciudad,
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cCiudad;

    //Estado.
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cEstado;

    /// <summary>
    ///     País.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cPais;

    /// <summary>
    ///     Texto extra.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
    public string cTextoExtra;
}
