namespace Skynetz.Service
{
    public class HistoricoDto
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int Tempo { get; set; }
        public string Plano { get; set; }
        public decimal ComFaleMais { get; set; }
        public decimal SemFaleMais { get; set; }

        public HistoricoDto(string origem, string destino, int tempo, string plano, decimal comFaleMais, decimal semFaleMais )
        {
            Origem = origem;
            Destino = destino;
            Tempo = tempo;
            Plano = plano;
            ComFaleMais = comFaleMais;
            SemFaleMais = semFaleMais;
        }
    }
}