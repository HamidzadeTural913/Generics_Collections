using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsCollections
{
    internal class Apple
    {
        public string Vitamin;
        public Apple(string vitamin)
        {
            Vitamin = vitamin;


        }
        public override string ToString()
        {
            return $"Vitamin:{Vitamin}";
        }
    }
}
