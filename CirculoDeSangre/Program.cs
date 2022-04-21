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
            
            int opcion = 1;
            
            do{
                Console.WriteLine("MENÚ:    \n");
                Console.WriteLine("Elija la operacion a realizar:\n");
                Console.WriteLine("1-Alta (oprima tecla 1): " + "\n2-No deseo realizar operaciones (oprima 0): \n");
                Console.Write("Ingrese su opción: ");
                
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Su opción fue: {0}", opcion);
                Opciones(opcion);

            
            }while (opcion!=0);
        }

        public static void Opciones(int opcion) {
            
            switch (opcion) {
                
                case 0:
                    Console.WriteLine("Fin del programa."); //No se desea realizar operaciones.
                    
                    break;
                
                case 1:

                    List<Asociado> asociados = new List<Asociado>(); //crea lista de tipo Asociado
                    asociados.Add(new Asociado() { DNI = 43368370, Nombre = "Agostina", Apellido = "Bertoni" });
                    asociados.Add(new Asociado() { DNI = 39613761, Nombre = "Florencia", Apellido = "Bertoni" });
                    asociados.Add(new Asociado() { DNI = 41658998, Nombre = "Lucas", Apellido = "Guzman" });

                    //Asociado.AltaAsociado();

                    Console.WriteLine("Si desea ver los datos que ingresó presione 1, en caso que no lo desee 0: ");
                    int imprimaDatosIngresados=int.Parse(Console.ReadLine());
                    
                    if (imprimaDatosIngresados == 1) {
                        //Asociado.MostrarAlta();
                    }else if (imprimaDatosIngresados==0){
                        Console.WriteLine("No desea ver los resultados");
                    }

                   break;
            }
        } 

    }
}

