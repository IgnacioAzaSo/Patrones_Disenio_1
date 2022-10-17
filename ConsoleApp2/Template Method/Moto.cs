using System;
using System.Collections.Generic;
using System.Text;
using Strategy;

namespace Template_Method
{
    internal class Moto:Vehiculo
    {
        private String paso;
        public override void acelerar()
        {
            paso = "camino 10 paso";
        }

        public override void frenar()
        {
            paso = "Me etengo";
        }

        public override void marchaAtras()
        {
            paso = "marcho para atras";
        }
    }
}
