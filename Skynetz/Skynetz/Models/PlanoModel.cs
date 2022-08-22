using Skynetz.Interface;
using Skynetz.Service;
using System.Collections.Generic;

namespace Skynetz.Models
{
    public class PlanoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IPlano Tipo { get; set; }

        public List<PlanoModel> Planos()
        {
            return new List<PlanoModel>()
            {
                new PlanoModel() { Id = 0, Nome = "FaleMais 30", Tipo = new FaleMais30() },
                new PlanoModel() { Id = 1, Nome = "FaleMais 60", Tipo = new FaleMais60() },
                new PlanoModel() { Id = 2, Nome = "FaleMais 120", Tipo = new FaleMais120() },
            };
        }
    }
}