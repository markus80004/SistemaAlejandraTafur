namespace CapaPresentacion
{
    partial class frmMantenedorContratos
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblHorasSemanales = new System.Windows.Forms.Label();
            this.numHorasSemanales = new System.Windows.Forms.NumericUpDown();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasSemanales)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblEmpleado);
            this.gbDatos.Controls.Add(this.cboEmpleado);
            this.gbDatos.Controls.Add(this.lblTipoContrato);
            this.gbDatos.Controls.Add(this.cboTipoContrato);
            this.gbDatos.Controls.Add(this.lblHorasSemanales);
            this.gbDatos.Controls.Add(this.numHorasSemanales);
            this.gbDatos.Controls.Add(this.lblFechaInicio);
            this.gbDatos.Controls.Add(this.dtpFechaInicio);
            this.gbDatos.Controls.Add(this.lblFechaFin);
            this.gbDatos.Controls.Add(this.dtpFechaFin);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 171);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Contrato";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 28);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.TabIndex = 1;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.Location = new System.Drawing.Point(140, 25);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Size = new System.Drawing.Size(300, 23);
            this.cboEmpleado.TabIndex = 2;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(15, 60);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.TabIndex = 3;
            this.lblTipoContrato.Text = "Tipo de Contrato:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.Location = new System.Drawing.Point(140, 57);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "Plazo Fijo",
            "Plazo Indeterminado",
            "Tiempo Parcial",
            "Eventual"});
            this.cboTipoContrato.Size = new System.Drawing.Size(230, 23);
            this.cboTipoContrato.TabIndex = 4;
            // 
            // lblHorasSemanales
            // 
            this.lblHorasSemanales.AutoSize = true;
            this.lblHorasSemanales.Location = new System.Drawing.Point(390, 60);
            this.lblHorasSemanales.Name = "lblHorasSemanales";
            this.lblHorasSemanales.TabIndex = 5;
            this.lblHorasSemanales.Text = "Horas Semanales:";
            // 
            // numHorasSemanales
            // 
            this.numHorasSemanales.Location = new System.Drawing.Point(560, 57);
            this.numHorasSemanales.Name = "numHorasSemanales";
            this.numHorasSemanales.DecimalPlaces = 0;
            this.numHorasSemanales.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            this.numHorasSemanales.Size = new System.Drawing.Size(80, 23);
            this.numHorasSemanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHorasSemanales.Value = new decimal(new int[] { 48, 0, 0, 0 });
            this.numHorasSemanales.TabIndex = 6;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 92);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(140, 89);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaInicio.TabIndex = 8;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(390, 92);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.TabIndex = 9;
            this.lblFechaFin.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(560, 89);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.ShowCheckBox = true;
            this.dtpFechaFin.Checked = false;
            this.dtpFechaFin.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaFin.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 126);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 126);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 13;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToAddRows = false;
            this.dgvContratos.AllowUserToDeleteRows = false;
            this.dgvContratos.AllowUserToResizeRows = false;
            this.dgvContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContratos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEmpleado,
            this.colTipoContrato,
            this.colFechaInicio,
            this.colFechaFin,
            this.colHoras});
            this.dgvContratos.Location = new System.Drawing.Point(12, 195);
            this.dgvContratos.MultiSelect = false;
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.ReadOnly = true;
            this.dgvContratos.RowHeadersVisible = false;
            this.dgvContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContratos.Size = new System.Drawing.Size(726, 230);
            this.dgvContratos.TabIndex = 15;
            this.dgvContratos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContratos_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            // 
            // colTipoContrato
            // 
            this.colTipoContrato.HeaderText = "Tipo Contrato";
            this.colTipoContrato.Name = "colTipoContrato";
            this.colTipoContrato.ReadOnly = true;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.HeaderText = "F. Inicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            // 
            // colFechaFin
            // 
            this.colFechaFin.HeaderText = "F. Fin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.ReadOnly = true;
            // 
            // colHoras
            // 
            this.colHoras.HeaderText = "Hs";
            this.colHoras.Name = "colHoras";
            this.colHoras.ReadOnly = true;
            // 
            // frmMantenedorContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 437);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvContratos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorContratos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE CONTRATOS";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHorasSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.Label lblHorasSemanales;
        private System.Windows.Forms.NumericUpDown numHorasSemanales;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoras;
    }
}
