namespace CapaPresentacion
{
    partial class frmMantenedorConceptoBonoDescuento
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoConcepto = new System.Windows.Forms.Label();
            this.rdoBono = new System.Windows.Forms.RadioButton();
            this.rdoDescuento = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvConceptoBonoDescuento = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptoBonoDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblTipoConcepto);
            this.gbDatos.Controls.Add(this.rdoBono);
            this.gbDatos.Controls.Add(this.rdoDescuento);
            this.gbDatos.Controls.Add(this.lblValor);
            this.gbDatos.Controls.Add(this.numValor);
            this.gbDatos.Controls.Add(this.lblUnidad);
            this.gbDatos.Controls.Add(this.cboUnidad);
            this.gbDatos.Controls.Add(this.btnRegistrar);
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.btnInhabilitar);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(726, 171);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Concepto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Concepto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTipoConcepto
            // 
            this.lblTipoConcepto.AutoSize = true;
            this.lblTipoConcepto.Location = new System.Drawing.Point(15, 60);
            this.lblTipoConcepto.Name = "lblTipoConcepto";
            this.lblTipoConcepto.TabIndex = 3;
            this.lblTipoConcepto.Text = "Tipo de Concepto:";
            // 
            // rdoBono
            // 
            this.rdoBono.AutoSize = true;
            this.rdoBono.Location = new System.Drawing.Point(140, 58);
            this.rdoBono.Name = "rdoBono";
            this.rdoBono.Size = new System.Drawing.Size(70, 19);
            this.rdoBono.TabIndex = 4;
            this.rdoBono.Checked = true;
            this.rdoBono.TabStop = true;
            this.rdoBono.Text = "Bono";
            this.rdoBono.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento
            // 
            this.rdoDescuento.AutoSize = true;
            this.rdoDescuento.Location = new System.Drawing.Point(230, 58);
            this.rdoDescuento.Name = "rdoDescuento";
            this.rdoDescuento.Size = new System.Drawing.Size(90, 19);
            this.rdoDescuento.TabIndex = 5;
            this.rdoDescuento.TabStop = false;
            this.rdoDescuento.Text = "Descuento";
            this.rdoDescuento.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 92);
            this.lblValor.Name = "lblValor";
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor (Monto / %):";
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(140, 89);
            this.numValor.Name = "numValor";
            this.numValor.DecimalPlaces = 2;
            this.numValor.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numValor.Size = new System.Drawing.Size(110, 23);
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numValor.TabIndex = 7;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(390, 92);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.TabIndex = 8;
            this.lblUnidad.Text = "Unidad:";
            // 
            // cboUnidad
            // 
            this.cboUnidad.Location = new System.Drawing.Point(560, 89);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Items.AddRange(new object[] {
            "Monto Fijo (S/)",
            "Porcentaje (%)"});
            this.cboUnidad.Size = new System.Drawing.Size(150, 23);
            this.cboUnidad.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 126);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(105, 30);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 126);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(245, 126);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(105, 30);
            this.btnInhabilitar.TabIndex = 12;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 126);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 30);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvConceptoBonoDescuento
            // 
            this.dgvConceptoBonoDescuento.AllowUserToAddRows = false;
            this.dgvConceptoBonoDescuento.AllowUserToDeleteRows = false;
            this.dgvConceptoBonoDescuento.AllowUserToResizeRows = false;
            this.dgvConceptoBonoDescuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptoBonoDescuento.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvConceptoBonoDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptoBonoDescuento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colTipo,
            this.colMonto,
            this.colEstado});
            this.dgvConceptoBonoDescuento.Location = new System.Drawing.Point(12, 195);
            this.dgvConceptoBonoDescuento.MultiSelect = false;
            this.dgvConceptoBonoDescuento.Name = "dgvConceptoBonoDescuento";
            this.dgvConceptoBonoDescuento.ReadOnly = true;
            this.dgvConceptoBonoDescuento.RowHeadersVisible = false;
            this.dgvConceptoBonoDescuento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConceptoBonoDescuento.Size = new System.Drawing.Size(726, 230);
            this.dgvConceptoBonoDescuento.TabIndex = 14;
            this.dgvConceptoBonoDescuento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConceptoBonoDescuento_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre del Concepto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto / %";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Est.";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // frmMantenedorConceptoBonoDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 437);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvConceptoBonoDescuento);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenedorConceptoBonoDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENEDOR DE CONCEPTO DE BONO Y DESCUENTO";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptoBonoDescuento)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoConcepto;
        private System.Windows.Forms.RadioButton rdoBono;
        private System.Windows.Forms.RadioButton rdoDescuento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvConceptoBonoDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}
