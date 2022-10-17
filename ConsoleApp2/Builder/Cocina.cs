using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class Cocina
    {
        public Pizza Pizza { get; set; }

        public void Create()
        {
            Pizza = new Pizza();
            Amasar();
            PonerSalsa();
            PonerExtra();
        }

        public abstract void Amasar();
        public abstract void PonerSalsa();
        public abstract void PonerExtra();


    }
}
