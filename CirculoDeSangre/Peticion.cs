using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    internal class Peticion
    {
        public static List<Peticion> Peticiones = new List<Peticion>()
        {
            new Peticion() {FechaEmision = "26-05-2022" , GrupoSanguineo = "A", FactorSanguineo = '+', CantDonantes = 2 , FechaLimite = "02/06/2022",}
        };
    
        public string FechaEmision { get; set; }
        public string GrupoSanguineo { get; set; } // A, B, O, AB
        public char FactorSanguineo { get; set; } //+,-
        public int CantDonantes { get; set; }
        public string FechaLimite { get; set; }

        public static void SolicitudBanco()
        {
            string fechaEmision = DateTime.Now.ToString("dd/MM/yyyy");
            Console.Write($"Peticion N°: {Peticiones.Count()}\nFecha Emision: {fechaEmision}");
            
            Console.Write("Ingrese Grupo Sanguineo (A-B-O-AB): ");
            string grupoSanguineo = Console.ReadLine();
            //validar 

            Console.WriteLine("Ingrese Factor Sanguineo (+ -): ");
            char factorSanguineo = char.Parse(Console.ReadLine());
            //validar

            Console.WriteLine("Ingrese Cantidad de donantes necesarios: ");
            int cantDonantes = int.Parse(Console.ReadLine());
            //validar

            Console.WriteLine("Ingrese Fecha Limite a la Peticion: ");
            string fechaLimite = Console.ReadLine();
            //validarlo
            //pasarlo a datetime



        } 
    }
}
