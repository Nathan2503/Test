using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNaval
{
  public abstract class Bateau
    {
        public int Case { get; set; }
        public Bateau(int n)
        {
            Case = n;
        }
    }
}
