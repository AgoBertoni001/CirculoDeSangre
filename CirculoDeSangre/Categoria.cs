using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    public class Categoria : Sangre
    {



        /*
        Activos: 18 - 56 años inclusive, sin enfermedades y medicamentos. Cuota: 100
        Pasivo: menores a 18, mayores a 56, enfermedades, y medicamentos. Cuota: 50 */





        public static List<Categoria> listaCategoria = new List<Categoria>()
        {
            new Categoria() {NombreCategoria="Pasivo",MontoCuota=50},
            new Categoria() {NombreCategoria="Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="Activo",MontoCuota=100},
            new Categoria() {NombreCategoria="Activo",MontoCuota=100}
        }; 

        public string NombreCategoria { get; set; }
        public double MontoCuota { get; set; }



        public static void DeterminarCategoria(string nacimiento, string enfermedad, string medicamentos)
        {
            string categoria="";
            double montoCuota=0;

            TimeSpan DiferenciaDias = DateTime.Now.Subtract(DateTime.Parse(nacimiento)); //diferencia en dias (cuenta) desde el nacimiento y la fecha actual
            int edad = DiferenciaDias.Days / 365;
            

            enfermedad = enfermedad.ToUpper()[0] + enfermedad.Substring(1);
            medicamentos = medicamentos.ToUpper()[0] + medicamentos.Substring(1);

            if (enfermedad=="Si" || medicamentos=="Si")
            {
                categoria = "Pasivo";
                montoCuota = 50;
            }
            else if(edad>=18 && edad <= 56 && enfermedad == "No" && medicamentos == "No")
            {
                categoria = "Activo";
                montoCuota = 100;
            }

            listaCategoria.Add(new Categoria() { NombreCategoria = categoria, MontoCuota = montoCuota });


        }

        public override string ToString()
        {
            return String.Format($"\t- Catergoría: {NombreCategoria}");
        }
    }
}
