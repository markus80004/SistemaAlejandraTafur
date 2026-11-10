namespace CapaPresentacion
{
    partial class frmCorePlanillaCalculo
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
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.lblHorasValidas = new System.Windows.Forms.Label();
            this.txtHorasValidas = new System.Windows.Forms.TextBox();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.lblTotalBonos = new System.Windows.Forms.Label();
            this.txtTotalBonos = new System.Windows.Forms.TextBox();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.txtTotalDescuentos = new System.Windows.Forms.TextBox();
            this.lblRemuneracionNeta = new System.Windows.Forms.Label();
            this.txtRemuneracionNeta = new System.Windows.Forms.TextBox();
            this.btnCalcularRemuneracion = new System.Windows.Forms.Button();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetallePlanilla = new System.Windows.Forms.DataGridView();
            this.lblCodigoPlanilla = new System.Windows.Forms.Label();
            this.txtCodigoPlanilla = new System.Windows.Forms.TextBox();
            this.lblFechaDeclaracion = new System.Windows.Forms.Label();
            this.dtpFechaDeclaracion = new System.Windows.Forms.DateTimePicker();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblEstadoPlanilla = new System.Windows.Forms.Label();
            this.txtEstadoPlanilla = new System.Windows.Forms.TextBox();
            this.btnCrearDeclarar = new System.Windows.Forms.Button();
            this.lblMotivoAnulacion = new System.Windows.Forms.Label();
            this.txtMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.btnAnularPlanilla = new System.Windows.Forms.Button();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSueldoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotBonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePlanilla)).BeginInit();
            this.gbCalculo.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            //
            // gbCalculo
            //
            this.gbCalculo.Controls.Add(this.lblPeriodo);
            this.gbCalculo.Controls.Add(this.dtpPeriodo);
            this.gbCalculo.Controls.Add(this.lblEmpleado);
            this.gbCalculo.Controls.Add(this.cboEmpleado);
            this.gbCalculo.Controls.Add(this.lblPuesto);
            this.gbCalculo.Controls.Add(this.txtPuesto);
            this.gbCalculo.Controls.Add(this.lblTarifa);
            this.gbCalculo.Controls.Add(this.txtTarifa);
            this.gbCalculo.Controls.Add(this.lblHorasValidas);
            this.gbCalculo.Controls.Add(this.txtHorasValidas);
            this.gbCalculo.Controls.Add(this.lblSueldoBase);
            this.gbCalculo.Controls.Add(this.txtSueldoBase);
            this.gbCalculo.Controls.Add(this.lblTotalBonos);
            this.gbCalculo.Controls.Add(this.txtTotalBonos);
            this.gbCalculo.Controls.Add(this.lblTotalDescuentos);
            this.gbCalculo.Controls.Add(this.txtTotalDescuentos);
            this.gbCalculo.Controls.Add(this.lblRemuneracionNeta);
            this.gbCalculo.Controls.Add(this.txtRemuneracionNeta);
            this.gbCalculo.Controls.Add(this.btnCalcularRemuneracion);
            this.gbCalculo.Location = new System.Drawing.Point(12, 12);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(756, 290);
            this.gbCalculo.TabIndex = 0;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Cálculo por Empleado (RF-02)";
            //
            // lblPeriodo
            //
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(15, 34);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Periodo:";
            //
            // dtpPeriodo
            //
            this.dtpPeriodo.Location = new System.Drawing.Point(80, 28);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.CustomFormat = "MMMM yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Size = new System.Drawing.Size(170, 23);
            this.dtpPeriodo.TabIndex = 2;
            //
            // lblEmpleado
            //
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 69);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado:";
            //
            // cboEmpleado
            //
            this.cboEmpleado.Location = new System.Drawing.Point(90, 63);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Size = new System.Drawing.Size(230, 23);
            this.cboEmpleado.TabIndex = 4;
            //
            // lblPuesto
            //
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(350, 69);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.TabIndex = 5;
            this.lblPuesto.Text = "Puesto:";
            //
            // txtPuesto
            //
            this.txtPuesto.Location = new System.Drawing.Point(410, 63);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(150, 23);
            this.txtPuesto.TabIndex = 6;
            //
            // lblTarifa
            //
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(590, 69);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.TabIndex = 7;
            this.lblTarifa.Text = "Tarifa:";
            //
            // txtTarifa
            //
            this.txtTarifa.Location = new System.Drawing.Point(640, 63);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.ReadOnly = true;
            this.txtTarifa.Size = new System.Drawing.Size(100, 23);
            this.txtTarifa.TabIndex = 8;
            //
            // lblHorasValidas
            //
            this.lblHorasValidas.AutoSize = true;
            this.lblHorasValidas.Location = new System.Drawing.Point(15, 104);
            this.lblHorasValidas.Name = "lblHorasValidas";
            this.lblHorasValidas.TabIndex = 9;
            this.lblHorasValidas.Text = "Horas Válidas:";
            //
            // txtHorasValidas
            //
            this.txtHorasValidas.Location = new System.Drawing.Point(110, 98);
            this.txtHorasValidas.Name = "txtHorasValidas";
            this.txtHorasValidas.ReadOnly = true;
            this.txtHorasValidas.Size = new System.Drawing.Size(90, 23);
            this.txtHorasValidas.TabIndex = 10;
            //
            // lblSueldoBase
            //
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(260, 104);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.TabIndex = 11;
            this.lblSueldoBase.Text = "Sueldo Base:";
            //
            // txtSueldoBase
            //
            this.txtSueldoBase.Location = new System.Drawing.Point(350, 98);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.ReadOnly = true;
            this.txtSueldoBase.Size = new System.Drawing.Size(130, 23);
            this.txtSueldoBase.TabIndex = 12;
            //
            // lblTotalBonos
            //
            this.lblTotalBonos.AutoSize = true;
            this.lblTotalBonos.Location = new System.Drawing.Point(15, 139);
            this.lblTotalBonos.Name = "lblTotalBonos";
            this.lblTotalBonos.TabIndex = 13;
            this.lblTotalBonos.Text = "(+) Total Bonos Autorizados:";
            //
            // txtTotalBonos
            //
            this.txtTotalBonos.Location = new System.Drawing.Point(270, 133);
            this.txtTotalBonos.Name = "txtTotalBonos";
            this.txtTotalBonos.ReadOnly = true;
            this.txtTotalBonos.Size = new System.Drawing.Size(130, 23);
            this.txtTotalBonos.TabIndex = 14;
            //
            // lblTotalDescuentos
            //
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(15, 174);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.TabIndex = 15;
            this.lblTotalDescuentos.Text = "(-) Total Descuentos Registrados:";
            //
            // txtTotalDescuentos
            //
            this.txtTotalDescuentos.Location = new System.Drawing.Point(270, 168);
            this.txtTotalDescuentos.Name = "txtTotalDescuentos";
            this.txtTotalDescuentos.ReadOnly = true;
            this.txtTotalDescuentos.Size = new System.Drawing.Size(130, 23);
            this.txtTotalDescuentos.TabIndex = 16;
            //
            // lblRemuneracionNeta
            //
            this.lblRemuneracionNeta.AutoSize = true;
            this.lblRemuneracionNeta.Location = new System.Drawing.Point(15, 209);
            this.lblRemuneracionNeta.Name = "lblRemuneracionNeta";
            this.lblRemuneracionNeta.TabIndex = 17;
            this.lblRemuneracionNeta.Text = "(=) REMUNERACIÓN NETA CALCULADA:";
            //
            // txtRemuneracionNeta
            //
            this.txtRemuneracionNeta.Location = new System.Drawing.Point(270, 203);
            this.txtRemuneracionNeta.Name = "txtRemuneracionNeta";
            this.txtRemuneracionNeta.ReadOnly = true;
            this.txtRemuneracionNeta.Size = new System.Drawing.Size(130, 23);
            this.txtRemuneracionNeta.TabIndex = 18;
            //
            // btnCalcularRemuneracion
            //
            this.btnCalcularRemuneracion.Location = new System.Drawing.Point(15, 245);
            this.btnCalcularRemuneracion.Name = "btnCalcularRemuneracion";
            this.btnCalcularRemuneracion.Size = new System.Drawing.Size(350, 30);
            this.btnCalcularRemuneracion.TabIndex = 19;
            this.btnCalcularRemuneracion.Text = "Calcular Remuneración y Generar Detalle de Planilla";
            this.btnCalcularRemuneracion.UseVisualStyleBackColor = true;
            //
            // gbDetalle
            //
            this.gbDetalle.Controls.Add(this.dgvDetallePlanilla);
            this.gbDetalle.Controls.Add(this.lblCodigoPlanilla);
            this.gbDetalle.Controls.Add(this.txtCodigoPlanilla);
            this.gbDetalle.Controls.Add(this.lblFechaDeclaracion);
            this.gbDetalle.Controls.Add(this.dtpFechaDeclaracion);
            this.gbDetalle.Controls.Add(this.lblMontoTotal);
            this.gbDetalle.Controls.Add(this.txtMontoTotal);
            this.gbDetalle.Controls.Add(this.lblEstadoPlanilla);
            this.gbDetalle.Controls.Add(this.txtEstadoPlanilla);
            this.gbDetalle.Controls.Add(this.btnCrearDeclarar);
            this.gbDetalle.Controls.Add(this.lblMotivoAnulacion);
            this.gbDetalle.Controls.Add(this.txtMotivoAnulacion);
            this.gbDetalle.Controls.Add(this.btnAnularPlanilla);
            this.gbDetalle.Location = new System.Drawing.Point(12, 310);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(756, 380);
            this.gbDetalle.TabIndex = 20;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle de Planilla Generado y Declaración Mensual (RF-03)";
            //
            // dgvDetallePlanilla
            //
            this.dgvDetallePlanilla.AllowUserToAddRows = false;
            this.dgvDetallePlanilla.AllowUserToDeleteRows = false;
            this.dgvDetallePlanilla.AllowUserToResizeRows = false;
            this.dgvDetallePlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetallePlanilla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDetallePlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpleado,
            this.colSueldoBase,
            this.colTotBonos,
            this.colTotDescuentos,
            this.colNeto});
            this.dgvDetallePlanilla.Location = new System.Drawing.Point(12, 22);
            this.dgvDetallePlanilla.MultiSelect = false;
            this.dgvDetallePlanilla.Name = "dgvDetallePlanilla";
            this.dgvDetallePlanilla.ReadOnly = true;
            this.dgvDetallePlanilla.RowHeadersVisible = false;
            this.dgvDetallePlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallePlanilla.Size = new System.Drawing.Size(732, 140);
            this.dgvDetallePlanilla.TabIndex = 21;
            //
            // lblCodigoPlanilla
            //
            this.lblCodigoPlanilla.AutoSize = true;
            this.lblCodigoPlanilla.Location = new System.Drawing.Point(15, 183);
            this.lblCodigoPlanilla.Name = "lblCodigoPlanilla";
            this.lblCodigoPlanilla.TabIndex = 22;
            this.lblCodigoPlanilla.Text = "Código Planilla:";
            //
            // txtCodigoPlanilla
            //
            this.txtCodigoPlanilla.Location = new System.Drawing.Point(125, 177);
            this.txtCodigoPlanilla.Name = "txtCodigoPlanilla";
            this.txtCodigoPlanilla.ReadOnly = true;
            this.txtCodigoPlanilla.Size = new System.Drawing.Size(130, 23);
            this.txtCodigoPlanilla.TabIndex = 23;
            //
            // lblFechaDeclaracion
            //
            this.lblFechaDeclaracion.AutoSize = true;
            this.lblFechaDeclaracion.Location = new System.Drawing.Point(290, 183);
            this.lblFechaDeclaracion.Name = "lblFechaDeclaracion";
            this.lblFechaDeclaracion.TabIndex = 24;
            this.lblFechaDeclaracion.Text = "Fecha Declaración:";
            //
            // dtpFechaDeclaracion
            //
            this.dtpFechaDeclaracion.Location = new System.Drawing.Point(415, 177);
            this.dtpFechaDeclaracion.Name = "dtpFechaDeclaracion";
            this.dtpFechaDeclaracion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDeclaracion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDeclaracion.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaDeclaracion.TabIndex = 25;
            //
            // lblMontoTotal
            //
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(15, 218);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.TabIndex = 26;
            this.lblMontoTotal.Text = "Monto Total Planilla:";
            //
            // txtMontoTotal
            //
            this.txtMontoTotal.Location = new System.Drawing.Point(150, 212);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(130, 23);
            this.txtMontoTotal.TabIndex = 27;
            //
            // lblEstadoPlanilla
            //
            this.lblEstadoPlanilla.AutoSize = true;
            this.lblEstadoPlanilla.Location = new System.Drawing.Point(320, 218);
            this.lblEstadoPlanilla.Name = "lblEstadoPlanilla";
            this.lblEstadoPlanilla.TabIndex = 28;
            this.lblEstadoPlanilla.Text = "Estado:";
            //
            // txtEstadoPlanilla
            //
            this.txtEstadoPlanilla.Location = new System.Drawing.Point(375, 212);
            this.txtEstadoPlanilla.Name = "txtEstadoPlanilla";
            this.txtEstadoPlanilla.ReadOnly = true;
            this.txtEstadoPlanilla.Size = new System.Drawing.Size(300, 23);
            this.txtEstadoPlanilla.TabIndex = 29;
            //
            // btnCrearDeclarar
            //
            this.btnCrearDeclarar.Location = new System.Drawing.Point(15, 255);
            this.btnCrearDeclarar.Name = "btnCrearDeclarar";
            this.btnCrearDeclarar.Size = new System.Drawing.Size(280, 30);
            this.btnCrearDeclarar.TabIndex = 30;
            this.btnCrearDeclarar.Text = "Crear y Declarar Archivo de Planilla";
            this.btnCrearDeclarar.UseVisualStyleBackColor = true;
            //
            // lblMotivoAnulacion
            //
            this.lblMotivoAnulacion.AutoSize = true;
            this.lblMotivoAnulacion.Location = new System.Drawing.Point(15, 303);
            this.lblMotivoAnulacion.Name = "lblMotivoAnulacion";
            this.lblMotivoAnulacion.TabIndex = 31;
            this.lblMotivoAnulacion.Text = "Motivo Anulación (Antes del depósito):";
            //
            // txtMotivoAnulacion
            //
            this.txtMotivoAnulacion.Location = new System.Drawing.Point(255, 297);
            this.txtMotivoAnulacion.Name = "txtMotivoAnulacion";
            this.txtMotivoAnulacion.Size = new System.Drawing.Size(475, 23);
            this.txtMotivoAnulacion.TabIndex = 32;
            //
            // btnAnularPlanilla
            //
            this.btnAnularPlanilla.Location = new System.Drawing.Point(15, 335);
            this.btnAnularPlanilla.Name = "btnAnularPlanilla";
            this.btnAnularPlanilla.Size = new System.Drawing.Size(230, 30);
            this.btnAnularPlanilla.TabIndex = 33;
            this.btnAnularPlanilla.Text = "Anular Planilla / Detalle";
            this.btnAnularPlanilla.UseVisualStyleBackColor = true;
            //
            // colEmpleado
            //
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            //
            // colSueldoBase
            //
            this.colSueldoBase.HeaderText = "Sueldo Base";
            this.colSueldoBase.Name = "colSueldoBase";
            this.colSueldoBase.ReadOnly = true;
            //
            // colTotBonos
            //
            this.colTotBonos.HeaderText = "Tot. Bonos";
            this.colTotBonos.Name = "colTotBonos";
            this.colTotBonos.ReadOnly = true;
            //
            // colTotDescuentos
            //
            this.colTotDescuentos.HeaderText = "Tot. Descuent.";
            this.colTotDescuentos.Name = "colTotDescuentos";
            this.colTotDescuentos.ReadOnly = true;
            //
            // colNeto
            //
            this.colNeto.HeaderText = "Neto a Pagar";
            this.colNeto.Name = "colNeto";
            this.colNeto.ReadOnly = true;
            //
            // frmCorePlanillaCalculo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 706);
            this.Controls.Add(this.gbCalculo);
            this.Controls.Add(this.gbDetalle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCorePlanillaCalculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE PLANILLA - 2. Cálculo Salarial y Declaración Mensual (RF-02/RF-03)";
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbCalculo.ResumeLayout(false);
            this.gbCalculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePlanilla)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label lblHorasValidas;
        private System.Windows.Forms.TextBox txtHorasValidas;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.TextBox txtSueldoBase;
        private System.Windows.Forms.Label lblTotalBonos;
        private System.Windows.Forms.TextBox txtTotalBonos;
        private System.Windows.Forms.Label lblTotalDescuentos;
        private System.Windows.Forms.TextBox txtTotalDescuentos;
        private System.Windows.Forms.Label lblRemuneracionNeta;
        private System.Windows.Forms.TextBox txtRemuneracionNeta;
        private System.Windows.Forms.Button btnCalcularRemuneracion;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.DataGridView dgvDetallePlanilla;
        private System.Windows.Forms.Label lblCodigoPlanilla;
        private System.Windows.Forms.TextBox txtCodigoPlanilla;
        private System.Windows.Forms.Label lblFechaDeclaracion;
        private System.Windows.Forms.DateTimePicker dtpFechaDeclaracion;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblEstadoPlanilla;
        private System.Windows.Forms.TextBox txtEstadoPlanilla;
        private System.Windows.Forms.Button btnCrearDeclarar;
        private System.Windows.Forms.Label lblMotivoAnulacion;
        private System.Windows.Forms.TextBox txtMotivoAnulacion;
        private System.Windows.Forms.Button btnAnularPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSueldoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotBonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeto;
    }
}
