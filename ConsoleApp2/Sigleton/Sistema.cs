using System;
using System.Collections.Generic;
using System.Text;

namespace Sigleton
{
    public class Sistema
    {
        private static Sistema _sistema = null;

        private Sistema()
        {

        }

        public static Sistema GetInstance()
        {
            if (_sistema == null)
            {
                _sistema = new Sistema();
            }
            return _sistema;
        }

    }
}
