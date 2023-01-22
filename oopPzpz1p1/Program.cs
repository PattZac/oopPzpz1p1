using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPzpz1p1
{
    class Fruit
    {
        string vrsta, boja;
        bool jeLiSlatko;
        public Fruit(string v)
        {
            this.vrsta = v;
        }
        public Fruit(string v,string b, bool jLS)
        {
            this.vrsta = v;
            this.boja = b;
            this.jeLiSlatko = jLS;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruit x = new Fruit("Jagoda", "Crvena", true);
            Fruit y = new Fruit("Limun", "Žuta", false);
            Fruit z = new Fruit("Avokado");
        }
    }
}
