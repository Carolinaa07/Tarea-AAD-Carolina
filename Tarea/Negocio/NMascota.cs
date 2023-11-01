using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class NMascota
    {

        private DMascota da = new DMascota();

        public DataTable listarMascotas()
        {
            return da.ListarMascotas();
        }
        public string MantenimientoM(EMascota mascota, int opcion)
        {
            return da.MantenimientoMascotitas(mascota, opcion);
        }
    }
}

