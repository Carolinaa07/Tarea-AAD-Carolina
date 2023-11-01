using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class EMascota
    {
        public int Id { get; set; }
        public string NombreDueno { get; set; }
        public double Tamanio { get; set; }
        public double Peso { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
