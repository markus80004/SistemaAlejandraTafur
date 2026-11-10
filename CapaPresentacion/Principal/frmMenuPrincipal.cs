using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmMantenedorEmpleados frm = new frmMantenedorEmpleados();
            frm.ShowDialog();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            frmMantenedorAreas frm = new frmMantenedorAreas();
            frm.ShowDialog();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            frmMantenedorContratos frm = new frmMantenedorContratos();
            frm.ShowDialog();
        }

        private void btnTiposTurno_Click(object sender, EventArgs e)
        {
            frmMantenedorTiposTurno frm = new frmMantenedorTiposTurno();
            frm.ShowDialog();
        }

        private void btnTipoAusencia_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoAusencia frm = new frmMantenedorTipoAusencia();
            frm.ShowDialog();
        }

        private void btnPuestosTrabajo_Click(object sender, EventArgs e)
        {
            frmMantenedorPuestosTrabajo frm = new frmMantenedorPuestosTrabajo();
            frm.ShowDialog();
        }

        private void btnConceptoBonoDescuento_Click(object sender, EventArgs e)
        {
            frmMantenedorConceptoBonoDescuento frm = new frmMantenedorConceptoBonoDescuento();
            frm.ShowDialog();
        }

        private void btnTipoDesvinculacion_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoDesvinculacion frm = new frmMantenedorTipoDesvinculacion();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
