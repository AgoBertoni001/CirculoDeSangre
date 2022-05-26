using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agoBertoni

namespace CirculoDeSangre{
    internal class Program{

        Asociado asociadoNuevo = new Asociado(); //creo objeto
        
        static void Main(string[] args){
            Menu();
            Console.ReadLine();
        }

        public static void Menu(){

            int opcion;

            do{
                Console.WriteLine("\n---------------- MENÚ -------------------");
                Console.WriteLine( $"\t1-Alta: \n\t2-Mostrar lista de Alta Asociados: \n\t0-No deseo realizar operaciones:");
                Console.Write("----------------------------------------------\n");
                Console.Write("\n\tIngrese su opción: ");
                opcion = int.Parse(Console.ReadLine());
                

                Opciones(opcion);
            
            }while (opcion!=0);
        }

        public static void Opciones(int opcion) {
            
            switch (opcion) {
                
                case 0:
                    Console.WriteLine("Fin del programa."); //No se desea realizar operaciones.
                    break;

                case 1:
                    Asociado.AltaAsociado();
                    break;
                case 2:
                    Asociado.MostrarAlta();
                    break;
            }
        } 

    }
}

