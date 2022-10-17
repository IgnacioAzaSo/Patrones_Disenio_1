using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Agenda
    {

        private IFeriado feriado;
        private int mes;
        private int dia;
            
        public Agenda(IFeriado feriado, int dia, int mes)
        {
            this.feriado = feriado;
            this.mes = mes;
            this.dia = dia;
        }

        public bool esFeriao()
        {
            return feriado.esFeriado(dia, mes);
        }
    }
}
