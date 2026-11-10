using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class frmMantenedorAreas : Form
    {
        // aqui guardo el id del area que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorAreas()
        {
            InitializeComponent();
            listarArea();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        public void listarArea()
        {
            try
            {
                llenarGrilla(logArea.Instancia.ListarArea());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entArea> lista)
        {
            dgvAreas.Rows.Clear();
            foreach (entArea x in lista)
            {
                int fila = dgvAreas.Rows.Add(x.idArea,
                                       x.nombre,
                                       x.descripcion,
                                       x.estado);
                dgvAreas.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del area");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entArea armarArea()
        {
            entArea e = new entArea();
            e.idArea = idSeleccionado;
            e.nombre = txtNombre.Text.Trim();
            e.descripcion = txtDescripcion.Text.Trim();
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entArea x = armarArea();
                if (logArea.Instancia.InsertaArea(x))
                {
                    MessageBox.Show("Se registro correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarArea();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //modificar
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            if (!validarCampos()) return;
            try
            {
                entArea x = armarArea();
                if (logArea.Instancia.EditaArea(x))
                {
                    MessageBox.Show("Se actualizo correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarArea();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este area?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entArea x = new entArea();
                x.idArea = idSeleccionado;
                logArea.Instancia.DeshabilitarArea(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarArea();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvAreas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entArea x = (entArea)dgvAreas.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idArea;
            txtNombre.Text = x.nombre;
            txtDescripcion.Text = x.descripcion;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
