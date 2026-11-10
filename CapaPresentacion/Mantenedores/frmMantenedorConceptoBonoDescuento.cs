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
    public partial class frmMantenedorConceptoBonoDescuento : Form
    {
        // aqui guardo el id del concepto que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorConceptoBonoDescuento()
        {
            InitializeComponent();
            listarConcepto();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        public void listarConcepto()
        {
            try
            {
                llenarGrilla(logConcepto.Instancia.ListarConcepto());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entConcepto> lista)
        {
            dgvConceptoBonoDescuento.Rows.Clear();
            foreach (entConcepto x in lista)
            {
                int fila = dgvConceptoBonoDescuento.Rows.Add(x.idConcepto,
                                       x.nombre,
                                       x.tipoConcepto,
                                       x.unidad.StartsWith("Porcentaje") ? x.valor.ToString("0.##") + " %" : "S/ " + x.valor.ToString("0.00"),
                                       (x.estado == "Activo" ? "Act." : "Inh."));
                dgvConceptoBonoDescuento.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtNombre.Text = "";
            rdoBono.Checked = true;
            numValor.Value = 0;
            cboUnidad.SelectedIndex = -1;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del concepto");
                txtNombre.Focus();
                return false;
            }
            if (cboUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la unidad");
                cboUnidad.Focus();
                return false;
            }
            if (numValor.Value <= 0)
            {
                MessageBox.Show("Ingrese el valor");
                numValor.Focus();
                return false;
            }
            if (cboUnidad.SelectedItem.ToString().StartsWith("Porcentaje") && numValor.Value > 100)
            {
                MessageBox.Show("El porcentaje no puede ser mayor a 100");
                numValor.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entConcepto armarConcepto()
        {
            entConcepto e = new entConcepto();
            e.idConcepto = idSeleccionado;
            e.nombre = txtNombre.Text.Trim();
            e.tipoConcepto = rdoBono.Checked ? "Bono" : "Descuento";
            e.valor = numValor.Value;
            e.unidad = cboUnidad.SelectedItem.ToString();
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entConcepto x = armarConcepto();
                if (logConcepto.Instancia.InsertaConcepto(x))
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
            listarConcepto();
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
                entConcepto x = armarConcepto();
                if (logConcepto.Instancia.EditaConcepto(x))
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
            listarConcepto();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este concepto?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entConcepto x = new entConcepto();
                x.idConcepto = idSeleccionado;
                logConcepto.Instancia.DeshabilitarConcepto(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarConcepto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvConceptoBonoDescuento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entConcepto x = (entConcepto)dgvConceptoBonoDescuento.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idConcepto;
            txtNombre.Text = x.nombre;
            rdoBono.Checked = (x.tipoConcepto == "Bono");
            rdoDescuento.Checked = (x.tipoConcepto == "Descuento");
            numValor.Value = x.valor;
            cboUnidad.SelectedItem = x.unidad;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
