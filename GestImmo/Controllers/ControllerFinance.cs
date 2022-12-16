using ConsoleApp.PostgreSQL;
using GestImmo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestImmo.Controllers
{
    class ControllerFinance
    {

        public int calculerRentabiliteNetMensuelGlobale()
        {
            GestImmoContext ctx = GestImmoContext.getInstance();
            List<Bien> biens = ctx.Biens.ToList();

            int revenuGlobal = 0;

            foreach(Bien bien in biens)
            {
                revenuGlobal = revenuGlobal + bien.calculRentabiliteNetMensuel();

            }
            return revenuGlobal;
        }
        

        
    }
}
