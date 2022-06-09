using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    internal class ValidacionesPeticion
    {
        public static string GrupoSanguineoVal(string grupoSanguineo)
        {
            while (!Regex.Match(grupoSanguineo, @"^[A-Z]{1}$|^[A-Z]{2}$").Success)
            {
                Console.Write("Ingrese correctamente el Grupo Sanguineo (A-B-O-AB): ");
                grupoSanguineo = Console.ReadLine();
            }

            return grupoSanguineo;
        }

        public static string CantidadDonantesVal (string cantDonantes)
        {
            while (!Regex.Match(cantDonantes, @"^\d{1,100}$").Success)
            {
                Console.Write("Ingrese correctamente cantidad de donantes: ");
                cantDonantes = Console.ReadLine();
            }

            return cantDonantes;
        }

        public static string FechaLimiteVal(string fechaLimite)
        {
            int dia, mes, ano;

            while (!Regex.Match(fechaLimite, @"^\d{2}\-\d{2}\-\d{4}$").Success)
            {
                Console.Write("Ingrese correctamente fecha Limite: ");
                fechaLimite = Console.ReadLine();
            }
            char delimitador = '-';
            string[] limiteFecha = fechaLimite.Split(delimitador);

            dia = Int32.Parse(limiteFecha[0]);
            mes = Int32.Parse(limiteFecha[1]);
            ano = Int32.Parse(limiteFecha[2]);


            if (dia < 01 || dia > 31)
            {
                Console.Write("Error en día. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(limiteFecha, 0, limiteFecha.Length);
                fechaLimite = Console.ReadLine();
            }

            if (mes < 01 || mes > 12)
            {
                Console.Write("Error en mes. Ingrese correctamente (dd-mm-aaaa):  ");
                Array.Clear(limiteFecha, 0, limiteFecha.Length);
                fechaLimite = Console.ReadLine();
            }

            if (ano < DateTime.Today.Year || ano > DateTime.Today.Year)
            {
                Console.Write("Error en año. Ingrese correctamente (dd-mm-aaaa): ");
                Array.Clear(limiteFecha, 0, limiteFecha.Length);
                fechaLimite = Console.ReadLine();
            }
            return fechaLimite;
        }
    }



}
