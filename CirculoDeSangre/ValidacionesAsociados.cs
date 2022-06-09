using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    internal class ValidacionesAsociados
    {

        public static string TerminosCondicionesVal(string terminosCondiciones)
        {
            while (!Regex.Match(terminosCondiciones, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si acepta los terminos y condiciones (Si - No)1: ");
                terminosCondiciones = Console.ReadLine();
            }
            while (terminosCondiciones != "Si" && terminosCondiciones != "No")
            {
                Console.Write("Ingrese correctamente si acepta los terminos y condiciones (Si - No)2: ");
                terminosCondiciones = Console.ReadLine();
            }

            return terminosCondiciones;
        }

        public static string DniVal(string dni)
        {
            while (!Regex.Match(dni, @"^\d{8}$").Success)
            {
                Console.Write("\tIngrese correctamente el dni: ");
                dni = Console.ReadLine();
            }

            return dni;
        }

        public static string NombreVal(string nombre)
        {
            while (!Regex.Match(nombre, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}").Success)
            {
                Console.Write("Ingrese correctamente el nombre: ");
                nombre = Console.ReadLine();
            }

            return nombre;
        }

        public static string ApellidoVal(string apellido)
        {
            while (!Regex.Match(apellido, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}").Success)
            {
                Console.Write("Ingrese correctamente el apellido: ");
                apellido = Console.ReadLine();
            }

            return apellido;
        }

        public static string NacimientoVal(string nacimiento)
        {

            int dia, mes, ano;

            while (!Regex.Match(nacimiento, @"^\d{2}\-\d{2}\-\d{4}$").Success)
            {
                Console.Write("Ingrese correctamente fecha de nacimiento: ");
                nacimiento = Console.ReadLine();
            }
            char delimitador = '-';
            string[] fechaNacimiento = nacimiento.Split(delimitador);

            dia = Int32.Parse(fechaNacimiento[0]);
            mes = Int32.Parse(fechaNacimiento[1]);
            ano = Int32.Parse(fechaNacimiento[2]);


            if (dia < 01 || dia > 31)
            {
                Console.Write("Error en día. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(fechaNacimiento, 0, fechaNacimiento.Length);
                nacimiento = Console.ReadLine();
            }

            if (mes < 01 || mes > 12)
            {
                Console.Write("Error en mes. Ingrese correctamente (dd-mm-aaaa):  ");
                Array.Clear(fechaNacimiento, 0, fechaNacimiento.Length);
                nacimiento = Console.ReadLine();
            }

            if (ano <= DateTime.Today.Year - 115 || ano > DateTime.Today.Year)
            {
                Console.Write("Error en año. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(fechaNacimiento, 0, fechaNacimiento.Length);
                nacimiento = Console.ReadLine();
            }

            return nacimiento;
        }

        public static string DomicilioVal(string domicilio)
        {
            while (!Regex.Match(domicilio, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}\s[A-Za-z]{3,15}$").Success)
            {
                Console.Write("Ingrese correctamente el domicilio: ");
                domicilio = Console.ReadLine();
            }

            return domicilio;
        }

        public static string AlturaDomicilioVal(string alturaDomicilio)
        {
            while (!Regex.Match(alturaDomicilio, @"^\d{1,5000}$").Success)
            {
                Console.Write("Ingrese correctamente altura del domicilio: ");
                alturaDomicilio = Console.ReadLine();
            }

            return alturaDomicilio;
        }

        public static string LocalidadVal(string localidad)
        {
            while (!Regex.Match(localidad, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}$").Success)
            {
                Console.Write("Ingrese correctamente el localidad: ");
                localidad = Console.ReadLine();
            }

            return localidad;
        }

        public static string TelefonoVal(string telefono)
        {
            while (!Regex.Match(telefono, @"^\d{8,15}$").Success)
            {
                Console.Write("Ingrese correctamente el telefono: ");
                telefono = Console.ReadLine();
            }

            return telefono;
        }

        public static string EmailVal(string email)
        {
            while (!Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                Console.Write("Ingrese correctamente el email: ");
                email = Console.ReadLine();
            }

            return email;
        }

        public static string EnfermedadVal(string enfermedad)
        {
            while (!Regex.Match(enfermedad, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si posee emfermedades (Si - No): ");
                enfermedad = Console.ReadLine();
            }
            while (enfermedad != "Si" && enfermedad != "No")
            {
                Console.Write("Ingrese correctamente si posee enfermedades (Si - No): ");
                enfermedad = Console.ReadLine();
            }
            return enfermedad;
        }

        public static string MedicamentosVal(string medicamentos)
        {
            while (!Regex.Match(medicamentos, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si toma medicamentos (Si - No): ");
                medicamentos = Console.ReadLine();
            }

            while (medicamentos != "Si" && medicamentos != "No")
            {
                Console.Write("Ingrese correctamente si toma medicamentos (Si - No): ");
                medicamentos = Console.ReadLine();
            }
            return medicamentos;
        }

        public static string GrupoSanguineoVal(string grupoSanguineo)
        {
            while (!Regex.Match(grupoSanguineo, @"^[A-Z]{1}$|^[A-Z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente su grupo Sanguineo (A - B - O - AB): ");
                grupoSanguineo = Console.ReadLine();
            }
            
            while (grupoSanguineo!="A" &&  grupoSanguineo != "B" && grupoSanguineo != "O" && grupoSanguineo != "AB")
            {
                Console.Write("Ingrese correctamente su grupo Sanguineo (A - B - O - AB): ");
                Console.ReadLine();
            }
            
            return grupoSanguineo;


        }

        public static string RegistroVal(string registro)
        {
            while (!Regex.Match(registro, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si desea gueardar el registro Alta (Si - No): ");
                registro = Console.ReadLine();
            }
            while(registro!="Si" && registro != "No")
            {
                Console.Write("Ingrese correctamente si desea gueardar el registro Alta (Si - No): ");
                registro = Console.ReadLine();
            }
            return registro;
        }

        public static string NuevaVal(string nueva)
        {
            while (!Regex.Match(nueva, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si desea generar otra Alta (Si - No): ");
                nueva = Console.ReadLine();
            }
            while (nueva != "Si" && nueva != "No")
            {
                Console.Write("Ingrese correctamente si desea generar otra Alta (Si - No): ");
                nueva = Console.ReadLine();
            }
            return nueva;
        }

        
    }
}
