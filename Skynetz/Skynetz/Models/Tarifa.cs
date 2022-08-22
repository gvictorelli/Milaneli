using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skynetz.Models
{
    public class Tarifa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public List<Tarifa> Tarifas()
        {
            return new List<Tarifa>()
            {
                new Tarifa() { Id = 0, Nome = $"Origem: 011 - Destino: 016", Valor = 1.90M },
                new Tarifa() { Id = 1, Nome = $"Origem: 011 - Destino: 017", Valor = 1.70M },
                new Tarifa() { Id = 2, Nome = $"Origem: 011 - Destino: 018", Valor = 0.90M },
                new Tarifa() { Id = 3, Nome = $"Origem: 016 - Destino: 011", Valor = 2.90M },
                new Tarifa() { Id = 4, Nome = $"Origem: 017 - Destino: 011", Valor = 2.70M },
                new Tarifa() { Id = 5, Nome = $"Origem: 018 - Destino: 011", Valor = 1.90M }
            };
        }
    }
}