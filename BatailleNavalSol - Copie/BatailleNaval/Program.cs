using BatailleNaval.BLUE;
using BatailleNaval.RED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new RedFactory();
            Usine u=f.CreateUsine();
            Console.WriteLine(u);
            //Console.WriteLine(u.CreateBateau(2));
            Bateau a = u.CreateContreTorpilleur();
            Console.WriteLine(a.Case);
            Console.WriteLine(a);
            a = u.CreateCroiseur();
            Console.WriteLine(a.Case);
            Console.WriteLine(a);
            a = u.CreatePorteAvion();
            Console.WriteLine(a.Case);
            Console.WriteLine(a);
            a = u.CreateTorpilleur();
            Console.WriteLine(a.Case);
            Console.WriteLine(a);
            Console.ReadLine();
            
        }
    }
}
