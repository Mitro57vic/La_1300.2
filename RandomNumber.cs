using System;

namespace RandomGenerator
{
    public class Generate
    {
        private Random _random;

        public Generate()
        {
            _random = new Random();
        }

        public int GeneriereRandomNummer()
        {
            return _random.Next(1, 101); // Generiert eine Zufallszahl zwischen 1 und 100 (einschließlich).
        }
    }
}

