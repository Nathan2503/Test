using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNaval.RED
{
    class RedUsine : Usine
    {
        //public  override Bateau CreateBateau(int n)
        //{
        //    return new RedBateau(n);
        //}

        public override Bateau CreateContreTorpilleur()
        {
            return new RedContreTorpilleur();
        }

        public override Bateau CreateCroiseur()
        {
            return new RedCroiseur();
        }

        public override Bateau CreatePorteAvion()
        {
            return new RedPorteAvion();
        }

        public override Bateau CreateTorpilleur()
        {
            return new RedTorpilleur();
        }
    }
}
