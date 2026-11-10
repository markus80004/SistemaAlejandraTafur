namespace CapaPresentacion
{
    partial class frmCoreAusenciasDirector
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
            this.gbBandeja = new System.Windows.Forms.GroupBox();
            this.dgvBandeja = new System.Windows.Forms.DataGridView();
            this.gbPaso1 = new System.Windows.Forms.GroupBox();
            this.lblVeredicto = new System.Windows.Forms.Label();
            this.rdoValida = new System.Windows.Forms.RadioButton();
            this.rdoInvalida = new System.Windows.Forms.RadioButton();
            this.chkFaltanDocumentos = new System.Windows.Forms.CheckBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnGuardarValidacion = new System.Windows.Forms.Button();
            this.btnSolicitarDocumentos = new System.Windows.Forms.Button();
            this.btnNotificarInvalidez = new System.Windows.Forms.Button();
            this.gbPaso2 = new System.Windows.Forms.GroupBox();
            this.lblInicioAgendado = new System.Windows.Forms.Label();
            this.dtpInicioAgendado = new System.Windows.Forms.DateTimePicker();
            this.lblDuracionAgendada = new System.Windows.Forms.Label();
            this.numDuracionAgendada = new System.Windows.Forms.NumericUpDown();
            this.lblJustifAsociada = new System.Windows.Forms.Label();
            this.txtJustifAsociada = new System.Windows.Forms.TextBox();
            this.btnAgendarAusencia = new System.Windows.Forms.Button();
            this.lblMotivoAnulacionAusencia = new System.Windows.Forms.Label();
            this.txtMotivoAnulacionAusencia = new System.Windows.Forms.TextBox();
            this.btnAnularAusencia = new System.Windows.Forms.Button();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAusencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicioDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionAgendada)).BeginInit();
            this.gbBandeja.SuspendLayout();
            this.gbPaso1.SuspendLayout();
            this.gbPaso2.SuspendLayout();
            this.SuspendLayout();
            //
            // gbBandeja
            //
            this.gbBandeja.Controls.Add(this.dgvBandeja);
            this.gbBandeja.Location = new System.Drawing.Point(12, 12);
            this.gbBandeja.Name = "gbBandeja";
            this.gbBandeja.Size = new System.Drawing.Size(756, 200);
            this.gbBandeja.TabIndex = 0;
            this.gbBandeja.TabStop = false;
            this.gbBandeja.Text = "Bandeja de Justificaciones Recibidas";
            //
            // dgvBandeja
            //
            this.dgvBandeja.AllowUserToAddRows = false;
            this.dgvBandeja.AllowUserToDeleteRows = false;
            this.dgvBandeja.AllowUserToResizeRows = false;
            this.dgvBandeja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBandeja.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBandeja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colEmpleado,
            this.colTipoAusencia,
            this.colInicioDias,
            this.colDocumento});
            this.dgvBandeja.Location = new System.Drawing.Point(12, 22);
            this.dgvBandeja.MultiSelect = false;
            this.dgvBandeja.Name = "dgvBandeja";
            this.dgvBandeja.ReadOnly = true;
            this.dgvBandeja.RowHeadersVisible = false;
            this.dgvBandeja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBandeja.Size = new System.Drawing.Size(732, 165);
            this.dgvBandeja.TabIndex = 1;
            //
            // gbPaso1
            //
            this.gbPaso1.Controls.Add(this.lblVeredicto);
            this.gbPaso1.Controls.Add(this.rdoValida);
            this.gbPaso1.Controls.Add(this.rdoInvalida);
            this.gbPaso1.Controls.Add(this.chkFaltanDocumentos);
            this.gbPaso1.Controls.Add(this.lblObservacion);
            this.gbPaso1.Controls.Add(this.txtObservacion);
            this.gbPaso1.Controls.Add(this.btnGuardarValidacion);
            this.gbPaso1.Controls.Add(this.btnSolicitarDocumentos);
            this.gbPaso1.Controls.Add(this.btnNotificarInvalidez);
            this.gbPaso1.Location = new System.Drawing.Point(12, 220);
            this.gbPaso1.Name = "gbPaso1";
            this.gbPaso1.Size = new System.Drawing.Size(756, 170);
            this.gbPaso1.TabIndex = 2;
            this.gbPaso1.TabStop = false;
            this.gbPaso1.Text = "PASO 1: Evaluación de Sustento (RF-02)";
            //
            // lblVeredicto
            //
            this.lblVeredicto.AutoSize = true;
            this.lblVeredicto.Location = new System.Drawing.Point(15, 34);
            this.lblVeredicto.Name = "lblVeredicto";
            this.lblVeredicto.TabIndex = 3;
            this.lblVeredicto.Text = "Veredicto:";
            //
            // rdoValida
            //
            this.rdoValida.AutoSize = true;
            this.rdoValida.Location = new System.Drawing.Point(90, 30);
            this.rdoValida.Name = "rdoValida";
            this.rdoValida.Size = new System.Drawing.Size(70, 19);
            this.rdoValida.TabIndex = 4;
            this.rdoValida.TabStop = false;
            this.rdoValida.Text = "Válida";
            this.rdoValida.UseVisualStyleBackColor = true;
            //
            // rdoInvalida
            //
            this.rdoInvalida.AutoSize = true;
            this.rdoInvalida.Location = new System.Drawing.Point(170, 30);
            this.rdoInvalida.Name = "rdoInvalida";
            this.rdoInvalida.Size = new System.Drawing.Size(80, 19);
            this.rdoInvalida.TabIndex = 5;
            this.rdoInvalida.TabStop = false;
            this.rdoInvalida.Text = "Inválida";
            this.rdoInvalida.UseVisualStyleBackColor = true;
            //
            // chkFaltanDocumentos
            //
            this.chkFaltanDocumentos.AutoSize = true;
            this.chkFaltanDocumentos.Location = new System.Drawing.Point(270, 30);
            this.chkFaltanDocumentos.Name = "chkFaltanDocumentos";
            this.chkFaltanDocumentos.Size = new System.Drawing.Size(200, 19);
            this.chkFaltanDocumentos.TabIndex = 6;
            this.chkFaltanDocumentos.Text = "Hacen falta documentos";
            this.chkFaltanDocumentos.UseVisualStyleBackColor = true;
            //
            // lblObservacion
            //
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(15, 71);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.TabIndex = 7;
            this.lblObservacion.Text = "Observación RRHH:";
            //
            // txtObservacion
            //
            this.txtObservacion.Location = new System.Drawing.Point(140, 65);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(590, 23);
            this.txtObservacion.TabIndex = 8;
            //
            // btnGuardarValidacion
            //
            this.btnGuardarValidacion.Location = new System.Drawing.Point(15, 110);
            this.btnGuardarValidacion.Name = "btnGuardarValidacion";
            this.btnGuardarValidacion.Size = new System.Drawing.Size(160, 30);
            this.btnGuardarValidacion.TabIndex = 9;
            this.btnGuardarValidacion.Text = "Guardar Validación";
            this.btnGuardarValidacion.UseVisualStyleBackColor = true;
            //
            // btnSolicitarDocumentos
            //
            this.btnSolicitarDocumentos.Location = new System.Drawing.Point(185, 110);
            this.btnSolicitarDocumentos.Name = "btnSolicitarDocumentos";
            this.btnSolicitarDocumentos.Size = new System.Drawing.Size(190, 30);
            this.btnSolicitarDocumentos.TabIndex = 10;
            this.btnSolicitarDocumentos.Text = "Solicitar Doc. Faltantes";
            this.btnSolicitarDocumentos.UseVisualStyleBackColor = true;
            //
            // btnNotificarInvalidez
            //
            this.btnNotificarInvalidez.Location = new System.Drawing.Point(385, 110);
            this.btnNotificarInvalidez.Name = "btnNotificarInvalidez";
            this.btnNotificarInvalidez.Size = new System.Drawing.Size(170, 30);
            this.btnNotificarInvalidez.TabIndex = 11;
            this.btnNotificarInvalidez.Text = "Notificar Invalidez";
            this.btnNotificarInvalidez.UseVisualStyleBackColor = true;
            //
            // gbPaso2
            //
            this.gbPaso2.Controls.Add(this.lblInicioAgendado);
            this.gbPaso2.Controls.Add(this.dtpInicioAgendado);
            this.gbPaso2.Controls.Add(this.lblDuracionAgendada);
            this.gbPaso2.Controls.Add(this.numDuracionAgendada);
            this.gbPaso2.Controls.Add(this.lblJustifAsociada);
            this.gbPaso2.Controls.Add(this.txtJustifAsociada);
            this.gbPaso2.Controls.Add(this.btnAgendarAusencia);
            this.gbPaso2.Controls.Add(this.lblMotivoAnulacionAusencia);
            this.gbPaso2.Controls.Add(this.txtMotivoAnulacionAusencia);
            this.gbPaso2.Controls.Add(this.btnAnularAusencia);
            this.gbPaso2.Location = new System.Drawing.Point(12, 398);
            this.gbPaso2.Name = "gbPaso2";
            this.gbPaso2.Size = new System.Drawing.Size(756, 190);
            this.gbPaso2.TabIndex = 12;
            this.gbPaso2.TabStop = false;
            this.gbPaso2.Text = "PASO 2: Agendar Periodo de Ausencia Justificada (RF-03 - Solo si es Válida)";
            //
            // lblInicioAgendado
            //
            this.lblInicioAgendado.AutoSize = true;
            this.lblInicioAgendado.Location = new System.Drawing.Point(15, 34);
            this.lblInicioAgendado.Name = "lblInicioAgendado";
            this.lblInicioAgendado.TabIndex = 13;
            this.lblInicioAgendado.Text = "Inicio Agendado:";
            //
            // dtpInicioAgendado
            //
            this.dtpInicioAgendado.Location = new System.Drawing.Point(125, 28);
            this.dtpInicioAgendado.Name = "dtpInicioAgendado";
            this.dtpInicioAgendado.CustomFormat = "dd/MM/yyyy";
            this.dtpInicioAgendado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioAgendado.Size = new System.Drawing.Size(140, 23);
            this.dtpInicioAgendado.TabIndex = 14;
            //
            // lblDuracionAgendada
            //
            this.lblDuracionAgendada.AutoSize = true;
            this.lblDuracionAgendada.Location = new System.Drawing.Point(300, 34);
            this.lblDuracionAgendada.Name = "lblDuracionAgendada";
            this.lblDuracionAgendada.TabIndex = 15;
            this.lblDuracionAgendada.Text = "Duración (días):";
            //
            // numDuracionAgendada
            //
            this.numDuracionAgendada.Location = new System.Drawing.Point(410, 28);
            this.numDuracionAgendada.Name = "numDuracionAgendada";
            this.numDuracionAgendada.DecimalPlaces = 0;
            this.numDuracionAgendada.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numDuracionAgendada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDuracionAgendada.Size = new System.Drawing.Size(70, 23);
            this.numDuracionAgendada.TabIndex = 16;
            //
            // lblJustifAsociada
            //
            this.lblJustifAsociada.AutoSize = true;
            this.lblJustifAsociada.Location = new System.Drawing.Point(510, 34);
            this.lblJustifAsociada.Name = "lblJustifAsociada";
            this.lblJustifAsociada.TabIndex = 17;
            this.lblJustifAsociada.Text = "Justif. Asoc.:";
            //
            // txtJustifAsociada
            //
            this.txtJustifAsociada.Location = new System.Drawing.Point(600, 28);
            this.txtJustifAsociada.Name = "txtJustifAsociada";
            this.txtJustifAsociada.ReadOnly = true;
            this.txtJustifAsociada.Size = new System.Drawing.Size(130, 23);
            this.txtJustifAsociada.TabIndex = 18;
            //
            // btnAgendarAusencia
            //
            this.btnAgendarAusencia.Location = new System.Drawing.Point(15, 68);
            this.btnAgendarAusencia.Name = "btnAgendarAusencia";
            this.btnAgendarAusencia.Size = new System.Drawing.Size(440, 30);
            this.btnAgendarAusencia.TabIndex = 19;
            this.btnAgendarAusencia.Text = "Agendar Ausencia, Notificar Aprobación y Archivar";
            this.btnAgendarAusencia.UseVisualStyleBackColor = true;
            //
            // lblMotivoAnulacionAusencia
            //
            this.lblMotivoAnulacionAusencia.AutoSize = true;
            this.lblMotivoAnulacionAusencia.Location = new System.Drawing.Point(15, 118);
            this.lblMotivoAnulacionAusencia.Name = "lblMotivoAnulacionAusencia";
            this.lblMotivoAnulacionAusencia.TabIndex = 20;
            this.lblMotivoAnulacionAusencia.Text = "Motivo Anulación de Ausencia Agendada:";
            //
            // txtMotivoAnulacionAusencia
            //
            this.txtMotivoAnulacionAusencia.Location = new System.Drawing.Point(280, 112);
            this.txtMotivoAnulacionAusencia.Name = "txtMotivoAnulacionAusencia";
            this.txtMotivoAnulacionAusencia.Size = new System.Drawing.Size(450, 23);
            this.txtMotivoAnulacionAusencia.TabIndex = 21;
            //
            // btnAnularAusencia
            //
            this.btnAnularAusencia.Location = new System.Drawing.Point(15, 148);
            this.btnAnularAusencia.Name = "btnAnularAusencia";
            this.btnAnularAusencia.Size = new System.Drawing.Size(220, 30);
            this.btnAnularAusencia.TabIndex = 22;
            this.btnAnularAusencia.Text = "Anular Ausencia Justificada";
            this.btnAnularAusencia.UseVisualStyleBackColor = true;
            //
            // colNumero
            //
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            //
            // colEmpleado
            //
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            //
            // colTipoAusencia
            //
            this.colTipoAusencia.HeaderText = "Tipo Ausencia";
            this.colTipoAusencia.Name = "colTipoAusencia";
            this.colTipoAusencia.ReadOnly = true;
            //
            // colInicioDias
            //
            this.colInicioDias.HeaderText = "Inicio/Días";
            this.colInicioDias.Name = "colInicioDias";
            this.colInicioDias.ReadOnly = true;
            //
            // colDocumento
            //
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            this.colDocumento.Text = "Ver Sustento";
            this.colDocumento.UseColumnTextForButtonValue = true;
            //
            // frmCoreAusenciasDirector
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 604);
            this.Controls.Add(this.gbBandeja);
            this.Controls.Add(this.gbPaso1);
            this.Controls.Add(this.gbPaso2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoreAusenciasDirector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE AUSENCIAS (Director RRHH) - Evaluación y Agenda (RF-02 y RF-03)";
            this.gbPaso2.ResumeLayout(false);
            this.gbPaso2.PerformLayout();
            this.gbPaso1.ResumeLayout(false);
            this.gbPaso1.PerformLayout();
            this.gbBandeja.ResumeLayout(false);
            this.gbBandeja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandeja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionAgendada)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbBandeja;
        private System.Windows.Forms.DataGridView dgvBandeja;
        private System.Windows.Forms.GroupBox gbPaso1;
        private System.Windows.Forms.Label lblVeredicto;
        private System.Windows.Forms.RadioButton rdoValida;
        private System.Windows.Forms.RadioButton rdoInvalida;
        private System.Windows.Forms.CheckBox chkFaltanDocumentos;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnGuardarValidacion;
        private System.Windows.Forms.Button btnSolicitarDocumentos;
        private System.Windows.Forms.Button btnNotificarInvalidez;
        private System.Windows.Forms.GroupBox gbPaso2;
        private System.Windows.Forms.Label lblInicioAgendado;
        private System.Windows.Forms.DateTimePicker dtpInicioAgendado;
        private System.Windows.Forms.Label lblDuracionAgendada;
        private System.Windows.Forms.NumericUpDown numDuracionAgendada;
        private System.Windows.Forms.Label lblJustifAsociada;
        private System.Windows.Forms.TextBox txtJustifAsociada;
        private System.Windows.Forms.Button btnAgendarAusencia;
        private System.Windows.Forms.Label lblMotivoAnulacionAusencia;
        private System.Windows.Forms.TextBox txtMotivoAnulacionAusencia;
        private System.Windows.Forms.Button btnAnularAusencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAusencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicioDias;
        private System.Windows.Forms.DataGridViewButtonColumn colDocumento;
    }
}
