namespace CapaPresentacion
{
    partial class frmMantenedorTiposTurno
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
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblAutocalculado = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvTiposTurno = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTurno)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblHoraEntrada);
            this.gbDatos.Controls.Add(this.dtpHoraEntrada);
            this.gbDatos.Controls.Add(this.lblHoraSalida);
            this.gbDatos.Controls.Add(this.dtpHoraSalida);
            this.gbDatos.Controls.Add(this.lblDuracion);
            this.gbDatos.Controls.Add(this.txtDuracion);
            this.gbDatos.Controls.Add(this.lblAutocalculado);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 203);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Tipo de Turno";
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
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(15, 92);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.TabIndex = 5;
            this.lblHoraEntrada.Text = "Hora Entrada:";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Location = new System.Drawing.Point(140, 89);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.CustomFormat = "HH:mm";
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.ValueChanged += new System.EventHandler(this.dtpHoraEntrada_ValueChanged);
            this.dtpHoraEntrada.Size = new System.Drawing.Size(80, 23);
            this.dtpHoraEntrada.TabIndex = 6;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(390, 92);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.TabIndex = 7;
            this.lblHoraSalida.Text = "Hora Salida:";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Location = new System.Drawing.Point(560, 89);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.CustomFormat = "HH:mm";
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.ValueChanged += new System.EventHandler(this.dtpHoraSalida_ValueChanged);
            this.dtpHoraSalida.Size = new System.Drawing.Size(80, 23);
            this.dtpHoraSalida.TabIndex = 8;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(15, 124);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.TabIndex = 9;
            this.lblDuracion.Text = "Duración (h):";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(140, 121);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(110, 23);
            this.txtDuracion.TabIndex = 10;
            // 
            // lblAutocalculado
            // 
            this.lblAutocalculado.AutoSize = true;
            this.lblAutocalculado.Location = new System.Drawing.Point(260, 124);
            this.lblAutocalculado.Name = "lblAutocalculado";
            this.lblAutocalculado.TabIndex = 11;
            this.lblAutocalculado.Text = "(Autocalculado)";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 158);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 158);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 158);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 14;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTiposTurno
            // 
            this.dgvTiposTurno.AllowUserToAddRows = false;
            this.dgvTiposTurno.AllowUserToDeleteRows = false;
            this.dgvTiposTurno.AllowUserToResizeRows = false;
            this.dgvTiposTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposTurno.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTiposTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colEntrada,
            this.colSalida,
            this.colDuracion,
            this.colEstado});
            this.dgvTiposTurno.Location = new System.Drawing.Point(12, 227);
            this.dgvTiposTurno.MultiSelect = false;
            this.dgvTiposTurno.Name = "dgvTiposTurno";
            this.dgvTiposTurno.ReadOnly = true;
            this.dgvTiposTurno.RowHeadersVisible = false;
            this.dgvTiposTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposTurno.Size = new System.Drawing.Size(726, 230);
            this.dgvTiposTurno.TabIndex = 16;
            this.dgvTiposTurno.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposTurno_CellDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colEntrada
            // 
            this.colEntrada.HeaderText = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.ReadOnly = true;
            // 
            // colSalida
            // 
            this.colSalida.HeaderText = "Salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.ReadOnly = true;
            // 
            // colDuracion
            // 
            this.colDuracion.HeaderText = "Duración";
            this.colDuracion.Name = "colDuracion";
            this.colDuracion.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Est.";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // frmMantenedorTiposTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 469);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvTiposTurno);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorTiposTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE TIPOS DE TURNO";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTurno)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblAutocalculado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvTiposTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
