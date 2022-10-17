using System;
using Strategy;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Auto();
            v.estacionar();
        }
    }
}
