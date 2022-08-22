using Skynetz.Interface;
using Skynetz.Models;

namespace Skynetz.Service
{
    public class FaleMais30 : IPlano
    {
        public decimal Calcula(Ligacao ligacao)
        {
            decimal valor = 0;
            if (ligacao.Duracao > 30)
            {
                valor = (ligacao.Duracao - 30) * (ligacao.Tarifa * (decimal)1.1);
            }

            return valor;
        }
    }
}