using Skynetz.Interface;
using Skynetz.Models;
using Skynetz.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Skynetz
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //Origem e Destino
                Tarifa tarifa = new Tarifa();

                DropDownListCodigoOrigemEDestino.DataValueField = "Id";
                DropDownListCodigoOrigemEDestino.DataTextField = "Nome";
                DropDownListCodigoOrigemEDestino.DataSource = tarifa.Tarifas();
                DropDownListCodigoOrigemEDestino.DataBind();

                //Plano
                PlanoModel planoModel = new PlanoModel();
                DropDownListPlano.DataValueField = "Id";
                DropDownListPlano.DataTextField = "Nome";
                DropDownListPlano.DataSource = planoModel.Planos();
                DropDownListPlano.DataBind();

                AtualizaHistorico();
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CalculadoraLigacao calculadoraLigacao = new CalculadoraLigacao();

                int tempoLigacao;
                bool resultado = Int32.TryParse(TextBoxTempoLigacao.Text, out tempoLigacao);
                
                //Tarifas
                Tarifa tarifa = new Tarifa();
                var tarifas = tarifa.Tarifas();
                decimal valorTarifa = tarifas.Find(x => x.Id == DropDownListCodigoOrigemEDestino.SelectedIndex).Valor;
                string descricaoTarifa = tarifas.Find(x => x.Id == DropDownListCodigoOrigemEDestino.SelectedIndex).Nome;
                string origem = descricaoTarifa.Split('-')[0].Split(':')[1].Trim();
                string destino = descricaoTarifa.Split('-')[1].Split(':')[1].Trim();

                //Plano
                PlanoModel planoModel = new PlanoModel();
                var planos = planoModel.Planos();
                string nomePlano = DropDownListPlano.SelectedItem.Text;
                IPlano plano = planos.Find(x => x.Id == DropDownListPlano.SelectedIndex).Tipo;

                if (resultado)
                {
                    Ligacao ligacao = new Ligacao(tempoLigacao, valorTarifa);

                    decimal comFaleMais = calculadoraLigacao.CalculaLigacao(ligacao, plano);
                    decimal semFaleMais = calculadoraLigacao.CalculaLigacao(ligacao, new SemFaleMais());

                    HistoricoService historicoService = new HistoricoService();
                    historicoService.AdicionarHistorico(new HistoricoDto(origem, destino, tempoLigacao, nomePlano, comFaleMais, semFaleMais));

                    AtualizaHistorico();
                }
            }
        }

        private void AtualizaHistorico()
        {
            HistoricoService historicoService = new HistoricoService();
            var historico = historicoService.ListaHistorico();
            rpt.DataSource = historico;
            rpt.DataBind();
        }
    }
}