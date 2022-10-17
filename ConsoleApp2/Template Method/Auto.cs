using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class Auto :Vehiculo
    {
        private int velocidad;
        public override void acelerar()
        {
            velocidad = 5;
        }

        public override void frenar()
        {
            velocidad = 0;
        }

        public override void marchaAtras()
        {
            velocidad = -5;
        }
    }
}
