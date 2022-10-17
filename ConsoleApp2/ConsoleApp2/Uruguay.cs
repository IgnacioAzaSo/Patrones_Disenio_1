using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Uruguay:IFeriado
    {
        public bool esFeriado(int dia, int mes)
        {
            if (dia == 25 && mes == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
