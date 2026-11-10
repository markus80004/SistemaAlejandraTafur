namespace CapaPresentacion
{
    partial class frmMantenedorPuestosTrabajo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.numTarifa = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPuestosTrabajo = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestosTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarifa)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblArea);
            this.gbDatos.Controls.Add(this.cboArea);
            this.gbDatos.Controls.Add(this.lblTarifa);
            this.gbDatos.Controls.Add(this.numTarifa);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 171);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Puesto de Trabajo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(15, 92);
            this.lblArea.Name = "lblArea";
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Área:";
            // 
            // cboArea
            // 
            this.cboArea.Location = new System.Drawing.Point(140, 89);
            this.cboArea.Name = "cboArea";
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Size = new System.Drawing.Size(230, 23);
            this.cboArea.TabIndex = 6;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(390, 92);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.TabIndex = 7;
            this.lblTarifa.Text = "Tarifa por Hora / Sueldo (S/):";
            // 
            // numTarifa
            // 
            this.numTarifa.Location = new System.Drawing.Point(560, 89);
            this.numTarifa.Name = "numTarifa";
            this.numTarifa.DecimalPlaces = 2;
            this.numTarifa.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numTarifa.Size = new System.Drawing.Size(120, 23);
            this.numTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTarifa.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 126);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 126);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 11;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvPuestosTrabajo
            // 
            this.dgvPuestosTrabajo.AllowUserToAddRows = false;
            this.dgvPuestosTrabajo.AllowUserToDeleteRows = false;
            this.dgvPuestosTrabajo.AllowUserToResizeRows = false;
            this.dgvPuestosTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestosTrabajo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPuestosTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestosTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colArea,
            this.colTarifa,
            this.colEstado});
            this.dgvPuestosTrabajo.Location = new System.Drawing.Point(12, 195);
            this.dgvPuestosTrabajo.MultiSelect = false;
            this.dgvPuestosTrabajo.Name = "dgvPuestosTrabajo";
            this.dgvPuestosTrabajo.ReadOnly = true;
            this.dgvPuestosTrabajo.RowHeadersVisible = false;
            this.dgvPuestosTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestosTrabajo.Size = new System.Drawing.Size(726, 230);
            this.dgvPuestosTrabajo.TabIndex = 13;
            this.dgvPuestosTrabajo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuestosTrabajo_CellDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre del Puesto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colTarifa
            // 
            this.colTarifa.HeaderText = "Tarifa/Sdo";
            this.colTarifa.Name = "colTarifa";
            this.colTarifa.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Est.";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // frmMantenedorPuestosTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 437);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvPuestosTrabajo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorPuestosTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE PUESTOS DE TRABAJO";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestosTrabajo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.NumericUpDown numTarifa;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPuestosTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
