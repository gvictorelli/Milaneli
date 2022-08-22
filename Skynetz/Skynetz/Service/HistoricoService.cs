using Skynetz.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skynetz.Service
{
    public class HistoricoService
    {
        private HistoricoDB _historicoDB;
        public HistoricoService()
        {
            _historicoDB = new HistoricoDB();
        }

        public void AdicionarHistorico(HistoricoDto historicoDto)
        {
            Historico historico = new Historico()
            {
                Origem = historicoDto.Origem,
                Destino = historicoDto.Destino,
                Tempo = historicoDto.Tempo,
                Plano = historicoDto.Plano,
                ComFaleMais = historicoDto.ComFaleMais,
                SemFaleMais = historicoDto.SemFaleMais
            };

            _historicoDB.Insert(historico);
        }

        public List<HistoricoDto> ListaHistorico()
        {
            List<Historico> historicoList = _historicoDB.Lista();
            List<HistoricoDto> historicoDtoList = new List<HistoricoDto>();

            foreach(var historico in historicoList)
            {
                historicoDtoList.Add
                (
                    new HistoricoDto(historico.Origem, historico.Destino, (int)historico.Tempo, historico.Plano, (decimal)historico.ComFaleMais, (decimal)historico.SemFaleMais)
                );
            }

            return historicoDtoList;
        }
    }
}