using System.Collections.Generic;
using Contpaqi.Sdk.Extras.Modelos;

namespace Contpaqi.Sdk.Extras.Interfaces
{
    public interface IEmpresaRepositorio
    {
        IEnumerable<Empresa> TraerEmpresas();
    }
}