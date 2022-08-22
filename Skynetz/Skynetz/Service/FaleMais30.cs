using Skynetz.Interface;
using Skynetz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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