using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNaval.BLUE
{
    class BlueUsine : Usine
    {
        //public override Bateau CreateBateau(int n)
        //{
        //    return new BlueBateau(n);
        //}
        public override Bateau CreateContreTorpilleur()
        {
            return new BlueContreTorpilleur();
        }

        public override Bateau CreateCroiseur()
        {
            return new BlueCroiseur();
        }

        public override Bateau CreatePorteAvion()
        {
            return new BluePorteAvion();
        }

        public override Bateau CreateTorpilleur()
        {
            return new BlueTorpilleur();
        }
    }
}
