using System;

namespace Sigleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema1 = Sistema.GetInstance();

            Sistema sistema2 = Sistema.GetInstance();

            if (sistema1 == sistema2)
            {
                Console.WriteLine("Son la misma instancia.");
            }
            else
            {
                Console.WriteLine("NO FUNCIONA.");
            }
        }
    }
}
