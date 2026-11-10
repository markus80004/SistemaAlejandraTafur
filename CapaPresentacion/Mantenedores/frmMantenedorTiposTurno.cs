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
    public partial class frmMantenedorTiposTurno : Form
    {
        // aqui guardo el id del tipo de turno que selecciono en la grilla
        private int idSeleccionado = 0;

        public frmMantenedorTiposTurno()
        {
            InitializeComponent();
            listarTipoTurno();
            actualizarDuracion();
            btnActualizar.Enabled = false;
            btnInhabilitar.Enabled = false;
        }

        public void listarTipoTurno()
        {
            try
            {
                llenarGrilla(logTipoTurno.Instancia.ListarTipoTurno());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }

        // muestra la lista en el dgv
        private void llenarGrilla(List<entTipoTurno> lista)
        {
            dgvTiposTurno.Rows.Clear();
            foreach (entTipoTurno x in lista)
            {
                int fila = dgvTiposTurno.Rows.Add(x.codigo,
                                       x.nombre,
                                       x.horaEntrada.ToString(@"hh\:mm"),
                                       x.horaSalida.ToString(@"hh\:mm"),
                                       x.duracionHoras.ToString("0.##") + " hrs",
                                       (x.estado == "Activo" ? "Act." : "Inh."));
                dgvTiposTurno.Rows[fila].Tag = x; // guardo el objeto completo en la fila
            }
        }

        private void LimpiarVariables()
        {
            idSeleccionado = 0;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            dtpHoraEntrada.Value = DateTime.Today;
            dtpHoraSalida.Value = DateTime.Today;
            actualizarDuracion();
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
        private entTipoTurno armarTipoTurno()
        {
            entTipoTurno e = new entTipoTurno();
            e.idTipoTurno = idSeleccionado;
            e.codigo = txtCodigo.Text.Trim();
            e.nombre = txtNombre.Text.Trim();
            e.horaEntrada = new TimeSpan(dtpHoraEntrada.Value.Hour, dtpHoraEntrada.Value.Minute, 0);
            e.horaSalida = new TimeSpan(dtpHoraSalida.Value.Hour, dtpHoraSalida.Value.Minute, 0);
            e.duracionHoras = calcularDuracion();
            return e;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            if (!validarCampos()) return;
            try
            {
                entTipoTurno x = armarTipoTurno();
                if (logTipoTurno.Instancia.InsertaTipoTurno(x))
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
            listarTipoTurno();
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
                entTipoTurno x = armarTipoTurno();
                if (logTipoTurno.Instancia.EditaTipoTurno(x))
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
            listarTipoTurno();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic)");
                return;
            }
            DialogResult r = MessageBox.Show("¿Desea inhabilitar este tipo de turno?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;
            try
            {
                entTipoTurno x = new entTipoTurno();
                x.idTipoTurno = idSeleccionado;
                logTipoTurno.Instancia.DeshabilitarTipoTurno(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
                return;
            }
            LimpiarVariables();
            listarTipoTurno();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void dgvTiposTurno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            entTipoTurno x = (entTipoTurno)dgvTiposTurno.Rows[e.RowIndex].Tag; //
            idSeleccionado = x.idTipoTurno;
            txtCodigo.Text = x.codigo;
            txtNombre.Text = x.nombre;
            dtpHoraEntrada.Value = DateTime.Today.Add(x.horaEntrada);
            dtpHoraSalida.Value = DateTime.Today.Add(x.horaSalida);
            actualizarDuracion();
            btnRegistrar.Enabled = false;
            btnActualizar.Enabled = true;
            btnInhabilitar.Enabled = (x.estado == "Activo");
        }

        // calcula las horas entre la entrada y la salida
        private decimal calcularDuracion()
        {
            TimeSpan entrada = new TimeSpan(dtpHoraEntrada.Value.Hour, dtpHoraEntrada.Value.Minute, 0);
            TimeSpan salida = new TimeSpan(dtpHoraSalida.Value.Hour, dtpHoraSalida.Value.Minute, 0);
            // si la salida es menor o igual, el turno termina al dia siguiente
            if (salida <= entrada)
            {
                salida = salida.Add(new TimeSpan(24, 0, 0));
            }
            return Math.Round(Convert.ToDecimal((salida - entrada).TotalHours), 2);
        }

        private void actualizarDuracion()
        {
            txtDuracion.Text = calcularDuracion().ToString("0.00") + " horas";
        }

        private void dtpHoraEntrada_ValueChanged(object sender, EventArgs e)
        {
            actualizarDuracion();
        }

        private void dtpHoraSalida_ValueChanged(object sender, EventArgs e)
        {
            actualizarDuracion();
        }
    }
}
