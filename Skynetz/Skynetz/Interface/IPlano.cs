using Skynetz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skynetz.Interface
{
    public interface IPlano
    {
        decimal Calcula(Ligacao ligacao);
    }
}
