using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agoBertoni

namespace CirculoDeSangre
{
    internal class Program
    {

        Asociado asociadoNuevo = new Asociado(); //creo objeto

        static void Main(string[] args)
        {

            Console.WriteLine("\n");
            string title = "  S.I. CIRCULO DE SANGRE  ";
            string border = new string('-', title.Length);
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(border);
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(border);

            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {

            int opcion;

            do
            {

                Console.WriteLine("\n");
                /*string title1 = "MENÚ DE OPERACIONES";
                Console.SetCursorPosition((Console.WindowWidth - title1.Length) / 2, Console.CursorTop);
                Console.WriteLine(title1);*/

                Console.WriteLine("MENÚ DE OPERACIONES");
                Console.WriteLine("\n");
                Console.WriteLine("\t0 - No deseo realizar operaciones. ");
                Console.WriteLine("\t1 - Alta.");
                Console.WriteLine("\t2 - Mostrar lista de Alta Asociados. ");
                Console.WriteLine("\t3 - Gestionar Peticion del Banco.");
                Console.WriteLine("\t4 - Mostrar Peticiones");
                Console.WriteLine("\n");
                Console.Write("Ingrese la operacion que desea realizar:       ");
                opcion = int.Parse(Console.ReadLine());
                Opciones(opcion);

                Console.WriteLine("Si desea realizar otra operacion oprima alguna tecla");
                char continuar = char.Parse(Console.ReadLine());

            } while (opcion != 0);
        }

        public static void Opciones(int opcion)
        {
            Console.Clear();
            switch (opcion)
            {

                case 0:
                    Console.WriteLine("Fin del programa.");
                    break;
                case 1:
                    Asociado.AltaAsociado();
                    break;
                case 2:
                    Asociado.MostrarAlta();
                    break;
                case 3:
                    Peticion.RegistroPeticionDeBanco();
                    break;
                case 4:
                    Peticion.MostrarPeticiones();
                    break;
            }
        }


        
    }
}

