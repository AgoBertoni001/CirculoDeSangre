using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Asociado : Categoria
    {
        
        public static List<Asociado> listaAsociado = new List<Asociado>()
        {
            new Asociado() {DNI="39613161", Nombre = "Flor", Apellido="Bertoni", Nacimiento = "13-09-1996", Domicilio="Chubut", AlturaDomicilio="444", Localidad="Villa María",Telefono="3564 498698",Email="florBertoni@gmail.com",Enfermedad="Si",Medicamentos="Si", GrupoSanguineo="A"},
            new Asociado() {DNI="51689789", Nombre = "Marti", Apellido="Bertoni", Nacimiento = "14-07-2011", Domicilio="Figueroa Alcorta", AlturaDomicilio="248", Localidad="Seeber",Telefono="-",Email="martiBertoni@gmail.com",Enfermedad="No",Medicamentos="No", GrupoSanguineo="A"},
            new Asociado() {DNI="24126401", Nombre = "Javier", Apellido="Bertoni", Nacimiento = "18-12-1974", Domicilio="Figueroa Alcorta", AlturaDomicilio="248", Localidad="Seeber",Telefono="3564 535478",Email="Javier041@gmail.com",Enfermedad="No",Medicamentos="No", GrupoSanguineo="A"},
            new Asociado() {DNI="24598942", Nombre = "Mariel", Apellido="Coppiz", Nacimiento = "17-06-1976", Domicilio="Figueroa Alcorta", AlturaDomicilio="248", Localidad="Seeber",Telefono="3564 496698",Email="MarielC@gmail.com",Enfermedad="Si",Medicamentos="No",GrupoSanguineo="O"},
            new Asociado() {DNI="43368970", Nombre = "Ago", Apellido="Bertoni", Nacimiento = "04-04-2002", Domicilio="Cabrera", AlturaDomicilio="2950", Localidad="San Francisco",Telefono="3564 358386",Email="agobertoni01@gmail.com",Enfermedad="No",Medicamentos="No", GrupoSanguineo="A"},
        };

        //metodos
        public string DNI { get; set; } = String.Empty; 
        public string Nombre { get; set; } = String.Empty;
        public string Apellido { get; set; } = String.Empty;
        public string Nacimiento { get; set; } = String.Empty;
        public string Domicilio { get; set; } = String.Empty;
        public string AlturaDomicilio { get; set; } = String.Empty;
        public string Localidad { get; set; } = String.Empty;
        public string Telefono { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Enfermedad { get; set; } = String.Empty;
        public string Medicamentos { get; set; } = String.Empty;
        
        
        public static void AltaAsociado()
        {
            Console.Clear();
                       
            Console.WriteLine("\n");
            Console.WriteLine("Terminos y condiciones:  ... ");
            Console.Write("¿Se aceptan los terminos y condiciones? (Si - No): ");
            string terminosCondiciones = Console.ReadLine();
            terminosCondiciones = ValidacionesAsociados.TerminosCondicionesVal(terminosCondiciones);
                

            if (terminosCondiciones == "Si")
            {
                
                Console.WriteLine("Alta de Asociado nro: {0}",listaAsociado.Count()+1);

                Console.Write("\tDNI (sin espacios ni puntos): ");
                string dni = Console.ReadLine();
                dni=ValidacionesAsociados.DniVal(dni);

                Console.Write("\tNombre: ");
                string nombre = Console.ReadLine();
                nombre=ValidacionesAsociados.NombreVal(nombre);

                Console.Write("\tApellido: ");
                string apellido = Console.ReadLine();
                apellido=ValidacionesAsociados.ApellidoVal(apellido);

                Console.Write("\tFecha de nacimiento (dia mes año): ");
                string nacimiento = Console.ReadLine();
                nacimiento=ValidacionesAsociados.NacimientoVal(nacimiento);

                Console.Write("\tDomicilio (solo nombre, no altura): ");
                string domicilio = Console.ReadLine();
                domicilio=ValidacionesAsociados.DomicilioVal(domicilio);

                Console.Write("\tAltura del Domicilio: ");
                string alturaDomicilio = Console.ReadLine();
                alturaDomicilio = ValidacionesAsociados.AlturaDomicilioVal(alturaDomicilio);

                Console.Write("\tLocalidad: ");
                string localidad = Console.ReadLine();
                localidad = ValidacionesAsociados.LocalidadVal(localidad);

                Console.Write("\tTelefono: ");
                string telefono = Console.ReadLine();
                telefono = ValidacionesAsociados.TelefonoVal(telefono);

                Console.Write("\tEmail: ");
                string email = Console.ReadLine();
                email=ValidacionesAsociados.EmailVal(email);

                Console.Write("\tEnferemdad (Si o No): ");
                string enfermedad = Console.ReadLine();
                enfermedad = ValidacionesAsociados.EnfermedadVal(enfermedad);

                Console.Write("\tMedicamentos (Si o No): ");
                string medicamentos = Console.ReadLine();
                medicamentos = ValidacionesAsociados.MedicamentosVal(medicamentos);

                Console.Write("\tGrupo sanguineo (A - B - O - AB): ");
                string grupoSanguineo = Console.ReadLine();
                grupoSanguineo = ValidacionesAsociados.GrupoSanguineoVal(grupoSanguineo);

                Console.Write("Desea guardar este registro de Alta? (Si - No): ");
                string registro = Console.ReadLine();
                registro = ValidacionesAsociados.RegistroVal(registro);

                if  (registro == "Si")
                {
                    listaAsociado.Add ( new Asociado() { DNI = dni, Nombre = nombre, Apellido = apellido, Nacimiento = nacimiento, Domicilio = domicilio, AlturaDomicilio = alturaDomicilio, Localidad = localidad, Telefono = telefono, Email = email, Enfermedad = enfermedad, Medicamentos = medicamentos, GrupoSanguineo = grupoSanguineo });
                    Categoria.DeterminarCategoria(nacimiento, enfermedad, medicamentos);  
                }
                else 
                {
                    Console.WriteLine("No se ha registrado el Alta.");
                }
                                          
            }
            else
            {
                Console.WriteLine("No se aceptaron los terminos y condiciones. No se puede hacer el Alta.");
                Console.Clear();
                
            }

            Console.Write("Desea generar otra Alta? (Si - No): ");
            string nueva = Console.ReadLine();
            nueva = ValidacionesAsociados.NuevaVal(nueva);

            if (nueva == "Si")
            {
                AltaAsociado();
            }
            else
            {
                Program.Volver();
            }


        }

        public static void MostrarAlta()
        {
            for(int i = 0; i < listaAsociado.Count; i++)
            {
                Console.WriteLine(listaAsociado[i]);
                Console.WriteLine($"\t-Categoria: {listaCategoria[i].NombreCategoria}");
            }
        }

        public override string ToString()
        {
            return String.Format($"\n\n\tDatos del Asociado: \n\t-DNI: {DNI} \n\t-Nombre y Apellido: {Nombre.ToUpper()[0] + Nombre.Substring(1)} {Apellido.ToUpper()[0] + Apellido.Substring(1)} \n\t-Domicilio y Altura: {Domicilio.ToUpper()[0] + Domicilio.Substring(1)} {AlturaDomicilio} \n\t-Localidad: {Localidad.ToUpper()[0] + Localidad.Substring(1)} \n\t-Telefono: {Telefono} \n\t-Enfermedades: {Enfermedad.ToUpper()[0] + Enfermedad.Substring(1)}, y Medicamentos: {Medicamentos.ToUpper()[0] + Medicamentos.Substring(1)}");
        }

    }
}
