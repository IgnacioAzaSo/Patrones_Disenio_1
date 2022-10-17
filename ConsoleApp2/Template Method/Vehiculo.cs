using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Vehiculo
    {
        public abstract void acelerar();
        public abstract void frenar();
        public abstract void marchaAtras();

        public void estacionar()
        {
            acelerar();
            frenar();
            marchaAtras();
            frenar();
            acelerar();
            frenar();
        }
    }
}
