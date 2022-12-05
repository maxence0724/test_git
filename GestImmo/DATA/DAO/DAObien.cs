using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestImmo.Views.Forms;
using GestImmo.DATA.Models;
using ConsoleApp.PostgreSQL;

namespace GestImmo.DATA.DAO
{
    internal class DAObien
    {
        public List<Bien> getBienAvecPret()
        {
            List<Bien> biens;
            GestImmoContext context = GestImmoContext.getInstance();
            var rows = from b in context.Biens
                       where b.Pret != null
                       select b;

            biens = rows.ToList();

            return biens;

        }
    }
}
