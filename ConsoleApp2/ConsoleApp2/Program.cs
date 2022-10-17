using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda(new Uruguay(), 25, 8);
            Agenda agendaAr= new Agenda(new Argentina(), 25, 8);

            if (agenda.esFeriao())
            {
                Console.WriteLine("Es feriaodo");
            }
            else
            {
                Console.WriteLine("No es feriaodo");

            }

            if (agendaAr.esFeriao())
            {
                Console.WriteLine("Es feriaodo");
            }
            else
            {
                Console.WriteLine("No es feriaodo");

            }

        }
    }
}
