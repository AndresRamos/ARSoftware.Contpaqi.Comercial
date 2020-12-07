using System;
using System.Collections.Generic;
using System.Linq;
using Contpaqi.Sdk.Extras.Interfaces;
using Contpaqi.Sdk.Extras.Models;

namespace Contpaqi.Sdk.Extras.Repositories
{
    public class MonedaRepository : IMonedaRepository<Moneda>
    {
        public Moneda BuscarPorNombre(string nombreMoneda)
        {
            return Moneda.ToList().SingleOrDefault(m => m.Nombre.IndexOf(nombreMoneda, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        public Moneda BuscarPorId(int idMoneda)
        {
            return Moneda.ToList().SingleOrDefault(m => m.Id == idMoneda);
        }

        public IEnumerable<Moneda> TraerTodo()
        {
            return Moneda.ToList();
        }
    }
}