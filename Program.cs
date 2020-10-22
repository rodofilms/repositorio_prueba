using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App02_CalcularSueldo_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            double costoHora, sueldo;
            string linea;

            Console.Write("Ingrese horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);

            Console.Write("Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora = double.Parse(linea);

            sueldo = costoHora * horasTrabajadas;
            Console.Write("\nEl Sueldo es: "+sueldo);
            Console.ReadKey();
            
        }
    }
}
