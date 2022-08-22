using Skynetz.Interface;
using Skynetz.Models;

namespace Skynetz.Service
{
    public class SemFaleMais : IPlano
    {
        public decimal Calcula(Ligacao ligacao)
        {
            return ligacao.Duracao * ligacao.Tarifa;
        }
    }
}