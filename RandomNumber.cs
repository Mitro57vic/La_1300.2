using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1300
{
    internal class RandomNumber
    {
        public int number { get; set; } = 0;
        Random rnd = new Random();

        public int GeneriereRandomNummer() {

            number = rnd.Next(1, 101);
            return number;
        }
    }
}
