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

        /*public static int TerminosCondicionesVal(int terminosCondiciones)
        {
            while (!Regex.Match(terminosCondiciones, @"^\d{1}$").Success)
            {
                Console.Write("\tIngrese correctamente si acepta los terminos y condiciones (1- para Si - 2 para No): ");
                terminosCondiciones = int.Parse(Console.ReadLine());
            }

            return terminosCondiciones;
        }*/

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
            while (!Regex.Match(domicilio, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}\s[A-Za-z]{3,15}$").Success)
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
            while (!Regex.Match(localidad, @"^[A-Za-z]{3,15}$|^[A-Za-z]{3,15}\s[A-Za-z]{3,15}").Success)
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
                Console.Write("Ingrese correctamente si posee emfermedades: ");
                enfermedad = Console.ReadLine();
            }

            return enfermedad;
        }

        public static string MedicamentosVal(string medicamentos)
        {
            while (!Regex.Match(medicamentos, @"^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente si toma medicamentos: ");
                medicamentos = Console.ReadLine();
            }

            return medicamentos;
        }

        public static string GrupoSanguineoVal(string grupoSanguineo)
        {
            while (!Regex.Match(grupoSanguineo, @"^[A-Za-z]{1} | ^[A-Za-z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente su grupo Sanguineo (A - B - O - AB): ");
                grupoSanguineo = Console.ReadLine();
            }
            
            while (grupoSanguineo!="A" || grupoSanguineo != "B" || grupoSanguineo != "O" || grupoSanguineo != "AB")
            {
                Console.Write("Ingrese correctamente su grupo Sanguineo (A - B - O - AB): ");
                Console.ReadLine();
            }
            
            return grupoSanguineo;


        }

        public static string UltimaDonacionVal(string ultimaDonacion)
        {

            int dia, mes, ano;

            while (!Regex.Match(ultimaDonacion, @"^\d{2}\-\d{2}\-\d{4}$").Success)
            {
                Console.Write("Ingrese correctamente fecha de nacimiento: ");
                ultimaDonacion = Console.ReadLine();
            }
            char delimitador = '-';
            string[] fechaUltimaDonacion = ultimaDonacion.Split(delimitador);

            dia = Int32.Parse(fechaUltimaDonacion[0]);
            mes = Int32.Parse(fechaUltimaDonacion[1]);
            ano = Int32.Parse(fechaUltimaDonacion[2]);


            if (dia < 01 || dia > 31)
            {
                Console.Write("Error en día. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(fechaUltimaDonacion, 0, fechaUltimaDonacion.Length);
                ultimaDonacion = Console.ReadLine();
            }

            if (mes < 01 || mes > 12)
            {
                Console.Write("Error en mes. Ingrese correctamente (dd-mm-aaaa):  ");
                Array.Clear(fechaUltimaDonacion, 0, fechaUltimaDonacion.Length);
                ultimaDonacion = Console.ReadLine();
            }

            if (ano <= DateTime.Today.Year - 115 || ano > DateTime.Today.Year)
            {
                Console.Write("Error en año. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(fechaUltimaDonacion, 0, fechaUltimaDonacion.Length);
                ultimaDonacion = Console.ReadLine();
            }

            return ultimaDonacion;
        }

        
    }
}
