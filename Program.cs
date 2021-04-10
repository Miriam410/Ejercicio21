using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            // 21. Presente al usuario la fecha actual
            Console.WriteLine($"La fecha actual es {DateTime.Now}");

            //22. Presente al usuariio la fecha actual con el siguiente formato:dd/MM/yyyy
            Console.WriteLine($"La fecha actual es {DateTime.Now.ToString("dd/MM/yyyy")}");

            // 23. Solicite el ingreso de una fecha al usuario y determine si es un ingreso válido
            string fecha;
            DateTime SalidaFecha;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out SalidaFecha))
                {
                    Console.WriteLine("No ha ingresado una fecha válida");
                }
                else 
                {
                    flag = true;
                    Console.WriteLine($"La fecha {SalidaFecha} es correcta");
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (flag==false);
            Console.ReadKey();
        }
    }
}
