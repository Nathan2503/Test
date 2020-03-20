using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNaval
{
    public abstract class Usine
    {
        //public abstract Bateau CreateBateau(int n);
        public abstract Bateau CreatePorteAvion();
        public abstract Bateau CreateTorpilleur();
        public abstract Bateau CreateContreTorpilleur();
        public abstract Bateau CreateCroiseur(); 

    }
}
