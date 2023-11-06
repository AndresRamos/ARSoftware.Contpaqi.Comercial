using System;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Abstractions.Enums;

[Flags]
public enum ControlExistencias
{
    Ninguno = 0,
    Unidades = 1,
    Caracteristicas = 2,
    Series = 4,
    Pedimentos = 8,
    Lotes = 16
}
