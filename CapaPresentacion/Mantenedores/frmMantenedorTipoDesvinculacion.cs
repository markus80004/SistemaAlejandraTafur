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
    public partial class frmMantenedorTipoDesvinculacion : Form
    {
        // aqui guardo el id del tipo de desvinculacion que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorTipoDesvinculacion()
        {
            InitializeComponent();
            listarTipoDesvinculacion();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        public void listarTipoDesvinculacion()
        {
            try
            {
                llenarGrilla(logTipoDesvinculacion.Instancia.ListarTipoDesvinculacion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entTipoDesvinculacion> lista)
        {
            dgvTipoDesvinculacion.Rows.Clear();
            foreach (entTipoDesvinculacion x in lista)
            {
                int fila = dgvTipoDesvinculacion.Rows.Add(x.codigo,
                                       x.nombre,
                                       (x.requiereCartaRenuncia ? "Sí" : "No"),
                                       (x.requiereAprobacionSubgerencia ? "Sí" : "No"),
                                       (x.estado == "Activo" ? "Act." : "Inh."));
                dgvTipoDesvinculacion.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkRequiereCarta.Checked = false;
            chkRequiereSubgerencia.Checked = false;
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
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        // arma el objeto con los datos del formulario
        private entTipoDesvinculacion armarTipoDesvinculacion()
        {
            entTipoDesvinculacion e = new entTipoDesvinculacion();
            e.idTipoDesvinculacion = idSeleccionado;
            e.codigo = txtCodigo.Text.Trim();
            e.nombre = txtNombre.Text.Trim();
            e.descripcion = txtDescripcion.Text.Trim();
            e.requiereCartaRenuncia = chkRequiereCarta.Checked;
            e.requiereAprobacionSubgerencia = chkRequiereSubgerencia.Checked;
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entTipoDesvinculacion x = armarTipoDesvinculacion();
                if (logTipoDesvinculacion.Instancia.InsertaTipoDesvinculacion(x))
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
            listarTipoDesvinculacion();
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
                entTipoDesvinculacion x = armarTipoDesvinculacion();
                if (logTipoDesvinculacion.Instancia.EditaTipoDesvinculacion(x))
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
            listarTipoDesvinculacion();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este tipo de desvinculacion?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entTipoDesvinculacion x = new entTipoDesvinculacion();
                x.idTipoDesvinculacion = idSeleccionado;
                logTipoDesvinculacion.Instancia.DeshabilitarTipoDesvinculacion(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarTipoDesvinculacion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvTipoDesvinculacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entTipoDesvinculacion x = (entTipoDesvinculacion)dgvTipoDesvinculacion.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idTipoDesvinculacion;
            txtCodigo.Text = x.codigo;
            txtNombre.Text = x.nombre;
            txtDescripcion.Text = x.descripcion;
            chkRequiereCarta.Checked = x.requiereCartaRenuncia;
            chkRequiereSubgerencia.Checked = x.requiereAprobacionSubgerencia;
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }
    }
}
