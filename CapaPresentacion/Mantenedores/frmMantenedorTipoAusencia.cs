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
    public partial class frmMantenedorTipoAusencia : Form
    {
        // aqui guardo el id del tipo de ausencia que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorTipoAusencia()
        {
            InitializeComponent();
            listarTipoAusencia();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        public void listarTipoAusencia()
        {
            try
            {
                llenarGrilla(logTipoAusencia.Instancia.ListarTipoAusencia());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entTipoAusencia> lista)
        {
            dgvTipoAusencia.Rows.Clear();
            foreach (entTipoAusencia x in lista)
            {
                int fila = dgvTipoAusencia.Rows.Add(x.idTipoAusencia,
                                       x.nombre,
                                       x.descripcion,
                                       (x.requiereDocumento ? "Sí" : "No"));
                dgvTipoAusencia.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkRequiereDocumento.Checked = false;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entTipoAusencia armarTipoAusencia()
        {
            entTipoAusencia e = new entTipoAusencia();
            e.idTipoAusencia = idSeleccionado;
            e.nombre = txtNombre.Text.Trim();
            e.descripcion = txtDescripcion.Text.Trim();
            e.requiereDocumento = chkRequiereDocumento.Checked;
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entTipoAusencia x = armarTipoAusencia();
                if (logTipoAusencia.Instancia.InsertaTipoAusencia(x))
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
            listarTipoAusencia();
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
                entTipoAusencia x = armarTipoAusencia();
                if (logTipoAusencia.Instancia.EditaTipoAusencia(x))
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
            listarTipoAusencia();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este tipo de ausencia?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entTipoAusencia x = new entTipoAusencia();
                x.idTipoAusencia = idSeleccionado;
                logTipoAusencia.Instancia.DeshabilitarTipoAusencia(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarTipoAusencia();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvTipoAusencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entTipoAusencia x = (entTipoAusencia)dgvTipoAusencia.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idTipoAusencia;
            txtNombre.Text = x.nombre;
            txtDescripcion.Text = x.descripcion;
            chkRequiereDocumento.Checked = x.requiereDocumento;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
