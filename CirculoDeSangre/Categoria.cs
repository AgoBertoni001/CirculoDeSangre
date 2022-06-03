using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Categoria :Sangre
    {



        /*
        Activos: 18 - 56 años inclusive, sin enfermedades y medicamentos. Cuota: 100
        Pasivo: menores a 18, mayores a 56, enfermedades, y medicamentos. Cuota: 50 */





        public static List<Categoria> listaCategoria = new List<Categoria>()
        {
            new Categoria() {NombreCategoria="\t-Categoria: Pasivo",MontoCuota=50},
            new Categoria() {NombreCategoria="\t-Categoria: Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="\t-Categoria: Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="\t-Categoria: Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="\t-Categoria: Activo",MontoCuota=100},
        };





        public string NombreCategoria { get; set; } = String.Empty;
        public double MontoCuota { get; set; }



        public static void DeterminarCategoria(string nacimiento, string enfermedad, string medicamentos)
        {
            string categoria="";
            double montoCuota=0;

            TimeSpan DiferenciaDias = DateTime.Now.Subtract(DateTime.Parse(nacimiento)); //diferencia en dias (cuenta) desde el nacimiento y la fecha actual
            int edad = DiferenciaDias.Days / 365;
            Console.WriteLine(edad);

            if(enfermedad=="Si" || medicamentos=="Si")
            {
                categoria = "\t- Categoría: Pasivo";
                montoCuota = 50;
            }
            else if(edad>=18 && edad <= 56 && enfermedad == "No" && medicamentos == "No")
            {
                categoria = "\t- Categoría: Activo";
                montoCuota = 100;
            }

            listaCategoria.Add(new Categoria() { NombreCategoria = categoria, MontoCuota = montoCuota });


        }
    }
}
