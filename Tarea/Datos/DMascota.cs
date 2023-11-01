using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;

namespace Datos
{
    public class DMascota
    {

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        public DataTable ListarMascotas()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_mascotas", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string MantenimientoMascotitas(EMascota mascota, int opcion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_mantenimiento_mascotas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_", mascota.Id);
                cmd.Parameters.AddWithValue("@due_", mascota.NombreDueno);
                cmd.Parameters.AddWithValue("@tam_", mascota.Tamanio);
                cmd.Parameters.AddWithValue("@pes_", mascota.Peso);
                cmd.Parameters.AddWithValue("@fecha_", mascota.FechaNacimiento);
                cmd.Parameters.AddWithValue("@opcion", opcion);


                //comprobamos la conexión para ejecutar el query    
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //Ejecutamos el query 
                cmd.ExecuteNonQuery();
                con.Close();
                switch (opcion)
                {
                    case 1: return "Se agrego correctamente";
                    case 2: return "Se modifico corecctamente";
                    case 3: return "Se elimino correctamente";
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
