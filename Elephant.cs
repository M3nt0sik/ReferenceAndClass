using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndClass
{
    internal class Elephant
    {
        public string Name = "";
        public int EarSize = 0;

        public void WhoAmI()
        {
            Console.WriteLine("Na imie mam: " + Name);
            Console.WriteLine("Dulgosc moich uszu to: " + EarSize + " cm");
        }
    }
}
