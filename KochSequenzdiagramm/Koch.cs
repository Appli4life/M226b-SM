using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KochSequenzdiagramm
{
    
    public class Koch
    {
        private Herd Herd;

        public Koch(Herd herd)
        {
             Herd= herd;

            Herd.Einschalten();

            Herd.Ausschalten();
        }
    }
}
