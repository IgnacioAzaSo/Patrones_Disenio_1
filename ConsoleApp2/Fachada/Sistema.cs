using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada
{
    public class Sistema
    {
        private SistemaUsuario sistemaUsuario;
        private SistemaEmpleado sistemaEmpleado;
        public void IngresarUsuario(Usuario usuario)
        {
            sistemaUsuario.Ingresar(usuario);
        }
        public void IngresarEmpleado(Empleado empleado)
        {
            sistemaEmpleado.Ingresar(empleado);
        }

        public double CalcularSueldo()
        {
            return sistemaEmpleado.CalcularSueldo();
        }

    }
}
