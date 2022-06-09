using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class ValidacionesProgram
    {
        public static int OperacionVal(string operacion)
        {
            int opcion;

            while (!Regex.Match(operacion, @"^\d{1}$").Success)
            {
                Console.Write("Ingrese correctamente un valor numerico de operacion: ");
                operacion = Console.ReadLine();
            }
            
            opcion = Int32.Parse(operacion);
            
            while (opcion < 0 || opcion > 5)
            {
                Console.Write("Ingrese correctamente un valor numerico de operacion: ");
                opcion = Int32.Parse(Console.ReadLine());
            }

            return opcion;
        }
    }
}
