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
    public partial class frmMantenedorPuestosTrabajo : Form
    {
        // aqui guardo el id del puesto de trabajo que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorPuestosTrabajo()
        {
            InitializeComponent();
            cargarCombos();
            listarPuesto();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // llena los combos
        public void cargarCombos()
        {
            try
            {
                cboArea.DisplayMember = "nombre";
                cboArea.ValueMember = "idArea";
                cboArea.DataSource = logArea.Instancia.ListarAreaActivo();
                cboArea.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        public void listarPuesto()
        {
            try
            {
                llenarGrilla(logPuesto.Instancia.ListarPuesto());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entPuesto> lista)
        {
            dgvPuestosTrabajo.Rows.Clear();
            foreach (entPuesto x in lista)
            {
                int fila = dgvPuestosTrabajo.Rows.Add(x.codigo,
                                       x.nombre,
                                       x.nombreArea,
                                       "S/ " + x.tarifaSueldo.ToString("0.00"),
                                       (x.estado == "Activo" ? "Act." : "Inh."));
                dgvPuestosTrabajo.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cboArea.SelectedIndex = -1;
            numTarifa.Value = 0;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el codigo");
                txtCodigo.Focus();
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del puesto");
                txtNombre.Focus();
                return false;
            }
            if (cboArea.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el area");
                cboArea.Focus();
                return false;
            }
            if (numTarifa.Value <= 0)
            {
                MessageBox.Show("Ingrese la tarifa o sueldo");
                numTarifa.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entPuesto armarPuesto()
        {
            entPuesto e = new entPuesto();
            e.idPuesto = idSeleccionado;
            e.codigo = txtCodigo.Text.Trim();
            e.nombre = txtNombre.Text.Trim();
            e.idArea = Convert.ToInt32(cboArea.SelectedValue);
            e.tarifaSueldo = numTarifa.Value;
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entPuesto x = armarPuesto();
                if (logPuesto.Instancia.InsertaPuesto(x))
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
            listarPuesto();
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
                entPuesto x = armarPuesto();
                if (logPuesto.Instancia.EditaPuesto(x))
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
            listarPuesto();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este puesto de trabajo?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entPuesto x = new entPuesto();
                x.idPuesto = idSeleccionado;
                logPuesto.Instancia.DeshabilitarPuesto(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarPuesto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvPuestosTrabajo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entPuesto x = (entPuesto)dgvPuestosTrabajo.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idPuesto;
            txtCodigo.Text = x.codigo;
            txtNombre.Text = x.nombre;
            cboArea.SelectedValue = x.idArea;
            numTarifa.Value = x.tarifaSueldo;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
