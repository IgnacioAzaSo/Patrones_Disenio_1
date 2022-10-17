using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public  class Argentina : IFeriado
    {
        public bool esFeriado(int dia, int mes)
        {
            if (dia ==14 && mes == 10)
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
