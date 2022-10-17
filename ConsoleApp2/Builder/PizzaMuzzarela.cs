using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class PizzaMuzzarela : Cocina
    {

        public PizzaMuzzarela()
        {
            this.Create();
        }
        public override void Amasar()
        {
            Pizza.Masa = new Masa("Masa comun");
        }

        public override void PonerSalsa()
        {
            Pizza.Salsa = new Salsa("Salsa de tomate");
        }

        public override void PonerExtra()
        {
            Pizza.Extras = new Extras("Muzzarela");
        }
    }
}
