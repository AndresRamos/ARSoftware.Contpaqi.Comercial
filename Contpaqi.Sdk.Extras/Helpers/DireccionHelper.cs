using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Models;
using Contpaqi.Sdk.Extras.Models.Enums;

namespace Contpaqi.Sdk.Extras.Helpers
{
    public static class DireccionHelper
    {
        public static tDireccion ToTDireccion(this Direccion direccion)
        {
            return new tDireccion
            {
                cCodCteProv = direccion.CodigoClienteProveedor ?? "",
                cTipoCatalogo = (int) direccion.TipoCatalogo,
                cTipoDireccion = direccion.TipoDireccion == TipoDireccionEnum.Fiscal ? 1 : 2,
                cNombreCalle = direccion.NombreCalle ?? "",
                cNumeroExterior = direccion.NumeroExterior ?? "",
                cNumeroInterior = direccion.NumeroInterior ?? "",
                cColonia = direccion.Colonia ?? "",
                cCodigoPostal = direccion.CodigoPostal ?? "",
                cTelefono1 = direccion.Telefono1 ?? "",
                cTelefono2 = direccion.Telefono2 ?? "",
                cTelefono3 = direccion.Telefono3 ?? "",
                cTelefono4 = direccion.Telefono4 ?? "",
                cEmail = direccion.Email ?? "",
                cDireccionWeb = direccion.DireccionWeb ?? "",
                cCiudad = direccion.Ciudad ?? "",
                cEstado = direccion.Estado ?? "",
                cPais = direccion.Pais ?? "",
                cTextoExtra = direccion.TextoExtra ?? ""
            };
        }

        public static Dictionary<string, string> ToDatosDictionary(this Direccion direccion)
        {
            var datosDireccion = new Dictionary<string, string>();
            datosDireccion.Add("CTIPOCATALOGO", ((int) direccion.TipoCatalogo).ToString());
            datosDireccion.Add("CTIPODIRECCION", ((int) direccion.TipoDireccion).ToString());
            datosDireccion.Add("CNOMBRECALLE", direccion.NombreCalle ?? "");
            datosDireccion.Add("CNUMEROEXTERIOR", direccion.NumeroExterior ?? "");
            datosDireccion.Add("CNUMEROINTERIOR", direccion.NumeroInterior ?? "");
            datosDireccion.Add("CCOLONIA", direccion.Colonia ?? "");
            datosDireccion.Add("CCODIGOPOSTAL", direccion.CodigoPostal ?? "");
            datosDireccion.Add("CTELEFONO1", direccion.Telefono1 ?? "");
            datosDireccion.Add("CTELEFONO2", direccion.Telefono2 ?? "");
            datosDireccion.Add("CTELEFONO3", direccion.Telefono3 ?? "");
            datosDireccion.Add("CTELEFONO4", direccion.Telefono4 ?? "");
            datosDireccion.Add("CEMAIL", direccion.Email ?? "");
            datosDireccion.Add("CDIRECCIONWEB", direccion.DireccionWeb ?? "");
            datosDireccion.Add("CCIUDAD", direccion.Ciudad ?? "");
            datosDireccion.Add("CESTADO", direccion.Estado ?? "");
            datosDireccion.Add("CPAIS", direccion.Pais ?? "");
            datosDireccion.Add("CTEXTOEXTRA", direccion.TextoExtra ?? "");
            datosDireccion.Add("CIDDIRECCION", direccion.Id.ToString());
            datosDireccion.Add("CIDCATALOGO", direccion.IdCatalogo.ToString());
            return datosDireccion;
        }
    }
}