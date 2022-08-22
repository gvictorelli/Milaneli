using System;
using System.Collections.Generic;
using System.Linq;

namespace Skynetz.Data
{
    public class HistoricoDB
    {
        public List<Historico> Lista()
        {
            var ctx = new SkynetzEntities1();
            return ctx.Historico.ToList();
        }

        public void Insert(Historico historico)
        {
            using (var db = new SkynetzEntities1())
            {
                historico.Id = 1;
                db.Historico.Add(historico);
                db.SaveChanges();
            }
        }
    }

}