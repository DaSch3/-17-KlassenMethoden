using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch peter = new Mensch();
            Mensch manfred = new Mensch();
            manfred.Name = "Manni";
            manfred.Begrüßung();
            peter.Name = "Peter";
            peter.Begrüßung();

            Console.ReadKey();
        }
    }

    class Mensch
    {
        //Eigenschaften
        public string Name { get; set; }

        //Methoden
        public void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");
        }
    }
}
