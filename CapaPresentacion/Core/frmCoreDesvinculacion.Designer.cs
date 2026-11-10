namespace CapaPresentacion
{
    partial class frmCoreDesvinculacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gbSolicitud = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.rdoRenuncia = new System.Windows.Forms.RadioButton();
            this.rdoDespido = new System.Windows.Forms.RadioButton();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrarSolicitud = new System.Windows.Forms.Button();
            this.lblMotivoAnulacion = new System.Windows.Forms.Label();
            this.txtMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.gbRenuncia = new System.Windows.Forms.GroupBox();
            this.lblCodCarta = new System.Windows.Forms.Label();
            this.txtCodCarta = new System.Windows.Forms.TextBox();
            this.lblFechaPres = new System.Windows.Forms.Label();
            this.dtpFechaPres = new System.Windows.Forms.DateTimePicker();
            this.lblDocAdjunto = new System.Windows.Forms.Label();
            this.txtDocAdjunto = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnArchivarCarta = new System.Windows.Forms.Button();
            this.gbDespido = new System.Windows.Forms.GroupBox();
            this.lblAntecedentes = new System.Windows.Forms.Label();
            this.txtAntecedentes = new System.Windows.Forms.TextBox();
            this.lblVeredicto = new System.Windows.Forms.Label();
            this.rdoAprobada = new System.Windows.Forms.RadioButton();
            this.rdoRechazada = new System.Windows.Forms.RadioButton();
            this.lblFechaEval = new System.Windows.Forms.Label();
            this.dtpFechaEval = new System.Windows.Forms.DateTimePicker();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarVeredicto = new System.Windows.Forms.Button();
            this.gbSolicitud.SuspendLayout();
            this.gbRenuncia.SuspendLayout();
            this.gbDespido.SuspendLayout();
            this.SuspendLayout();
            //
            // gbSolicitud
            //
            this.gbSolicitud.Controls.Add(this.lblCodigo);
            this.gbSolicitud.Controls.Add(this.txtCodigo);
            this.gbSolicitud.Controls.Add(this.lblFecha);
            this.gbSolicitud.Controls.Add(this.dtpFecha);
            this.gbSolicitud.Controls.Add(this.lblEmpleado);
            this.gbSolicitud.Controls.Add(this.cboEmpleado);
            this.gbSolicitud.Controls.Add(this.lblSolicitante);
            this.gbSolicitud.Controls.Add(this.txtSolicitante);
            this.gbSolicitud.Controls.Add(this.lblModalidad);
            this.gbSolicitud.Controls.Add(this.rdoRenuncia);
            this.gbSolicitud.Controls.Add(this.rdoDespido);
            this.gbSolicitud.Controls.Add(this.lblMotivo);
            this.gbSolicitud.Controls.Add(this.txtMotivo);
            this.gbSolicitud.Controls.Add(this.btnRegistrarSolicitud);
            this.gbSolicitud.Controls.Add(this.lblMotivoAnulacion);
            this.gbSolicitud.Controls.Add(this.txtMotivoAnulacion);
            this.gbSolicitud.Controls.Add(this.btnAnular);
            this.gbSolicitud.Location = new System.Drawing.Point(12, 12);
            this.gbSolicitud.Name = "gbSolicitud";
            this.gbSolicitud.Size = new System.Drawing.Size(776, 215);
            this.gbSolicitud.TabIndex = 0;
            this.gbSolicitud.TabStop = false;
            this.gbSolicitud.Text = "Registro de Solicitud de Desvinculación (Director RRHH)";
            //
            // lblCodigo
            //
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(80, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(130, 23);
            this.txtCodigo.TabIndex = 2;
            //
            // lblFecha
            //
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(300, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            //
            // dtpFecha
            //
            this.dtpFecha.Location = new System.Drawing.Point(350, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Size = new System.Drawing.Size(140, 23);
            this.dtpFecha.TabIndex = 4;
            //
            // lblEmpleado
            //
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 69);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Empleado:";
            //
            // cboEmpleado
            //
            this.cboEmpleado.Location = new System.Drawing.Point(90, 63);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Size = new System.Drawing.Size(230, 23);
            this.cboEmpleado.TabIndex = 6;
            //
            // lblSolicitante
            //
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(400, 69);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.TabIndex = 7;
            this.lblSolicitante.Text = "Solicitante:";
            //
            // txtSolicitante
            //
            this.txtSolicitante.Location = new System.Drawing.Point(480, 63);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(270, 23);
            this.txtSolicitante.TabIndex = 8;
            //
            // lblModalidad
            //
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(15, 104);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.TabIndex = 9;
            this.lblModalidad.Text = "Modalidad:";
            //
            // rdoRenuncia
            //
            this.rdoRenuncia.AutoSize = true;
            this.rdoRenuncia.Location = new System.Drawing.Point(90, 100);
            this.rdoRenuncia.Name = "rdoRenuncia";
            this.rdoRenuncia.Size = new System.Drawing.Size(150, 19);
            this.rdoRenuncia.TabIndex = 10;
            this.rdoRenuncia.TabStop = false;
            this.rdoRenuncia.Text = "Renuncia Voluntaria";
            this.rdoRenuncia.UseVisualStyleBackColor = true;
            //
            // rdoDespido
            //
            this.rdoDespido.AutoSize = true;
            this.rdoDespido.Location = new System.Drawing.Point(260, 100);
            this.rdoDespido.Name = "rdoDespido";
            this.rdoDespido.Size = new System.Drawing.Size(90, 19);
            this.rdoDespido.TabIndex = 11;
            this.rdoDespido.TabStop = false;
            this.rdoDespido.Text = "Despido";
            this.rdoDespido.UseVisualStyleBackColor = true;
            //
            // lblMotivo
            //
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(15, 139);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.TabIndex = 12;
            this.lblMotivo.Text = "Motivo:";
            //
            // txtMotivo
            //
            this.txtMotivo.Location = new System.Drawing.Point(80, 133);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(670, 23);
            this.txtMotivo.TabIndex = 13;
            //
            // btnRegistrarSolicitud
            //
            this.btnRegistrarSolicitud.Location = new System.Drawing.Point(15, 172);
            this.btnRegistrarSolicitud.Name = "btnRegistrarSolicitud";
            this.btnRegistrarSolicitud.Size = new System.Drawing.Size(170, 30);
            this.btnRegistrarSolicitud.TabIndex = 14;
            this.btnRegistrarSolicitud.Text = "Registrar Solicitud";
            this.btnRegistrarSolicitud.UseVisualStyleBackColor = true;
            //
            // lblMotivoAnulacion
            //
            this.lblMotivoAnulacion.AutoSize = true;
            this.lblMotivoAnulacion.Location = new System.Drawing.Point(230, 180);
            this.lblMotivoAnulacion.Name = "lblMotivoAnulacion";
            this.lblMotivoAnulacion.TabIndex = 15;
            this.lblMotivoAnulacion.Text = "Motivo Anulación:";
            //
            // txtMotivoAnulacion
            //
            this.txtMotivoAnulacion.Location = new System.Drawing.Point(350, 174);
            this.txtMotivoAnulacion.Name = "txtMotivoAnulacion";
            this.txtMotivoAnulacion.Size = new System.Drawing.Size(260, 23);
            this.txtMotivoAnulacion.TabIndex = 16;
            //
            // btnAnular
            //
            this.btnAnular.Location = new System.Drawing.Point(620, 170);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 30);
            this.btnAnular.TabIndex = 17;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            //
            // gbRenuncia
            //
            this.gbRenuncia.Controls.Add(this.lblCodCarta);
            this.gbRenuncia.Controls.Add(this.txtCodCarta);
            this.gbRenuncia.Controls.Add(this.lblFechaPres);
            this.gbRenuncia.Controls.Add(this.dtpFechaPres);
            this.gbRenuncia.Controls.Add(this.lblDocAdjunto);
            this.gbRenuncia.Controls.Add(this.txtDocAdjunto);
            this.gbRenuncia.Controls.Add(this.btnExaminar);
            this.gbRenuncia.Controls.Add(this.btnArchivarCarta);
            this.gbRenuncia.Location = new System.Drawing.Point(12, 235);
            this.gbRenuncia.Name = "gbRenuncia";
            this.gbRenuncia.Size = new System.Drawing.Size(380, 235);
            this.gbRenuncia.TabIndex = 18;
            this.gbRenuncia.TabStop = false;
            this.gbRenuncia.Text = "Si es RENUNCIA: Archivar Carta";
            //
            // lblCodCarta
            //
            this.lblCodCarta.AutoSize = true;
            this.lblCodCarta.Location = new System.Drawing.Point(15, 34);
            this.lblCodCarta.Name = "lblCodCarta";
            this.lblCodCarta.TabIndex = 19;
            this.lblCodCarta.Text = "Cód. Carta:";
            //
            // txtCodCarta
            //
            this.txtCodCarta.Location = new System.Drawing.Point(115, 28);
            this.txtCodCarta.Name = "txtCodCarta";
            this.txtCodCarta.ReadOnly = true;
            this.txtCodCarta.Size = new System.Drawing.Size(140, 23);
            this.txtCodCarta.TabIndex = 20;
            //
            // lblFechaPres
            //
            this.lblFechaPres.AutoSize = true;
            this.lblFechaPres.Location = new System.Drawing.Point(15, 69);
            this.lblFechaPres.Name = "lblFechaPres";
            this.lblFechaPres.TabIndex = 21;
            this.lblFechaPres.Text = "Fecha Pres.:";
            //
            // dtpFechaPres
            //
            this.dtpFechaPres.Location = new System.Drawing.Point(115, 63);
            this.dtpFechaPres.Name = "dtpFechaPres";
            this.dtpFechaPres.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPres.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPres.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaPres.TabIndex = 22;
            //
            // lblDocAdjunto
            //
            this.lblDocAdjunto.AutoSize = true;
            this.lblDocAdjunto.Location = new System.Drawing.Point(15, 104);
            this.lblDocAdjunto.Name = "lblDocAdjunto";
            this.lblDocAdjunto.TabIndex = 23;
            this.lblDocAdjunto.Text = "Doc. Adjunto:";
            //
            // txtDocAdjunto
            //
            this.txtDocAdjunto.Location = new System.Drawing.Point(115, 98);
            this.txtDocAdjunto.Name = "txtDocAdjunto";
            this.txtDocAdjunto.ReadOnly = true;
            this.txtDocAdjunto.Size = new System.Drawing.Size(240, 23);
            this.txtDocAdjunto.TabIndex = 24;
            //
            // btnExaminar
            //
            this.btnExaminar.Location = new System.Drawing.Point(115, 133);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(110, 30);
            this.btnExaminar.TabIndex = 25;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            //
            // btnArchivarCarta
            //
            this.btnArchivarCarta.Location = new System.Drawing.Point(15, 185);
            this.btnArchivarCarta.Name = "btnArchivarCarta";
            this.btnArchivarCarta.Size = new System.Drawing.Size(220, 30);
            this.btnArchivarCarta.TabIndex = 26;
            this.btnArchivarCarta.Text = "Archivar Carta de Renuncia";
            this.btnArchivarCarta.UseVisualStyleBackColor = true;
            //
            // gbDespido
            //
            this.gbDespido.Controls.Add(this.lblAntecedentes);
            this.gbDespido.Controls.Add(this.txtAntecedentes);
            this.gbDespido.Controls.Add(this.lblVeredicto);
            this.gbDespido.Controls.Add(this.rdoAprobada);
            this.gbDespido.Controls.Add(this.rdoRechazada);
            this.gbDespido.Controls.Add(this.lblFechaEval);
            this.gbDespido.Controls.Add(this.dtpFechaEval);
            this.gbDespido.Controls.Add(this.lblObservacion);
            this.gbDespido.Controls.Add(this.txtObservacion);
            this.gbDespido.Controls.Add(this.btnRegistrarVeredicto);
            this.gbDespido.Location = new System.Drawing.Point(400, 235);
            this.gbDespido.Name = "gbDespido";
            this.gbDespido.Size = new System.Drawing.Size(388, 235);
            this.gbDespido.TabIndex = 27;
            this.gbDespido.TabStop = false;
            this.gbDespido.Text = "Si es DESPIDO: Evaluación Subgerencia";
            //
            // lblAntecedentes
            //
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.Location = new System.Drawing.Point(15, 34);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.TabIndex = 28;
            this.lblAntecedentes.Text = "Antecedentes:";
            //
            // txtAntecedentes
            //
            this.txtAntecedentes.Location = new System.Drawing.Point(115, 28);
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.Size = new System.Drawing.Size(255, 23);
            this.txtAntecedentes.TabIndex = 29;
            //
            // lblVeredicto
            //
            this.lblVeredicto.AutoSize = true;
            this.lblVeredicto.Location = new System.Drawing.Point(15, 69);
            this.lblVeredicto.Name = "lblVeredicto";
            this.lblVeredicto.TabIndex = 30;
            this.lblVeredicto.Text = "Veredicto:";
            //
            // rdoAprobada
            //
            this.rdoAprobada.AutoSize = true;
            this.rdoAprobada.Location = new System.Drawing.Point(115, 65);
            this.rdoAprobada.Name = "rdoAprobada";
            this.rdoAprobada.Size = new System.Drawing.Size(90, 19);
            this.rdoAprobada.TabIndex = 31;
            this.rdoAprobada.TabStop = false;
            this.rdoAprobada.Text = "Aprobada";
            this.rdoAprobada.UseVisualStyleBackColor = true;
            //
            // rdoRechazada
            //
            this.rdoRechazada.AutoSize = true;
            this.rdoRechazada.Location = new System.Drawing.Point(215, 65);
            this.rdoRechazada.Name = "rdoRechazada";
            this.rdoRechazada.Size = new System.Drawing.Size(100, 19);
            this.rdoRechazada.TabIndex = 32;
            this.rdoRechazada.TabStop = false;
            this.rdoRechazada.Text = "Rechazada";
            this.rdoRechazada.UseVisualStyleBackColor = true;
            //
            // lblFechaEval
            //
            this.lblFechaEval.AutoSize = true;
            this.lblFechaEval.Location = new System.Drawing.Point(15, 104);
            this.lblFechaEval.Name = "lblFechaEval";
            this.lblFechaEval.TabIndex = 33;
            this.lblFechaEval.Text = "Fecha Eval.:";
            //
            // dtpFechaEval
            //
            this.dtpFechaEval.Location = new System.Drawing.Point(115, 98);
            this.dtpFechaEval.Name = "dtpFechaEval";
            this.dtpFechaEval.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEval.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEval.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaEval.TabIndex = 34;
            //
            // lblObservacion
            //
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(15, 139);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.TabIndex = 35;
            this.lblObservacion.Text = "Observación:";
            //
            // txtObservacion
            //
            this.txtObservacion.Location = new System.Drawing.Point(115, 133);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(255, 23);
            this.txtObservacion.TabIndex = 36;
            //
            // btnRegistrarVeredicto
            //
            this.btnRegistrarVeredicto.Location = new System.Drawing.Point(15, 185);
            this.btnRegistrarVeredicto.Name = "btnRegistrarVeredicto";
            this.btnRegistrarVeredicto.Size = new System.Drawing.Size(260, 30);
            this.btnRegistrarVeredicto.TabIndex = 37;
            this.btnRegistrarVeredicto.Text = "Registrar Veredicto de Despido";
            this.btnRegistrarVeredicto.UseVisualStyleBackColor = true;
            //
            // frmCoreDesvinculacion
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.gbSolicitud);
            this.Controls.Add(this.gbRenuncia);
            this.Controls.Add(this.gbDespido);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoreDesvinculacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE DESVINCULACIÓN - 1. Solicitud y Evaluación (RF-01)";
            this.gbDespido.ResumeLayout(false);
            this.gbDespido.PerformLayout();
            this.gbRenuncia.ResumeLayout(false);
            this.gbRenuncia.PerformLayout();
            this.gbSolicitud.ResumeLayout(false);
            this.gbSolicitud.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbSolicitud;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.RadioButton rdoRenuncia;
        private System.Windows.Forms.RadioButton rdoDespido;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnRegistrarSolicitud;
        private System.Windows.Forms.Label lblMotivoAnulacion;
        private System.Windows.Forms.TextBox txtMotivoAnulacion;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.GroupBox gbRenuncia;
        private System.Windows.Forms.Label lblCodCarta;
        private System.Windows.Forms.TextBox txtCodCarta;
        private System.Windows.Forms.Label lblFechaPres;
        private System.Windows.Forms.DateTimePicker dtpFechaPres;
        private System.Windows.Forms.Label lblDocAdjunto;
        private System.Windows.Forms.TextBox txtDocAdjunto;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnArchivarCarta;
        private System.Windows.Forms.GroupBox gbDespido;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.Label lblVeredicto;
        private System.Windows.Forms.RadioButton rdoAprobada;
        private System.Windows.Forms.RadioButton rdoRechazada;
        private System.Windows.Forms.Label lblFechaEval;
        private System.Windows.Forms.DateTimePicker dtpFechaEval;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnRegistrarVeredicto;
    }
}
