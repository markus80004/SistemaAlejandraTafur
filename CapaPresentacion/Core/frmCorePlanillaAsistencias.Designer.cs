namespace CapaPresentacion
{
    partial class frmCorePlanillaAsistencias
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
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarAsistencias = new System.Windows.Forms.Button();
            this.gbAsistencias = new System.Windows.Forms.GroupBox();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.lblAccionContador = new System.Windows.Forms.Label();
            this.btnMarcarCuestionable = new System.Windows.Forms.Button();
            this.gbVerificacion = new System.Windows.Forms.GroupBox();
            this.lblRegistroSeleccionado = new System.Windows.Forms.Label();
            this.txtRegistroSeleccionado = new System.Windows.Forms.TextBox();
            this.lblVeredictoFinal = new System.Windows.Forms.Label();
            this.rdoConforme = new System.Windows.Forms.RadioButton();
            this.rdoInvalidaDescuento = new System.Windows.Forms.RadioButton();
            this.lblFechaDescuento = new System.Windows.Forms.Label();
            this.dtpFechaDescuento = new System.Windows.Forms.DateTimePicker();
            this.lblHorasInvalidas = new System.Windows.Forms.Label();
            this.numHorasInvalidas = new System.Windows.Forms.NumericUpDown();
            this.lblMonto = new System.Windows.Forms.Label();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrarVeredicto = new System.Windows.Forms.Button();
            this.colIdAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasInvalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbAsistencias.SuspendLayout();
            this.gbVerificacion.SuspendLayout();
            this.SuspendLayout();
            //
            // gbFiltro
            //
            this.gbFiltro.Controls.Add(this.lblPeriodo);
            this.gbFiltro.Controls.Add(this.dtpPeriodo);
            this.gbFiltro.Controls.Add(this.btnFiltrarAsistencias);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(756, 70);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Periodo";
            //
            // lblPeriodo
            //
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(15, 34);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.TabIndex = 1;
            this.lblPeriodo.Text = "Mes / Periodo:";
            //
            // dtpPeriodo
            //
            this.dtpPeriodo.Location = new System.Drawing.Point(110, 28);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.CustomFormat = "MMMM yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Size = new System.Drawing.Size(180, 23);
            this.dtpPeriodo.TabIndex = 2;
            //
            // btnFiltrarAsistencias
            //
            this.btnFiltrarAsistencias.Location = new System.Drawing.Point(310, 24);
            this.btnFiltrarAsistencias.Name = "btnFiltrarAsistencias";
            this.btnFiltrarAsistencias.Size = new System.Drawing.Size(170, 30);
            this.btnFiltrarAsistencias.TabIndex = 3;
            this.btnFiltrarAsistencias.Text = "Filtrar Asistencias";
            this.btnFiltrarAsistencias.UseVisualStyleBackColor = true;
            //
            // gbAsistencias
            //
            this.gbAsistencias.Controls.Add(this.dgvAsistencias);
            this.gbAsistencias.Controls.Add(this.lblAccionContador);
            this.gbAsistencias.Controls.Add(this.btnMarcarCuestionable);
            this.gbAsistencias.Location = new System.Drawing.Point(12, 90);
            this.gbAsistencias.Name = "gbAsistencias";
            this.gbAsistencias.Size = new System.Drawing.Size(756, 235);
            this.gbAsistencias.TabIndex = 4;
            this.gbAsistencias.TabStop = false;
            this.gbAsistencias.Text = "Asistencias";
            //
            // dgvAsistencias
            //
            this.dgvAsistencias.AllowUserToAddRows = false;
            this.dgvAsistencias.AllowUserToDeleteRows = false;
            this.dgvAsistencias.AllowUserToResizeRows = false;
            this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAsistencia,
            this.colEmpleado,
            this.colFecha,
            this.colHoras,
            this.colEstadoAsistencia});
            this.dgvAsistencias.Location = new System.Drawing.Point(12, 22);
            this.dgvAsistencias.MultiSelect = false;
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.RowHeadersVisible = false;
            this.dgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencias.Size = new System.Drawing.Size(732, 150);
            this.dgvAsistencias.TabIndex = 5;
            //
            // lblAccionContador
            //
            this.lblAccionContador.AutoSize = true;
            this.lblAccionContador.Location = new System.Drawing.Point(15, 193);
            this.lblAccionContador.Name = "lblAccionContador";
            this.lblAccionContador.TabIndex = 6;
            this.lblAccionContador.Text = "Acción Contador:";
            //
            // btnMarcarCuestionable
            //
            this.btnMarcarCuestionable.Location = new System.Drawing.Point(135, 184);
            this.btnMarcarCuestionable.Name = "btnMarcarCuestionable";
            this.btnMarcarCuestionable.Size = new System.Drawing.Size(400, 30);
            this.btnMarcarCuestionable.TabIndex = 7;
            this.btnMarcarCuestionable.Text = "Marcar Seleccionada como Cuestionable y Derivar a RRHH";
            this.btnMarcarCuestionable.UseVisualStyleBackColor = true;
            //
            // gbVerificacion
            //
            this.gbVerificacion.Controls.Add(this.lblRegistroSeleccionado);
            this.gbVerificacion.Controls.Add(this.txtRegistroSeleccionado);
            this.gbVerificacion.Controls.Add(this.lblVeredictoFinal);
            this.gbVerificacion.Controls.Add(this.rdoConforme);
            this.gbVerificacion.Controls.Add(this.rdoInvalidaDescuento);
            this.gbVerificacion.Controls.Add(this.lblFechaDescuento);
            this.gbVerificacion.Controls.Add(this.dtpFechaDescuento);
            this.gbVerificacion.Controls.Add(this.lblHorasInvalidas);
            this.gbVerificacion.Controls.Add(this.numHorasInvalidas);
            this.gbVerificacion.Controls.Add(this.lblMonto);
            this.gbVerificacion.Controls.Add(this.numMonto);
            this.gbVerificacion.Controls.Add(this.btnRegistrarVeredicto);
            this.gbVerificacion.Location = new System.Drawing.Point(12, 335);
            this.gbVerificacion.Name = "gbVerificacion";
            this.gbVerificacion.Size = new System.Drawing.Size(756, 195);
            this.gbVerificacion.TabIndex = 8;
            this.gbVerificacion.TabStop = false;
            this.gbVerificacion.Text = "Panel de Verificación y Descuento (Exclusivo Director de RRHH)";
            //
            // lblRegistroSeleccionado
            //
            this.lblRegistroSeleccionado.AutoSize = true;
            this.lblRegistroSeleccionado.Location = new System.Drawing.Point(15, 34);
            this.lblRegistroSeleccionado.Name = "lblRegistroSeleccionado";
            this.lblRegistroSeleccionado.TabIndex = 9;
            this.lblRegistroSeleccionado.Text = "Registro Seleccionado:";
            //
            // txtRegistroSeleccionado
            //
            this.txtRegistroSeleccionado.Location = new System.Drawing.Point(160, 28);
            this.txtRegistroSeleccionado.Name = "txtRegistroSeleccionado";
            this.txtRegistroSeleccionado.ReadOnly = true;
            this.txtRegistroSeleccionado.Size = new System.Drawing.Size(300, 23);
            this.txtRegistroSeleccionado.TabIndex = 10;
            //
            // lblVeredictoFinal
            //
            this.lblVeredictoFinal.AutoSize = true;
            this.lblVeredictoFinal.Location = new System.Drawing.Point(15, 71);
            this.lblVeredictoFinal.Name = "lblVeredictoFinal";
            this.lblVeredictoFinal.TabIndex = 11;
            this.lblVeredictoFinal.Text = "Veredicto Final:";
            //
            // rdoConforme
            //
            this.rdoConforme.AutoSize = true;
            this.rdoConforme.Location = new System.Drawing.Point(140, 67);
            this.rdoConforme.Name = "rdoConforme";
            this.rdoConforme.Size = new System.Drawing.Size(90, 19);
            this.rdoConforme.TabIndex = 12;
            this.rdoConforme.TabStop = false;
            this.rdoConforme.Text = "Conforme";
            this.rdoConforme.UseVisualStyleBackColor = true;
            //
            // rdoInvalidaDescuento
            //
            this.rdoInvalidaDescuento.AutoSize = true;
            this.rdoInvalidaDescuento.Location = new System.Drawing.Point(240, 67);
            this.rdoInvalidaDescuento.Name = "rdoInvalidaDescuento";
            this.rdoInvalidaDescuento.Size = new System.Drawing.Size(250, 19);
            this.rdoInvalidaDescuento.TabIndex = 13;
            this.rdoInvalidaDescuento.TabStop = false;
            this.rdoInvalidaDescuento.Text = "Inválida (Aplicar Descuento)";
            this.rdoInvalidaDescuento.UseVisualStyleBackColor = true;
            //
            // lblFechaDescuento
            //
            this.lblFechaDescuento.AutoSize = true;
            this.lblFechaDescuento.Location = new System.Drawing.Point(15, 108);
            this.lblFechaDescuento.Name = "lblFechaDescuento";
            this.lblFechaDescuento.TabIndex = 14;
            this.lblFechaDescuento.Text = "Fecha Descuento:";
            //
            // dtpFechaDescuento
            //
            this.dtpFechaDescuento.Location = new System.Drawing.Point(135, 102);
            this.dtpFechaDescuento.Name = "dtpFechaDescuento";
            this.dtpFechaDescuento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDescuento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDescuento.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaDescuento.TabIndex = 15;
            //
            // lblHorasInvalidas
            //
            this.lblHorasInvalidas.AutoSize = true;
            this.lblHorasInvalidas.Location = new System.Drawing.Point(320, 108);
            this.lblHorasInvalidas.Name = "lblHorasInvalidas";
            this.lblHorasInvalidas.TabIndex = 16;
            this.lblHorasInvalidas.Text = "Horas Inválidas:";
            //
            // numHorasInvalidas
            //
            this.numHorasInvalidas.Location = new System.Drawing.Point(430, 102);
            this.numHorasInvalidas.Name = "numHorasInvalidas";
            this.numHorasInvalidas.DecimalPlaces = 0;
            this.numHorasInvalidas.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numHorasInvalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHorasInvalidas.Size = new System.Drawing.Size(60, 23);
            this.numHorasInvalidas.TabIndex = 17;
            //
            // lblMonto
            //
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(530, 108);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.TabIndex = 18;
            this.lblMonto.Text = "Monto S/:";
            //
            // numMonto
            //
            this.numMonto.Location = new System.Drawing.Point(600, 102);
            this.numMonto.Name = "numMonto";
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMonto.Size = new System.Drawing.Size(100, 23);
            this.numMonto.TabIndex = 19;
            //
            // btnRegistrarVeredicto
            //
            this.btnRegistrarVeredicto.Location = new System.Drawing.Point(15, 148);
            this.btnRegistrarVeredicto.Name = "btnRegistrarVeredicto";
            this.btnRegistrarVeredicto.Size = new System.Drawing.Size(470, 30);
            this.btnRegistrarVeredicto.TabIndex = 20;
            this.btnRegistrarVeredicto.Text = "Registrar Veredicto, Aplicar Descuento y Notificar al Empleado";
            this.btnRegistrarVeredicto.UseVisualStyleBackColor = true;
            //
            // colIdAsistencia
            //
            this.colIdAsistencia.HeaderText = "ID Asis.";
            this.colIdAsistencia.Name = "colIdAsistencia";
            this.colIdAsistencia.ReadOnly = true;
            //
            // colEmpleado
            //
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            //
            // colFecha
            //
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            //
            // colHoras
            //
            this.colHoras.HeaderText = "Horas Ac.";
            this.colHoras.Name = "colHoras";
            this.colHoras.ReadOnly = true;
            //
            // colEstadoAsistencia
            //
            this.colEstadoAsistencia.HeaderText = "Estado Asistencia";
            this.colEstadoAsistencia.Name = "colEstadoAsistencia";
            this.colEstadoAsistencia.ReadOnly = true;
            //
            // frmCorePlanillaAsistencias
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 548);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.gbAsistencias);
            this.Controls.Add(this.gbVerificacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCorePlanillaAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE PLANILLA - 1. Revisión y Verificación de Asistencias (RF-01)";
            this.gbVerificacion.ResumeLayout(false);
            this.gbVerificacion.PerformLayout();
            this.gbAsistencias.ResumeLayout(false);
            this.gbAsistencias.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasInvalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpPeriodo;
        private System.Windows.Forms.Button btnFiltrarAsistencias;
        private System.Windows.Forms.GroupBox gbAsistencias;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Label lblAccionContador;
        private System.Windows.Forms.Button btnMarcarCuestionable;
        private System.Windows.Forms.GroupBox gbVerificacion;
        private System.Windows.Forms.Label lblRegistroSeleccionado;
        private System.Windows.Forms.TextBox txtRegistroSeleccionado;
        private System.Windows.Forms.Label lblVeredictoFinal;
        private System.Windows.Forms.RadioButton rdoConforme;
        private System.Windows.Forms.RadioButton rdoInvalidaDescuento;
        private System.Windows.Forms.Label lblFechaDescuento;
        private System.Windows.Forms.DateTimePicker dtpFechaDescuento;
        private System.Windows.Forms.Label lblHorasInvalidas;
        private System.Windows.Forms.NumericUpDown numHorasInvalidas;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.Button btnRegistrarVeredicto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoAsistencia;
    }
}
