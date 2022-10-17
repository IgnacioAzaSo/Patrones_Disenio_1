using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Builder
{
    public class Pizza
    {
        public Masa Masa { get; set; }
        public Salsa Salsa { get; set; }
        public Extras Extras { get; set; }


    }
}
