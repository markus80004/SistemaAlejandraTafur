namespace CapaPresentacion
{
    partial class frmMenuPrincipal
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
            this.gbMantenedores = new System.Windows.Forms.GroupBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btnTiposTurno = new System.Windows.Forms.Button();
            this.btnTipoAusencia = new System.Windows.Forms.Button();
            this.btnPuestosTrabajo = new System.Windows.Forms.Button();
            this.btnConceptoBonoDescuento = new System.Windows.Forms.Button();
            this.btnTipoDesvinculacion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.gbMantenedores.SuspendLayout();
            this.SuspendLayout();
            //
            // gbMantenedores
            //
            this.gbMantenedores.Controls.Add(this.btnEmpleados);
            this.gbMantenedores.Controls.Add(this.btnAreas);
            this.gbMantenedores.Controls.Add(this.btnContratos);
            this.gbMantenedores.Controls.Add(this.btnTiposTurno);
            this.gbMantenedores.Controls.Add(this.btnTipoAusencia);
            this.gbMantenedores.Controls.Add(this.btnPuestosTrabajo);
            this.gbMantenedores.Controls.Add(this.btnConceptoBonoDescuento);
            this.gbMantenedores.Controls.Add(this.btnTipoDesvinculacion);
            this.gbMantenedores.Location = new System.Drawing.Point(20, 52);
            this.gbMantenedores.Name = "gbMantenedores";
            this.gbMantenedores.Size = new System.Drawing.Size(600, 300);
            this.gbMantenedores.TabIndex = 0;
            this.gbMantenedores.TabStop = false;
            this.gbMantenedores.Text = "Mantenedores";
            //
            // btnEmpleados
            //
            this.btnEmpleados.Location = new System.Drawing.Point(20, 28);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(270, 46);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            //
            // btnAreas
            //
            this.btnAreas.Location = new System.Drawing.Point(310, 28);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(270, 46);
            this.btnAreas.TabIndex = 2;
            this.btnAreas.Text = "Áreas";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            //
            // btnContratos
            //
            this.btnContratos.Location = new System.Drawing.Point(20, 86);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(270, 46);
            this.btnContratos.TabIndex = 3;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            //
            // btnTiposTurno
            //
            this.btnTiposTurno.Location = new System.Drawing.Point(310, 86);
            this.btnTiposTurno.Name = "btnTiposTurno";
            this.btnTiposTurno.Size = new System.Drawing.Size(270, 46);
            this.btnTiposTurno.TabIndex = 4;
            this.btnTiposTurno.Text = "Tipos de Turno";
            this.btnTiposTurno.UseVisualStyleBackColor = true;
            this.btnTiposTurno.Click += new System.EventHandler(this.btnTiposTurno_Click);
            //
            // btnTipoAusencia
            //
            this.btnTipoAusencia.Location = new System.Drawing.Point(20, 144);
            this.btnTipoAusencia.Name = "btnTipoAusencia";
            this.btnTipoAusencia.Size = new System.Drawing.Size(270, 46);
            this.btnTipoAusencia.TabIndex = 5;
            this.btnTipoAusencia.Text = "Tipo de Ausencia";
            this.btnTipoAusencia.UseVisualStyleBackColor = true;
            this.btnTipoAusencia.Click += new System.EventHandler(this.btnTipoAusencia_Click);
            //
            // btnPuestosTrabajo
            //
            this.btnPuestosTrabajo.Location = new System.Drawing.Point(310, 144);
            this.btnPuestosTrabajo.Name = "btnPuestosTrabajo";
            this.btnPuestosTrabajo.Size = new System.Drawing.Size(270, 46);
            this.btnPuestosTrabajo.TabIndex = 6;
            this.btnPuestosTrabajo.Text = "Puestos de Trabajo";
            this.btnPuestosTrabajo.UseVisualStyleBackColor = true;
            this.btnPuestosTrabajo.Click += new System.EventHandler(this.btnPuestosTrabajo_Click);
            //
            // btnConceptoBonoDescuento
            //
            this.btnConceptoBonoDescuento.Location = new System.Drawing.Point(20, 202);
            this.btnConceptoBonoDescuento.Name = "btnConceptoBonoDescuento";
            this.btnConceptoBonoDescuento.Size = new System.Drawing.Size(270, 46);
            this.btnConceptoBonoDescuento.TabIndex = 7;
            this.btnConceptoBonoDescuento.Text = "Concepto de Bono y Descuento";
            this.btnConceptoBonoDescuento.UseVisualStyleBackColor = true;
            this.btnConceptoBonoDescuento.Click += new System.EventHandler(this.btnConceptoBonoDescuento_Click);
            //
            // btnTipoDesvinculacion
            //
            this.btnTipoDesvinculacion.Location = new System.Drawing.Point(310, 202);
            this.btnTipoDesvinculacion.Name = "btnTipoDesvinculacion";
            this.btnTipoDesvinculacion.Size = new System.Drawing.Size(270, 46);
            this.btnTipoDesvinculacion.TabIndex = 8;
            this.btnTipoDesvinculacion.Text = "Tipo de Desvinculación";
            this.btnTipoDesvinculacion.UseVisualStyleBackColor = true;
            this.btnTipoDesvinculacion.Click += new System.EventHandler(this.btnTipoDesvinculacion_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "MENÚ PRINCIPAL";
            //
            // lblUsuarioActivo
            //
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(470, 20);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.TabIndex = 10;
            this.lblUsuarioActivo.Text = "Usuario: ";
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.Location = new System.Drawing.Point(450, 372);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 34);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // frmMenuPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 424);
            this.Controls.Add(this.gbMantenedores);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.btnCerrarSesion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - Sistema";
            this.gbMantenedores.ResumeLayout(false);
            this.gbMantenedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbMantenedores;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnTiposTurno;
        private System.Windows.Forms.Button btnTipoAusencia;
        private System.Windows.Forms.Button btnPuestosTrabajo;
        private System.Windows.Forms.Button btnConceptoBonoDescuento;
        private System.Windows.Forms.Button btnTipoDesvinculacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
