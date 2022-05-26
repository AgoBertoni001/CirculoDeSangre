using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Donacion
    {
        public static List<Donacion> Donaciones = new List<Donacion>();
        public string Fecha { get; set; }
        public string Estado { get; set; }
        public string AsociadoID { get; set; } 

        public static void ListaPrioridad()
        {
            for (int i=0; i<Asociado.listaAsociado.Count();i++)
            {
                if (Categoria.listaCategoria[i].NombreCategoria == "Activo")
                {
                    Console.WriteLine($"+ Asociado ID:{i}, {Asociado.listaAsociado[i].Nombre} {Asociado.listaAsociado[i].Apellido} - DNI: {Asociado.listaAsociado[i].DNI}");
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
