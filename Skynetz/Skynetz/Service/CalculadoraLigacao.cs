using Skynetz.Interface;
using Skynetz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skynetz.Service
{
    public class CalculadoraLigacao
    {
        public decimal CalculaLigacao(Ligacao ligacao , IPlano plano)
        {
            return plano.Calcula(ligacao);
        }
    }
}