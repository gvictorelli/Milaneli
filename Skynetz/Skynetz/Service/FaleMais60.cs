﻿using Skynetz.Interface;
using Skynetz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skynetz.Service
{
    public class FaleMais60 : IPlano
    {
        public decimal Calcula(Ligacao ligacao)
        {
            decimal valor = 0;
            if (ligacao.Duracao > 60)
            {
                valor = (ligacao.Duracao - 60) * (ligacao.Tarifa * (decimal)1.1);
            }

            return valor;
        }
    }
}