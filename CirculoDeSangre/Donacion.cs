using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Donacion : Peticion
    {
        public static List<Donacion> Donaciones = new List<Donacion>()
        {
            new Donacion(){Fecha="29-05-2022",Estado="", AsociadoID="12656"}
        };

        public string Fecha { get; set; } //fecha en la que el Asociado se presenta a donar //si no hay fecha deberia estar en pendiente (validar)
        public string Estado { get; set; } = "Pendiente"; //es si va o no a donar. puede ser 'Pendiente' o 'Asistio'
        public string AsociadoID { get; set; } //se determina por la posicion que ocupa el asociado dentro de la listaAsociado

        public static void ListaPrioridad()
        {
            for (int i=0; i<Asociado.listaAsociado.Count();i++)
            {
                if (Categoria.listaCategoria[i].NombreCategoria == "Categoria: Activo")
                {
                    Console.WriteLine($"Asociado ID:{i} ");
                    Console.WriteLine($"Nombre y apellido: {Asociado.listaAsociado[i].Nombre} {Asociado.listaAsociado[i].Apellido}");
                    Console.WriteLine($"Dni: {Asociado.listaAsociado[i].DNI}");
                    Console.WriteLine($"Grupo sanguineo: {Asociado.listaAsociado[i].GrupoSanguineo}");
                    Console.WriteLine($"Ultima donacion: {Asociado.listaAsociado[i].UltimaDonacion} ");
                    Console.WriteLine($"Numero de donaciones: {Asociado.listaAsociado[i].CantidadDonaciones}");

                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
