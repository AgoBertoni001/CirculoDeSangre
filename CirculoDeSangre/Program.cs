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

        public Asociado asociado = new Asociado(); 


        static void Main(string[] args)
        {
            Menu();
            Console.ReadLine();
        }



        public static void Menu()
        {
            
            Console.WriteLine("MENÚ:    \n");
            Console.WriteLine("Elija la operacion a realizar:\n");
            Console.WriteLine("1-Alta (oprima tecla 1): \n2-No deseo realizar operaciones (oprima 0): \n");
            Console.Write("Ingrese su opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Su opción fue: {0}", opcion);

            Opciones(opcion);
            
            
        }




        public static void Opciones(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Fin del programa."); //No se desea realizar operaciones.
                    break;
                
                case 1:
                   
                    Asociado.AltaAsociado();  //llamar a la funcion Alta
                    
                    Console.WriteLine("Si desea ver los datos que ingresó presione 1, en caso que no lo desee 0: ");
                    int imprimaDatosIngresados=int.Parse(Console.ReadLine());
                    
                    if (imprimaDatosIngresados == 1) {
                        Asociado.MostrarAlta();
                    }
                    else if (imprimaDatosIngresados==0)
                    {
                        Console.WriteLine("No desea ver los resultados");

                    }

                    break;
            }
        } 

    }
}

