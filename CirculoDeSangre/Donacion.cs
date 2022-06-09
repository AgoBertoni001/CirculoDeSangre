using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Donacion : Peticion
    {
        public static List<Donacion> ListaDonaciones = new List<Donacion>()
        {
            new Donacion(){FechaDonacion="14-03-2022",Estado="Asistio", AsociadoID="5"}
        };

        public string FechaDonacion { get; set; } = String.Empty; //fecha en la que el Asociado se presenta a donar //si no hay fecha deberia estar en pendiente (validar)
        public string Estado { get; set; } = "Pendiente"; //es si va o no a donar. puede ser 'Pendiente' o 'Asistio'
        public string AsociadoID { get; set; } //se determina por la posicion que ocupa el asociado dentro de la listaAsociado


        public static void ListaPrioridad()
        {
            int contadorA=0, contadorB=0, contadorO=0, contadorAB=0; 
            for (int i=0; i<Asociado.listaAsociado.Count();i++)
            {
                if (Categoria.listaCategoria[i].NombreCategoria == "Activo")
                {
                    
                    Console.WriteLine($"ID Asociado: {i} ");
                    Console.WriteLine($"Dni: {Asociado.listaAsociado[i].DNI}");
                    Console.WriteLine($"Nombre y apellido: {Asociado.listaAsociado[i].Nombre} {Asociado.listaAsociado[i].Apellido}");
                    Console.WriteLine($"Grupo sanguineo: {Asociado.listaAsociado[i].GrupoSanguineo}");
                    
                    if (Asociado.listaAsociado[i].GrupoSanguineo == "A")
                    {
                        contadorA+=1;
                    }
                    if (Asociado.listaAsociado[i].GrupoSanguineo == "B")
                    {
                        contadorB += 1;
                    }
                    if (Asociado.listaAsociado[i].GrupoSanguineo == "O")
                    {
                        contadorO += 1;
                    }
                    if (Asociado.listaAsociado[i].GrupoSanguineo == "AB")
                    {
                        contadorAB += 1;
                    }
                }
                Console.WriteLine("\n");
            }


            MostrarListaPrioridad(contadorA, contadorB, contadorO, contadorAB); //Muestra la cantidad en total sin verificar las cantidades de veces que ya donaron ni la fecha en la que lo hicieron
            
        }



        public static void MostrarListaPrioridad(int contadorA, int contadorB, int contadorO, int contadorAB)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Cantidad de donantes disponibles grupo A: {contadorA}");
            Console.WriteLine($"Cantidad de donantes disponibles grupo B: {contadorB}");
            Console.WriteLine($"Cantidad de donantes disponibles grupo O: {contadorO}");
            Console.WriteLine($"Cantidad de donantes disponibles grupo AB: {contadorAB}");
        }



    }
}

/*
 tiene que haber pasado al menos 2 meses y que sea del tipo que se pide.
*/
