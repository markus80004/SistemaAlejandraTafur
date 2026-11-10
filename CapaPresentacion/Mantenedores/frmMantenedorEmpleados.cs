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
    public partial class frmMantenedorEmpleados : Form
    {
        // aqui guardo el id del empleado que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorEmpleados()
        {
            InitializeComponent();
            cargarCombos();
            listarEmpleado();
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
                cboPuesto.DisplayMember = "nombre";
                cboPuesto.ValueMember = "idPuesto";
                cboPuesto.DataSource = logPuesto.Instancia.ListarPuestoActivo();
                cboPuesto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        public void listarEmpleado()
        {
            try
            {
                llenarGrilla(logEmpleado.Instancia.ListarEmpleado());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entEmpleado> lista)
        {
            dgvEmpleados.Rows.Clear();
            foreach (entEmpleado x in lista)
            {
                int fila = dgvEmpleados.Rows.Add(x.dni,
                                       x.nombres + " " + x.apellidos,
                                       x.nombreArea,
                                       x.nombrePuesto,
                                       x.condicion,
                                       (x.estado == "Activo" ? "Act." : "Inh."));
                dgvEmpleados.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtDni.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaIngreso.Value = DateTime.Today;
            cboArea.SelectedIndex = -1;
            cboPuesto.SelectedIndex = -1;
            rdoFijo.Checked = true;
            numSueldoBase.Value = 0;
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtCuentaBancaria.Text = "";
            btnRegistrar.Enabled = true;
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        // revisa que los datos esten bien antes de guardar
        private Boolean validarCampos()
        {
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI");
                txtDni.Focus();
                return false;
            }
            if (txtNombres.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los nombres");
                txtNombres.Focus();
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los apellidos");
                txtApellidos.Focus();
                return false;
            }
            if (cboArea.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el area");
                cboArea.Focus();
                return false;
            }
            if (cboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el puesto");
                cboPuesto.Focus();
                return false;
            }
            string dni = txtDni.Text.Trim();
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener 8 digitos");
                txtDni.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim() != "" && !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo no es valido");
                txtCorreo.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entEmpleado armarEmpleado()
        {
            entEmpleado e = new entEmpleado();
            e.idEmpleado = idSeleccionado;
            e.dni = txtDni.Text.Trim();
            e.nombres = txtNombres.Text.Trim();
            e.apellidos = txtApellidos.Text.Trim();
            e.fechaIngreso = dtpFechaIngreso.Value.Date;
            e.idArea = Convert.ToInt32(cboArea.SelectedValue);
            e.idPuesto = Convert.ToInt32(cboPuesto.SelectedValue);
            e.condicion = rdoFijo.Checked ? "Fijo" : "Eventual";
            e.sueldoBase = numSueldoBase.Value;
            e.correo = txtCorreo.Text.Trim();
            e.telefono = txtTelefono.Text.Trim();
            e.cuentaBancaria = txtCuentaBancaria.Text.Trim();
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entEmpleado x = armarEmpleado();
                if (logEmpleado.Instancia.InsertaEmpleado(x))
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
            listarEmpleado();
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
                entEmpleado x = armarEmpleado();
                if (logEmpleado.Instancia.EditaEmpleado(x))
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
            listarEmpleado();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este empleado?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entEmpleado x = new entEmpleado();
                x.idEmpleado = idSeleccionado;
                logEmpleado.Instancia.DeshabilitarEmpleado(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarEmpleado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text.Trim();
                if (texto == "")
                {
                    listarEmpleado();
                }
                else
                {
                    llenarGrilla(logEmpleado.Instancia.BuscarEmpleado(texto));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entEmpleado x = (entEmpleado)dgvEmpleados.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idEmpleado;
            txtDni.Text = x.dni;
            txtNombres.Text = x.nombres;
            txtApellidos.Text = x.apellidos;
            dtpFechaIngreso.Value = x.fechaIngreso;
            cboArea.SelectedValue = x.idArea;
            cboPuesto.SelectedValue = x.idPuesto;
            rdoFijo.Checked = (x.condicion == "Fijo");
            rdoEventual.Checked = (x.condicion == "Eventual");
            numSueldoBase.Value = x.sueldoBase;
            txtCorreo.Text = x.correo;
            txtTelefono.Text = x.telefono;
            txtCuentaBancaria.Text = x.cuentaBancaria;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
