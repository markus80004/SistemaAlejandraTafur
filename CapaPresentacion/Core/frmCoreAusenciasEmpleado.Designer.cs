namespace CapaPresentacion
{
    partial class frmCoreAusenciasEmpleado
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
            this.gbJustificacion = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblTipoAusencia = new System.Windows.Forms.Label();
            this.cboTipoAusencia = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnRegistrarJustificacion = new System.Windows.Forms.Button();
            this.btnActualizarDocumentos = new System.Windows.Forms.Button();
            this.gbHistorial = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblMotivoAnulacion = new System.Windows.Forms.Label();
            this.txtMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.btnAnularJustificacion = new System.Windows.Forms.Button();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAusencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObsRrhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.gbJustificacion.SuspendLayout();
            this.gbHistorial.SuspendLayout();
            this.SuspendLayout();
            //
            // gbJustificacion
            //
            this.gbJustificacion.Controls.Add(this.lblNumero);
            this.gbJustificacion.Controls.Add(this.txtNumero);
            this.gbJustificacion.Controls.Add(this.lblAuto);
            this.gbJustificacion.Controls.Add(this.lblFechaRegistro);
            this.gbJustificacion.Controls.Add(this.dtpFechaRegistro);
            this.gbJustificacion.Controls.Add(this.lblEmpleado);
            this.gbJustificacion.Controls.Add(this.txtEmpleado);
            this.gbJustificacion.Controls.Add(this.lblTipoAusencia);
            this.gbJustificacion.Controls.Add(this.cboTipoAusencia);
            this.gbJustificacion.Controls.Add(this.lblFechaInicio);
            this.gbJustificacion.Controls.Add(this.dtpFechaInicio);
            this.gbJustificacion.Controls.Add(this.lblDuracion);
            this.gbJustificacion.Controls.Add(this.numDuracion);
            this.gbJustificacion.Controls.Add(this.lblDocumento);
            this.gbJustificacion.Controls.Add(this.txtDocumento);
            this.gbJustificacion.Controls.Add(this.btnExaminar);
            this.gbJustificacion.Controls.Add(this.btnRegistrarJustificacion);
            this.gbJustificacion.Controls.Add(this.btnActualizarDocumentos);
            this.gbJustificacion.Location = new System.Drawing.Point(12, 12);
            this.gbJustificacion.Name = "gbJustificacion";
            this.gbJustificacion.Size = new System.Drawing.Size(756, 215);
            this.gbJustificacion.TabIndex = 0;
            this.gbJustificacion.TabStop = false;
            this.gbJustificacion.Text = "Registrar Justificación";
            //
            // lblNumero
            //
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(15, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "N° Justificación:";
            //
            // txtNumero
            //
            this.txtNumero.Location = new System.Drawing.Point(130, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(120, 23);
            this.txtNumero.TabIndex = 2;
            //
            // lblAuto
            //
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(258, 31);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.TabIndex = 3;
            this.lblAuto.Text = "(Auto)";
            //
            // lblFechaRegistro
            //
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(400, 31);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.TabIndex = 4;
            this.lblFechaRegistro.Text = "Fecha Registro:";
            //
            // dtpFechaRegistro
            //
            this.dtpFechaRegistro.Location = new System.Drawing.Point(510, 25);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRegistro.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaRegistro.TabIndex = 5;
            //
            // lblEmpleado
            //
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 63);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.TabIndex = 6;
            this.lblEmpleado.Text = "Empleado:";
            //
            // txtEmpleado
            //
            this.txtEmpleado.Location = new System.Drawing.Point(130, 57);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.ReadOnly = true;
            this.txtEmpleado.Size = new System.Drawing.Size(230, 23);
            this.txtEmpleado.TabIndex = 7;
            //
            // lblTipoAusencia
            //
            this.lblTipoAusencia.AutoSize = true;
            this.lblTipoAusencia.Location = new System.Drawing.Point(400, 63);
            this.lblTipoAusencia.Name = "lblTipoAusencia";
            this.lblTipoAusencia.TabIndex = 8;
            this.lblTipoAusencia.Text = "Tipo Ausencia:";
            //
            // cboTipoAusencia
            //
            this.cboTipoAusencia.Location = new System.Drawing.Point(510, 57);
            this.cboTipoAusencia.Name = "cboTipoAusencia";
            this.cboTipoAusencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAusencia.FormattingEnabled = true;
            this.cboTipoAusencia.Size = new System.Drawing.Size(220, 23);
            this.cboTipoAusencia.TabIndex = 9;
            //
            // lblFechaInicio
            //
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 95);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            //
            // dtpFechaInicio
            //
            this.dtpFechaInicio.Location = new System.Drawing.Point(130, 89);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaInicio.TabIndex = 11;
            //
            // lblDuracion
            //
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(400, 95);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.TabIndex = 12;
            this.lblDuracion.Text = "Duración (días):";
            //
            // numDuracion
            //
            this.numDuracion.Location = new System.Drawing.Point(510, 89);
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.DecimalPlaces = 0;
            this.numDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuracion.Size = new System.Drawing.Size(70, 23);
            this.numDuracion.TabIndex = 13;
            //
            // lblDocumento
            //
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(15, 127);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Documento Sustento:";
            //
            // txtDocumento
            //
            this.txtDocumento.Location = new System.Drawing.Point(150, 121);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(400, 23);
            this.txtDocumento.TabIndex = 15;
            //
            // btnExaminar
            //
            this.btnExaminar.Location = new System.Drawing.Point(560, 117);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(110, 30);
            this.btnExaminar.TabIndex = 16;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            //
            // btnRegistrarJustificacion
            //
            this.btnRegistrarJustificacion.Location = new System.Drawing.Point(15, 170);
            this.btnRegistrarJustificacion.Name = "btnRegistrarJustificacion";
            this.btnRegistrarJustificacion.Size = new System.Drawing.Size(190, 30);
            this.btnRegistrarJustificacion.TabIndex = 17;
            this.btnRegistrarJustificacion.Text = "Registrar Justificación";
            this.btnRegistrarJustificacion.UseVisualStyleBackColor = true;
            //
            // btnActualizarDocumentos
            //
            this.btnActualizarDocumentos.Location = new System.Drawing.Point(215, 170);
            this.btnActualizarDocumentos.Name = "btnActualizarDocumentos";
            this.btnActualizarDocumentos.Size = new System.Drawing.Size(230, 30);
            this.btnActualizarDocumentos.TabIndex = 18;
            this.btnActualizarDocumentos.Text = "Actualizar con Doc. Faltantes";
            this.btnActualizarDocumentos.UseVisualStyleBackColor = true;
            //
            // gbHistorial
            //
            this.gbHistorial.Controls.Add(this.dgvHistorial);
            this.gbHistorial.Controls.Add(this.lblMotivoAnulacion);
            this.gbHistorial.Controls.Add(this.txtMotivoAnulacion);
            this.gbHistorial.Controls.Add(this.btnAnularJustificacion);
            this.gbHistorial.Location = new System.Drawing.Point(12, 235);
            this.gbHistorial.Name = "gbHistorial";
            this.gbHistorial.Size = new System.Drawing.Size(756, 305);
            this.gbHistorial.TabIndex = 19;
            this.gbHistorial.TabStop = false;
            this.gbHistorial.Text = "Historial de Mis Solicitudes Enviadas";
            //
            // dgvHistorial
            //
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colTipoAusencia,
            this.colFechaInicio,
            this.colDias,
            this.colEstado,
            this.colObsRrhh});
            this.dgvHistorial.Location = new System.Drawing.Point(12, 22);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(732, 180);
            this.dgvHistorial.TabIndex = 20;
            //
            // lblMotivoAnulacion
            //
            this.lblMotivoAnulacion.AutoSize = true;
            this.lblMotivoAnulacion.Location = new System.Drawing.Point(15, 225);
            this.lblMotivoAnulacion.Name = "lblMotivoAnulacion";
            this.lblMotivoAnulacion.TabIndex = 21;
            this.lblMotivoAnulacion.Text = "Motivo de Anulación (Solo estado Pendiente):";
            //
            // txtMotivoAnulacion
            //
            this.txtMotivoAnulacion.Location = new System.Drawing.Point(300, 219);
            this.txtMotivoAnulacion.Name = "txtMotivoAnulacion";
            this.txtMotivoAnulacion.Size = new System.Drawing.Size(430, 23);
            this.txtMotivoAnulacion.TabIndex = 22;
            //
            // btnAnularJustificacion
            //
            this.btnAnularJustificacion.Location = new System.Drawing.Point(15, 260);
            this.btnAnularJustificacion.Name = "btnAnularJustificacion";
            this.btnAnularJustificacion.Size = new System.Drawing.Size(180, 30);
            this.btnAnularJustificacion.TabIndex = 23;
            this.btnAnularJustificacion.Text = "Anular Justificación";
            this.btnAnularJustificacion.UseVisualStyleBackColor = true;
            //
            // colNumero
            //
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            //
            // colTipoAusencia
            //
            this.colTipoAusencia.HeaderText = "Tipo Ausencia";
            this.colTipoAusencia.Name = "colTipoAusencia";
            this.colTipoAusencia.ReadOnly = true;
            //
            // colFechaInicio
            //
            this.colFechaInicio.HeaderText = "F. Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            //
            // colDias
            //
            this.colDias.HeaderText = "Días";
            this.colDias.Name = "colDias";
            this.colDias.ReadOnly = true;
            //
            // colEstado
            //
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            //
            // colObsRrhh
            //
            this.colObsRrhh.HeaderText = "Obs. RRHH";
            this.colObsRrhh.Name = "colObsRrhh";
            this.colObsRrhh.ReadOnly = true;
            //
            // frmCoreAusenciasEmpleado
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 560);
            this.Controls.Add(this.gbJustificacion);
            this.Controls.Add(this.gbHistorial);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoreAusenciasEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE AUSENCIAS (Vista Empleado) - Mis Justificaciones (RF-01)";
            this.gbHistorial.ResumeLayout(false);
            this.gbHistorial.PerformLayout();
            this.gbJustificacion.ResumeLayout(false);
            this.gbJustificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbJustificacion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblTipoAusencia;
        private System.Windows.Forms.ComboBox cboTipoAusencia;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnRegistrarJustificacion;
        private System.Windows.Forms.Button btnActualizarDocumentos;
        private System.Windows.Forms.GroupBox gbHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblMotivoAnulacion;
        private System.Windows.Forms.TextBox txtMotivoAnulacion;
        private System.Windows.Forms.Button btnAnularJustificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAusencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObsRrhh;
    }
}
