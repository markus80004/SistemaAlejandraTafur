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
    public partial class frmMantenedorContratos : Form
    {
        // aqui guardo el id del contrato que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorContratos()
        {
            InitializeComponent();
            cargarCombos();
            listarContrato();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // llena los combos
        public void cargarCombos()
        {
            try
            {
                cboEmpleado.DisplayMember = "nombreCompleto";
                cboEmpleado.ValueMember = "idEmpleado";
                cboEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleadoActivo();
                cboEmpleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        public void listarContrato()
        {
            try
            {
                llenarGrilla(logContrato.Instancia.ListarContrato());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entContrato> lista)
        {
            dgvContratos.Rows.Clear();
            foreach (entContrato x in lista)
            {
                int fila = dgvContratos.Rows.Add(x.idContrato,
                                       x.nombreEmpleado,
                                       x.tipoContrato,
                                       x.fechaInicio.ToString("dd/MM/yyyy"),
                                       x.fechaFin.HasValue ? x.fechaFin.Value.ToString("dd/MM/yyyy") : "",
                                       x.horasSemanales);
                dgvContratos.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            cboEmpleado.SelectedIndex = -1;
            cboTipoContrato.SelectedIndex = -1;
            numHorasSemanales.Value = 48;
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Checked = false;
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el empleado");
                cboEmpleado.Focus();
                return false;
            }
            if (cboTipoContrato.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de contrato");
                cboTipoContrato.Focus();
                return false;
            }
            if (numHorasSemanales.Value <= 0)
            {
                MessageBox.Show("Ingrese las horas semanales");
                numHorasSemanales.Focus();
                return false;
            }
            if (dtpFechaFin.Checked && dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date)
            {
                MessageBox.Show("La fecha de fin no puede ser menor a la fecha de inicio");
                dtpFechaFin.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entContrato armarContrato()
        {
            entContrato e = new entContrato();
            e.idContrato = idSeleccionado;
            e.idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);
            e.tipoContrato = cboTipoContrato.SelectedItem.ToString();
            e.horasSemanales = Convert.ToInt32(numHorasSemanales.Value);
            e.fechaInicio = dtpFechaInicio.Value.Date;
            if (dtpFechaFin.Checked)
            {
                e.fechaFin = dtpFechaFin.Value.Date;
            }
            else
            {
                e.fechaFin = null;
            }
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entContrato x = armarContrato();
                if (logContrato.Instancia.InsertaContrato(x))
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
            listarContrato();
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
                entContrato x = armarContrato();
                if (logContrato.Instancia.EditaContrato(x))
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
            listarContrato();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este contrato?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entContrato x = new entContrato();
                x.idContrato = idSeleccionado;
                logContrato.Instancia.DeshabilitarContrato(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarContrato();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entContrato x = (entContrato)dgvContratos.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idContrato;
            cboEmpleado.SelectedValue = x.idEmpleado;
            cboTipoContrato.SelectedItem = x.tipoContrato;
            numHorasSemanales.Value = x.horasSemanales;
            dtpFechaInicio.Value = x.fechaInicio;
            if (x.fechaFin.HasValue)
            {
                dtpFechaFin.Value = x.fechaFin.Value;
                dtpFechaFin.Checked = true;
            }
            else
            {
                dtpFechaFin.Checked = false;
            }
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
