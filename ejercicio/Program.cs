using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreEmpleado;
            int horasTrabajadas;
            double costoHora;
            double totalDevengado;

            Console.WriteLine ("ingrese su nombre ");
            Console.WriteLine("Costo por hora trabajada : ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de horas trabajadas esta semana: ");
            costoHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("==== Boleta semanal ====");
            Console.WriteLine("Costo por hora trabajada: " + costoHora);
            Console.WriteLine($"total de horas trabajadas es: {horasTrabajadas}");
           

            totalDevengado = costoHora * horasTrabajadas;
            Console.WriteLine($"el total devengado correspondiente es de:L." + totalDevengado.ToString());

        }
    }
}
