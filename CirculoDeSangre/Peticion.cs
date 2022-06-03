using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Peticion
    {
        public static List<Peticion> Peticiones = new List<Peticion>()
        {
            new Peticion() {FechaEmision = "26-05-2022" , GrupoSanguineo = "A", FactorSanguineo = '-', CantDonantes = 2 , FechaLimite = "02/06/2022",}
        };
    
        public string FechaEmision { get; set; }
        public string GrupoSanguineo { get; set; } // A, B, O, AB
        public char FactorSanguineo { get; set; } //+,-
        public int CantDonantes { get; set; }
        public string FechaLimite { get; set; }

        public static void RegistroPeticionDeBanco()
        {
            string fechaEmision = DateTime.Now.ToString("dd/MM/yyyy");
            Console.Write($"Peticion N°: {Peticiones.Count()}\nFecha Emision: {fechaEmision}");
            
            Console.Write("\nIngrese Grupo Sanguineo (A-B-O-AB): ");
            string grupoSanguineo = Console.ReadLine();
            //validar 

            Console.WriteLine("\nIngrese Factor Sanguineo (+ -): ");
            char factorSanguineo = char.Parse(Console.ReadLine());
            //validar

            Console.WriteLine("\nIngrese Cantidad de donantes necesarios: ");
            int cantDonantes = int.Parse(Console.ReadLine());
            //validar

            Console.WriteLine("\nIngrese Fecha Limite a la Peticion: ");
            string fechaLimite = Console.ReadLine();
            fechaLimite = ValidacionesPeticion.FechaLimiteVal(fechaLimite);
            //pasarlo a datetime

            Peticiones.Add(new Peticion { FechaEmision = DateTime.Now.ToString("dd-mm-aaa"), GrupoSanguineo = grupoSanguineo, FactorSanguineo = factorSanguineo, CantDonantes = cantDonantes, FechaLimite = fechaLimite });

        } 

        public static void MostrarPeticiones()
        {
            for (int i=0;i<Peticiones.Count();i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Peticion N° {i}");
                Console.WriteLine($"Fecha emision: {Peticiones[i].FechaEmision}");
                Console.WriteLine($"Fecha Limite: { Peticiones[i].FechaLimite}");
                Console.WriteLine($"Solicitud de: {Peticiones[i].CantDonantes} personas, {Peticiones[i].GrupoSanguineo} {Peticiones[i].FactorSanguineo}");
            }
            Console.WriteLine("listo");
        }

    }
}
