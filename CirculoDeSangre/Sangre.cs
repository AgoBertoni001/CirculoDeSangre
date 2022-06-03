using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    
    public class Sangre:Donacion
    {

        public static List<Sangre> listaGrupoSanguineo = new List<Sangre>()
        {
            new Sangre() {GrupoSanguineo="\t-: A"},
            new Sangre() {GrupoSanguineo="\t-: A"},
            new Sangre() {GrupoSanguineo="\t-: A"},
            new Sangre() {GrupoSanguineo="\t-: O"},
            new Sangre() {GrupoSanguineo="\t-: A"},
        };

        public new string GrupoSanguineo { get; set; }
    }

}
