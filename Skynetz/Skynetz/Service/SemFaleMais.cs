using Skynetz.Interface;
using Skynetz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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