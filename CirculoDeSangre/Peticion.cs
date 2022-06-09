using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Peticion
    {
        public static List<Peticion> ListaPeticiones = new List<Peticion>()
        {
            new Peticion() {FechaEmision = "26-05-2022" , GrupoSanguineo = "A", CantDonantes = "2" , FechaLimite = "06-06-2022"},
        };
    
        public string FechaEmision { get; set; }
        public string GrupoSanguineo { get; set; } // A, B, O, AB
        public string CantDonantes { get; set; }
        public string FechaLimite { get; set; }

        public static void RegistroPeticionDeBanco()
        {
            string fechaEmision = DateTime.Now.ToString("dd-MM-yyyy");
            
            Console.Write($"Peticion N°: {ListaPeticiones.Count()}");

            Console.WriteLine($"\nFecha Emision: {fechaEmision}");


            Console.Write("Ingrese Grupo Sanguineo (A-B-O-AB): ");
            string grupoSanguineo = Console.ReadLine();
            grupoSanguineo = ValidacionesPeticion.GrupoSanguineoVal(grupoSanguineo);

            
            Console.Write("Ingrese Cantidad de donantes necesarios: ");
            string cantDonantes = Console.ReadLine();
            cantDonantes = ValidacionesPeticion.CantidadDonantesVal(cantDonantes);
            
            Console.Write("Ingrese Fecha Limite a la Peticion: ");
            string fechaLimite = Console.ReadLine();
            fechaLimite = ValidacionesPeticion.FechaLimiteVal(fechaLimite);
            
            ListaPeticiones.Add(new Peticion { FechaEmision = DateTime.Now.ToString("dd-mm-aaa"), GrupoSanguineo = grupoSanguineo, CantDonantes = cantDonantes, FechaLimite = fechaLimite });

        } 

        public static void MostrarPeticiones()
        {
            for (int i=0;i< ListaPeticiones.Count();i++)
            {
                
                Console.WriteLine($"Peticion N° {i}");
                Console.WriteLine($"Fecha emision: {ListaPeticiones[i].FechaEmision}");
                Console.WriteLine($"Fecha Limite: { ListaPeticiones[i].FechaLimite}");
                Console.WriteLine($"Solicitud de: {ListaPeticiones[i].CantDonantes}");
                Console.WriteLine($"Grupo sanguineo: {ListaPeticiones[i].GrupoSanguineo}");
                Console.WriteLine("\n");
            }
        }

    }
}
