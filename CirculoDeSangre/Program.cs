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
                        
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {

            int opcion;
                Console.Clear();

                Console.WriteLine("\n");
                string title = "  CIRCULO DE SANGRE  ";
                string border = new string('-', title.Length);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(border);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(border);

                Console.WriteLine("\n\n");
                Console.WriteLine("MENÚ DE OPERACIONES");
                Console.WriteLine("\n\n");
                Console.WriteLine("\t1 - Alta de Asociado.");
                Console.WriteLine("\t2 - Mostrar lista de Alta Asociados. ");
                Console.WriteLine("\t3 - Generar Peticion del Banco.");
                Console.WriteLine("\t4 - Mostrar Peticiones");
                Console.WriteLine("\t5 - Mostrar cantidad de donantes disponibles");
                Console.WriteLine("\t0 - No deseo realizar operaciones. ");
                Console.WriteLine("\n");
                Console.Write("Ingrese la operacion que desea realizar:       ");
                string operacion = Console.ReadLine();
                opcion = ValidacionesProgram.OperacionVal(operacion);
                
                Opciones(opcion);


        }

        public static void Opciones(int opcion)
        {
            Console.Clear();
            switch (opcion)
            {

                case 0:
                    Console.WriteLine("Fin del programa");
                    break;
                case 1:
                    Asociado.AltaAsociado();
                    Volver();
                    break;
                case 2:
                    Asociado.MostrarAlta();
                    Volver();
                    break;
                case 3:
                    Peticion.RegistroPeticionDeBanco();
                    Volver();
                    break;
                case 4:
                    Peticion.MostrarPeticiones();
                    Volver();
                    break;
                case 5:
                    Donacion.ListaPrioridad();
                    Volver();
                    break;
            }
        }

        public static void Volver()
        {
            Console.WriteLine("\n");
            Console.WriteLine("¿Desea regresar al menpu principal? (Si: 1 - No: 2)");
            int respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Menu();
            }
            Console.Clear();
            Console.WriteLine("Fin del programa.");
        }
        
    }
}

