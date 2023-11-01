using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Mantenimiento : Form
    {
        private NMascota nm;
        public Mantenimiento()
        {
            InitializeComponent();
            nm = new NMascota();
        }
        void mostrarMascotas()
        {
            dgvMantenimiento.DataSource = nm.listarMascotas();
        }
        private void Mantenimiento_Load_1(object sender, EventArgs e)
        {
            MostrarMascotas();
        }

        private void MostrarMascotas()
        {
            dgvMantenimiento.DataSource = nm.listarMascotas(); Limpiar();
        }
        private void Limpiar()
        {
            tbCodigo.Clear();
            tbDueno.Clear();
            tbPeso.Clear();
            tbTamanio.Clear();
            dtpFechaNacimiento.Value=DateTime.Now;

        }

        private void dgvMantenimiento_SelectionChanged(object sender, EventArgs e)
        {
            tbCodigo.Text = dgvMantenimiento.CurrentRow.Cells[0].Value.ToString();
            tbDueno.Text = dgvMantenimiento.CurrentRow.Cells[1].Value.ToString();
            tbTamanio.Text = dgvMantenimiento.CurrentRow.Cells[2].Value.ToString();
            tbPeso.Text = dgvMantenimiento.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNacimiento.Text = dgvMantenimiento.CurrentRow.Cells[4].Value.ToString();
        }
        private void Mantenimientos(int opcion)
        {
            EMascota mascota = new EMascota();
            mascota.Id = Convert.ToInt16(tbCodigo.Text);
            mascota.NombreDueno = tbDueno.Text;
            mascota.Tamanio =Convert.ToDouble (tbTamanio.Text);
            mascota.Peso = Convert.ToDouble(tbPeso.Text);
            mascota.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Text);

            MessageBox.Show(nm.MantenimientoM(mascota, opcion));
            MostrarMascotas();
            Limpiar();
        }

        private void bnAgregar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "" && tbDueno.Text != "" && tbTamanio.Text != "" && tbPeso.Text != "" )
                Mantenimientos(1);
            else
                MessageBox.Show("Debe llenar todos los campos");
        }

        private void bnModificar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "" && tbDueno.Text != "" && tbTamanio.Text != "" && tbPeso.Text != "")
                Mantenimientos(2);
            else
                MessageBox.Show("El campos debene estar correctamente seleccionado");
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text != "" && tbDueno.Text != "" && tbTamanio.Text != "" && tbPeso.Text != "" )
                Mantenimientos(3);
            else
                MessageBox.Show("El campos debene estar correctamente seleccionado");
        }

      
    }
}   
