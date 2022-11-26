using System.Runtime.InteropServices;
using ARSoftware.Contpaqi.Comercial.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace ARSoftware.Contpaqi.Comercial.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tDireccion
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigo)]
        public string cCodCteProv;

        public int cTipoCatalogo;
        public int cTipoDireccion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cNombreCalle;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNumeroExtInt)]
        public string cNumeroExterior;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongNumeroExtInt)]
        public string cNumeroInterior;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cColonia;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongCodigoPostal)]
        public string cCodigoPostal;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
        public string cTelefono1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
        public string cTelefono2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
        public string cTelefono3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongTelefono)]
        public string cTelefono4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongEmailWeb)]
        public string cEmail;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongEmailWeb)]
        public string cDireccionWeb;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cCiudad;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cEstado;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cPais;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = SdkConstantes.kLongDescripcion)]
        public string cTextoExtra;
    }
}
