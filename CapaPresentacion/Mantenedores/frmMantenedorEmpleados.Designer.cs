namespace CapaPresentacion
{
    partial class frmMantenedorEmpleados
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
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.rdoFijo = new System.Windows.Forms.RadioButton();
            this.rdoEventual = new System.Windows.Forms.RadioButton();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.numSueldoBase = new System.Windows.Forms.NumericUpDown();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCuentaBancaria = new System.Windows.Forms.Label();
            this.txtCuentaBancaria = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Controls.Add(this.txtDni);
            this.gbDatos.Controls.Add(this.lblFechaIngreso);
            this.gbDatos.Controls.Add(this.dtpFechaIngreso);
            this.gbDatos.Controls.Add(this.lblNombres);
            this.gbDatos.Controls.Add(this.txtNombres);
            this.gbDatos.Controls.Add(this.lblApellidos);
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.lblArea);
            this.gbDatos.Controls.Add(this.cboArea);
            this.gbDatos.Controls.Add(this.lblCondicion);
            this.gbDatos.Controls.Add(this.rdoFijo);
            this.gbDatos.Controls.Add(this.rdoEventual);
            this.gbDatos.Controls.Add(this.lblPuesto);
            this.gbDatos.Controls.Add(this.cboPuesto);
            this.gbDatos.Controls.Add(this.lblSueldoBase);
            this.gbDatos.Controls.Add(this.numSueldoBase);
            this.gbDatos.Controls.Add(this.lblCorreo);
            this.gbDatos.Controls.Add(this.txtCorreo);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.lblCuentaBancaria);
            this.gbDatos.Controls.Add(this.txtCuentaBancaria);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 299);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Empleado";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(15, 28);
            this.lblDni.Name = "lblDni";
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(140, 25);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(110, 23);
            this.txtDni.TabIndex = 2;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(390, 28);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(560, 25);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Size = new System.Drawing.Size(150, 23);
            this.dtpFechaIngreso.TabIndex = 4;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(15, 60);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.TabIndex = 5;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(140, 57);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(230, 23);
            this.txtNombres.TabIndex = 6;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(15, 92);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.TabIndex = 7;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 89);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(230, 23);
            this.txtApellidos.TabIndex = 8;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(15, 124);
            this.lblArea.Name = "lblArea";
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Área:";
            // 
            // cboArea
            // 
            this.cboArea.Location = new System.Drawing.Point(140, 121);
            this.cboArea.Name = "cboArea";
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Size = new System.Drawing.Size(230, 23);
            this.cboArea.TabIndex = 10;
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(390, 124);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.TabIndex = 11;
            this.lblCondicion.Text = "Condición:";
            // 
            // rdoFijo
            // 
            this.rdoFijo.AutoSize = true;
            this.rdoFijo.Location = new System.Drawing.Point(560, 122);
            this.rdoFijo.Name = "rdoFijo";
            this.rdoFijo.Size = new System.Drawing.Size(60, 19);
            this.rdoFijo.TabIndex = 12;
            this.rdoFijo.Checked = true;
            this.rdoFijo.TabStop = true;
            this.rdoFijo.Text = "Fijo";
            this.rdoFijo.UseVisualStyleBackColor = true;
            // 
            // rdoEventual
            // 
            this.rdoEventual.AutoSize = true;
            this.rdoEventual.Location = new System.Drawing.Point(630, 122);
            this.rdoEventual.Name = "rdoEventual";
            this.rdoEventual.Size = new System.Drawing.Size(80, 19);
            this.rdoEventual.TabIndex = 13;
            this.rdoEventual.TabStop = false;
            this.rdoEventual.Text = "Eventual";
            this.rdoEventual.UseVisualStyleBackColor = true;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(15, 156);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.TabIndex = 14;
            this.lblPuesto.Text = "Puesto / Cargo:";
            // 
            // cboPuesto
            // 
            this.cboPuesto.Location = new System.Drawing.Point(140, 153);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Size = new System.Drawing.Size(230, 23);
            this.cboPuesto.TabIndex = 15;
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Location = new System.Drawing.Point(390, 156);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.TabIndex = 16;
            this.lblSueldoBase.Text = "Sueldo Base:";
            // 
            // numSueldoBase
            // 
            this.numSueldoBase.Location = new System.Drawing.Point(560, 153);
            this.numSueldoBase.Name = "numSueldoBase";
            this.numSueldoBase.DecimalPlaces = 2;
            this.numSueldoBase.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numSueldoBase.Size = new System.Drawing.Size(150, 23);
            this.numSueldoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSueldoBase.TabIndex = 17;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(15, 188);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(140, 185);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 23);
            this.txtCorreo.TabIndex = 19;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(390, 188);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(560, 185);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.TabIndex = 21;
            // 
            // lblCuentaBancaria
            // 
            this.lblCuentaBancaria.AutoSize = true;
            this.lblCuentaBancaria.Location = new System.Drawing.Point(15, 220);
            this.lblCuentaBancaria.Name = "lblCuentaBancaria";
            this.lblCuentaBancaria.TabIndex = 22;
            this.lblCuentaBancaria.Text = "Cuenta Bancaria:";
            // 
            // txtCuentaBancaria
            // 
            this.txtCuentaBancaria.Location = new System.Drawing.Point(140, 217);
            this.txtCuentaBancaria.Name = "txtCuentaBancaria";
            this.txtCuentaBancaria.Size = new System.Drawing.Size(370, 23);
            this.txtCuentaBancaria.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 254);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 254);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 254);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 26;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 254);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(15, 326);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.TabIndex = 28;
            this.lblBuscar.Text = "Buscar por DNI/Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(170, 323);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(230, 23);
            this.txtBuscar.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(410, 322);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colEmpleado,
            this.colArea,
            this.colPuesto,
            this.colCondicion,
            this.colEstado});
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 359);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(726, 230);
            this.dgvEmpleados.TabIndex = 31;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colPuesto
            // 
            this.colPuesto.HeaderText = "Puesto";
            this.colPuesto.Name = "colPuesto";
            this.colPuesto.ReadOnly = true;
            // 
            // colCondicion
            // 
            this.colCondicion.HeaderText = "Condición";
            this.colCondicion.Name = "colCondicion";
            this.colCondicion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Est.";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // frmMantenedorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 601);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvEmpleados);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE EMPLEADOS";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.RadioButton rdoFijo;
        private System.Windows.Forms.RadioButton rdoEventual;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.NumericUpDown numSueldoBase;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCuentaBancaria;
        private System.Windows.Forms.TextBox txtCuentaBancaria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
