using System.Runtime.InteropServices;
using Contpaqi.Sdk.Constantes;

// ReSharper disable UnusedType.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming

namespace Contpaqi.Sdk.DatosAbstractos
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
    public struct tDireccion
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigo)]
        public string cCodCteProv;

        public int cTipoCatalogo;
        public int cTipoDireccion;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cNombreCalle;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNumeroExtInt)]
        public string cNumeroExterior;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongNumeroExtInt)]
        public string cNumeroInterior;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cColonia;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongCodigoPostal)]
        public string cCodigoPostal;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTelefono)]
        public string cTelefono1;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTelefono)]
        public string cTelefono2;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTelefono)]
        public string cTelefono3;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongTelefono)]
        public string cTelefono4;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongEmailWeb)]
        public string cEmail;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongEmailWeb)]
        public string cDireccionWeb;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cCiudad;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cEstado;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cPais;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ConstantesSdk.kLongDescripcion)]
        public string cTextoExtra;
    }
}
