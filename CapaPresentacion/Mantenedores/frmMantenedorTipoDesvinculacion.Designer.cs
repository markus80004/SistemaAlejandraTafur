namespace CapaPresentacion
{
    partial class frmMantenedorTipoDesvinculacion
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblReglaFlujo = new System.Windows.Forms.Label();
            this.chkRequiereCarta = new System.Windows.Forms.CheckBox();
            this.chkRequiereSubgerencia = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvTipoDesvinculacion = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReqCarta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReqSubger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDesvinculacion)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lblReglaFlujo);
            this.gbDatos.Controls.Add(this.chkRequiereCarta);
            this.gbDatos.Controls.Add(this.chkRequiereSubgerencia);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 241);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Tipo de Desvinculación";
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
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(140, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(570, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblReglaFlujo
            // 
            this.lblReglaFlujo.AutoSize = true;
            this.lblReglaFlujo.Location = new System.Drawing.Point(15, 124);
            this.lblReglaFlujo.Name = "lblReglaFlujo";
            this.lblReglaFlujo.TabIndex = 7;
            this.lblReglaFlujo.Text = "Regla de Flujo (Indicador):";
            // 
            // chkRequiereCarta
            // 
            this.chkRequiereCarta.AutoSize = true;
            this.chkRequiereCarta.Location = new System.Drawing.Point(160, 149);
            this.chkRequiereCarta.Name = "chkRequiereCarta";
            this.chkRequiereCarta.Size = new System.Drawing.Size(220, 19);
            this.chkRequiereCarta.TabIndex = 8;
            this.chkRequiereCarta.Text = "Requiere Carta de Renuncia";
            this.chkRequiereCarta.UseVisualStyleBackColor = true;
            // 
            // chkRequiereSubgerencia
            // 
            this.chkRequiereSubgerencia.AutoSize = true;
            this.chkRequiereSubgerencia.Location = new System.Drawing.Point(160, 173);
            this.chkRequiereSubgerencia.Name = "chkRequiereSubgerencia";
            this.chkRequiereSubgerencia.Size = new System.Drawing.Size(320, 19);
            this.chkRequiereSubgerencia.TabIndex = 9;
            this.chkRequiereSubgerencia.Text = "Requiere Aprobación de Subgerencia General";
            this.chkRequiereSubgerencia.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 196);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 196);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 196);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 12;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 196);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvTipoDesvinculacion
            // 
            this.dgvTipoDesvinculacion.AllowUserToAddRows = false;
            this.dgvTipoDesvinculacion.AllowUserToDeleteRows = false;
            this.dgvTipoDesvinculacion.AllowUserToResizeRows = false;
            this.dgvTipoDesvinculacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoDesvinculacion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTipoDesvinculacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDesvinculacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colReqCarta,
            this.colReqSubger,
            this.colEstado});
            this.dgvTipoDesvinculacion.Location = new System.Drawing.Point(12, 265);
            this.dgvTipoDesvinculacion.MultiSelect = false;
            this.dgvTipoDesvinculacion.Name = "dgvTipoDesvinculacion";
            this.dgvTipoDesvinculacion.ReadOnly = true;
            this.dgvTipoDesvinculacion.RowHeadersVisible = false;
            this.dgvTipoDesvinculacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoDesvinculacion.Size = new System.Drawing.Size(726, 230);
            this.dgvTipoDesvinculacion.TabIndex = 14;
            this.dgvTipoDesvinculacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoDesvinculacion_CellDoubleClick);
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
            // colReqCarta
            // 
            this.colReqCarta.HeaderText = "Req. Carta";
            this.colReqCarta.Name = "colReqCarta";
            this.colReqCarta.ReadOnly = true;
            // 
            // colReqSubger
            // 
            this.colReqSubger.HeaderText = "Req. Subger.";
            this.colReqSubger.Name = "colReqSubger";
            this.colReqSubger.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Est.";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // frmMantenedorTipoDesvinculacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 507);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvTipoDesvinculacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorTipoDesvinculacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE TIPO DE DESVINCULACIÓN";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDesvinculacion)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblReglaFlujo;
        private System.Windows.Forms.CheckBox chkRequiereCarta;
        private System.Windows.Forms.CheckBox chkRequiereSubgerencia;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvTipoDesvinculacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqCarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqSubger;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
