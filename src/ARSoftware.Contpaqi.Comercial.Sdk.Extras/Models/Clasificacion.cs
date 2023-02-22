﻿using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Comercial.Sql.Models.Empresa;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models
{
    public class Clasificacion : admClasificaciones
    {
        public List<ValorClasificacion> Valores { get; set; } = new List<ValorClasificacion>();

        public bool Contains(string filtro)
        {
            return string.IsNullOrWhiteSpace(filtro) ||
                   CIDCLASIFICACION.ToString().IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   CNOMBRECLASIFICACION.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public override string ToString()
        {
            return $"{CNOMBRECLASIFICACION}";
        }
    }
}
