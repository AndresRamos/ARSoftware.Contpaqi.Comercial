using System;
using System.Collections.Generic;
using System.Linq;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Interfaces;
using ARSoftware.Contpaqi.Comercial.Sdk.Extras.Models;

namespace ARSoftware.Contpaqi.Comercial.Sdk.Extras.Repositories
{
    public class MonedaRepository : IMonedaRepository<Moneda>
    {
        public Moneda BuscarPorId(int idMoneda)
        {
            return Moneda.ToList().SingleOrDefault(m => m.Id == idMoneda);
        }

        public Moneda BuscarPorNombre(string nombreMoneda)
        {
            return Moneda.ToList().SingleOrDefault(m => m.Nombre.IndexOf(nombreMoneda, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public IEnumerable<Moneda> TraerTodo()
        {
            return Moneda.ToList();
        }
    }
}
