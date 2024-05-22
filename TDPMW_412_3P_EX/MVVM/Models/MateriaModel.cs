using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PropertyChanged;
using System.Threading.Tasks;

namespace TDPMW_412_3P_EX.MVVM.Models
{
    public class MateriaModel
    {
        public string materia { get; set; }
        public string rubro1 { get; set; }
        public string rubro2 { get; set; }
        public string rubro3 { get; set; }
        public double porcentaje1 { get; set; }
        public double porcentaje2 { get; set; }
        public double porcentaje3 { get; set; }
        public double calificacion1 { get; set; }
        public double calificacion2 { get; set; }
        public double calificacion3 { get; set; }
        
        public MateriaModel() { }
    }
}
