using Skynetz.Interface;
using Skynetz.Models;

namespace Skynetz.Service
{
    public class CalculadoraLigacao
    {
        public decimal CalculaLigacao(Ligacao ligacao, IPlano plano)
        {
            return plano.Calcula(ligacao);
        }
    }
}