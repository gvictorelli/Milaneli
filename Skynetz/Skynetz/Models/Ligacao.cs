namespace Skynetz.Models
{
    public class Ligacao
    {
        public int Duracao { get; private set; }
        public decimal Tarifa { get; private set; }

        public Ligacao(int duracao, decimal tarifa)
        {
            Duracao = duracao;
            Tarifa = tarifa;
        }
    }
}