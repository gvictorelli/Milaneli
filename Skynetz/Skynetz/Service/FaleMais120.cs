using Skynetz.Interface;
using Skynetz.Models;

namespace Skynetz.Service
{
    public class FaleMais120 : IPlano
    {
        public decimal Calcula(Ligacao ligacao)
        {
            decimal valor = 0;
            if (ligacao.Duracao > 120)
            {
                valor = (ligacao.Duracao - 120) * (ligacao.Tarifa * (decimal)1.1);
            }

            return valor;
        }
    }
}