using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Asociado : IEquatable<Asociado>
    {
               
        //metodo de atributos
        public long DNI { get; set; } //mejor si es string
        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public string Nacimiento { get; set; } = String.Empty;
        public string Domicilio { get; set; } = String.Empty;
        public long AlturaDomicilio { get; set; } 
        public string Localidad { get; set; } = String.Empty;
        public long Telefono { get; set; } 
        public string Email { get; set; } = String.Empty;
        public bool Enfermedad { get; set; }
        public bool Medicamentos { get; set; }

        /*
        //metodo de constructor parametrizado
        public Asociado (long DNI, string Nombre, string Apellido, string Nacimiento, string Domicilio, long AlturaDomicilio, string Localidad, long Telefono, string Email, bool Enfermedad, bool Medicamentos)
        {
            
            this.DNI = DNI;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nacimiento = Nacimiento;
            this.Domicilio = Domicilio;
            this.AlturaDomicilio = AlturaDomicilio;
            this.Localidad = Localidad;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Enfermedad = Enfermedad;
            this.Medicamentos = Medicamentos;
       
        } 
        
        public void presentarme()
        {
            Console.WriteLine("Vista rápida de datos ingresados: ");
            Console.WriteLine("Mi DNI es: {0}", DNI);
            Console.WriteLine("Mi nombre y apellido es " + Nombre + Apellido);
            Console.WriteLine("Domicilio " + Domicilio + "altura " + AlturaDomicilio);
            Console.WriteLine("Localidad {0}", Localidad);
            Console.WriteLine("Telefono: " + Telefono + "Email: " + Email);
            Console.WriteLine("Enfermedades y medicamentos {0}, {1} respectivamente", Enfermedad, Medicamentos);
        }
        */

        public override string ToString()
        {
            return "DNI: " + DNI + " Nombre y Apellido: " + Nombre + Apellido+ " Domicilio " + Domicilio + " Altura " + AlturaDomicilio + " Localidad: " + Localidad + 
                " \nTelefono: " + Telefono + " Enfermedades y Medicamentos: " + Enfermedad + Medicamentos;
        }

        public override bool Equals(object obj)
        {
            /*if (obj == null) return false;
            Asociado objAsAsociado = obj as Asociado;
            if (objAsAsociado == null) return false;
            else return Equals(objAsAsociado);*/
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            //return DNI.GetHashCode() ^ Nombre.GetHashCode() ^ Apellido.GetHashCode();
            return base.GetHashCode();
        }

        public bool Equals(Asociado other)
        {
            if (other == null) return false;
            return (this.DNI.Equals(other.DNI));
        }


        




/*
        public static void AltaAsociado()
        {
            
            Console.Write("DNI (sin espacios ni puntos): ");
            long dni = long.Parse(Console.ReadLine());
            
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
           
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            
            Console.Write("Fecha de nacimiento (dia mes año): ");
            string nacimiento = Console.ReadLine();
            
            Console.Write("Domicilio (solo nombre, no altura): ");
            string domicilio = Console.ReadLine();
            
            Console.Write("Altura del Domicilio: ");
            long alturaDomicilio = long.Parse(Console.ReadLine());
            
            Console.Write("Localidad: ");
            string localidad = Console.ReadLine();
            
            Console.Write("Telefono: ");
            long telefono = long.Parse(Console.ReadLine());
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Enferemdad (1-para Si, 2-para No): ");
            int enfermedad = int.Parse(Console.ReadLine());
                        
            Console.Write("Medicamentos (1-para Si, 2-para No): ");
            int medicamentos = int.Parse(Console.ReadLine());
           
            
            //GUARDAR TODO EN UNA LISTA
        }


        public static void MostrarAlta()
        {
            //mostrar LISTA
            Console.WriteLine("Hola :)");

        }
*/

    }
}
