namespace CapaPresentacion
{
    partial class frmCoreTurnos
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
            this.tcTurnos = new System.Windows.Forms.TabControl();
            this.tpDefinirTurnos = new System.Windows.Forms.TabPage();
            this.gbEmpleadoContrato = new System.Windows.Forms.GroupBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lblContratoVigente = new System.Windows.Forms.Label();
            this.txtContratoVigente = new System.Windows.Forms.TextBox();
            this.lblHorasAsignadas = new System.Windows.Forms.Label();
            this.txtHorasAsignadas = new System.Windows.Forms.TextBox();
            this.lblEstadoCobertura = new System.Windows.Forms.Label();
            this.txtEstadoCobertura = new System.Windows.Forms.TextBox();
            this.gbAsignarTurno = new System.Windows.Forms.GroupBox();
            this.lblFechaTurno = new System.Windows.Forms.Label();
            this.dtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.lblTipoTurno = new System.Windows.Forms.Label();
            this.cboTipoTurno = new System.Windows.Forms.ComboBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.gbTurnosAsignados = new System.Windows.Forms.GroupBox();
            this.dgvTurnosAsignados = new System.Windows.Forms.DataGridView();
            this.lblMotivoModificacion = new System.Windows.Forms.Label();
            this.txtMotivoModificacion = new System.Windows.Forms.TextBox();
            this.btnModificarTurno = new System.Windows.Forms.Button();
            this.btnAnularTurno = new System.Windows.Forms.Button();
            this.btnPasarHorasExtra = new System.Windows.Forms.Button();
            this.tpHorasExtra = new System.Windows.Forms.TabPage();
            this.gbMenorTurnos = new System.Windows.Forms.GroupBox();
            this.dgvEmpleadosMenorTurnos = new System.Windows.Forms.DataGridView();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblTurnoPropuesto = new System.Windows.Forms.Label();
            this.cboTurnoPropuesto = new System.Windows.Forms.ComboBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.rdoAcepta = new System.Windows.Forms.RadioButton();
            this.rdoNoAcepta = new System.Windows.Forms.RadioButton();
            this.btnAgregarTurnoExtra = new System.Windows.Forms.Button();
            this.btnVerificarDisponibles = new System.Windows.Forms.Button();
            this.lblSiNadieAcepta = new System.Windows.Forms.Label();
            this.btnDerivarSubgerencia = new System.Windows.Forms.Button();
            this.tpReclutamiento = new System.Windows.Forms.TabPage();
            this.gbSolicitudCobertura = new System.Windows.Forms.GroupBox();
            this.lblFechaSolicitud = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblTurnosPendientes = new System.Windows.Forms.Label();
            this.numTurnosPendientes = new System.Windows.Forms.NumericUpDown();
            this.btnIniciarReclutamiento = new System.Windows.Forms.Button();
            this.gbEncontroEmpleado = new System.Windows.Forms.GroupBox();
            this.rdoSiEncontro = new System.Windows.Forms.RadioButton();
            this.btnIrDefinirTurnos = new System.Windows.Forms.Button();
            this.rdoNoEncontro = new System.Windows.Forms.RadioButton();
            this.lblPeriodoReduccion = new System.Windows.Forms.Label();
            this.dtpPeriodoReduccion = new System.Windows.Forms.DateTimePicker();
            this.lblMotivoReduccion = new System.Windows.Forms.Label();
            this.txtMotivoReduccion = new System.Windows.Forms.TextBox();
            this.btnRegistrarReduccion = new System.Windows.Forms.Button();
            this.tpEnvio = new System.Windows.Forms.TabPage();
            this.gbConsolidadoMensual = new System.Windows.Forms.GroupBox();
            this.lblPeriodoEnvio = new System.Windows.Forms.Label();
            this.dtpPeriodoEnvio = new System.Windows.Forms.DateTimePicker();
            this.btnGraficarHorario = new System.Windows.Forms.Button();
            this.dgvHorarioMensual = new System.Windows.Forms.DataGridView();
            this.lblEstadoHorario = new System.Windows.Forms.Label();
            this.txtEstadoHorario = new System.Windows.Forms.TextBox();
            this.btnEnviarHorario = new System.Windows.Forms.Button();
            this.lblMotivoAnulacionHorario = new System.Windows.Forms.Label();
            this.txtMotivoAnulacionHorario = new System.Windows.Forms.TextBox();
            this.btnAnularHorario = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurnosMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosMenorTurnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurnosPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioMensual)).BeginInit();
            this.tcTurnos.SuspendLayout();
            this.tpDefinirTurnos.SuspendLayout();
            this.gbEmpleadoContrato.SuspendLayout();
            this.gbAsignarTurno.SuspendLayout();
            this.gbTurnosAsignados.SuspendLayout();
            this.tpHorasExtra.SuspendLayout();
            this.gbMenorTurnos.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.tpReclutamiento.SuspendLayout();
            this.gbSolicitudCobertura.SuspendLayout();
            this.gbEncontroEmpleado.SuspendLayout();
            this.tpEnvio.SuspendLayout();
            this.gbConsolidadoMensual.SuspendLayout();
            this.SuspendLayout();
            //
            // tcTurnos
            //
            this.tcTurnos.Controls.Add(this.tpDefinirTurnos);
            this.tcTurnos.Controls.Add(this.tpHorasExtra);
            this.tcTurnos.Controls.Add(this.tpReclutamiento);
            this.tcTurnos.Controls.Add(this.tpEnvio);
            this.tcTurnos.SelectedIndex = 0;
            this.tcTurnos.Location = new System.Drawing.Point(12, 12);
            this.tcTurnos.Name = "tcTurnos";
            this.tcTurnos.Size = new System.Drawing.Size(836, 596);
            this.tcTurnos.TabIndex = 0;
            //
            // tpDefinirTurnos
            //
            this.tpDefinirTurnos.Controls.Add(this.gbEmpleadoContrato);
            this.tpDefinirTurnos.Controls.Add(this.gbAsignarTurno);
            this.tpDefinirTurnos.Controls.Add(this.gbTurnosAsignados);
            this.tpDefinirTurnos.Location = new System.Drawing.Point(4, 24);
            this.tpDefinirTurnos.Name = "tpDefinirTurnos";
            this.tpDefinirTurnos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDefinirTurnos.Size = new System.Drawing.Size(828, 568);
            this.tpDefinirTurnos.TabIndex = 1;
            this.tpDefinirTurnos.Text = "1. Definir Turnos (RF-01)";
            this.tpDefinirTurnos.UseVisualStyleBackColor = true;
            //
            // gbEmpleadoContrato
            //
            this.gbEmpleadoContrato.Controls.Add(this.lblEmpleado);
            this.gbEmpleadoContrato.Controls.Add(this.cboEmpleado);
            this.gbEmpleadoContrato.Controls.Add(this.lblContratoVigente);
            this.gbEmpleadoContrato.Controls.Add(this.txtContratoVigente);
            this.gbEmpleadoContrato.Controls.Add(this.lblHorasAsignadas);
            this.gbEmpleadoContrato.Controls.Add(this.txtHorasAsignadas);
            this.gbEmpleadoContrato.Controls.Add(this.lblEstadoCobertura);
            this.gbEmpleadoContrato.Controls.Add(this.txtEstadoCobertura);
            this.gbEmpleadoContrato.Location = new System.Drawing.Point(12, 10);
            this.gbEmpleadoContrato.Name = "gbEmpleadoContrato";
            this.gbEmpleadoContrato.Size = new System.Drawing.Size(800, 90);
            this.gbEmpleadoContrato.TabIndex = 2;
            this.gbEmpleadoContrato.TabStop = false;
            this.gbEmpleadoContrato.Text = "Empleado y Contrato";
            //
            // lblEmpleado
            //
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 31);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado:";
            //
            // cboEmpleado
            //
            this.cboEmpleado.Location = new System.Drawing.Point(90, 25);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Size = new System.Drawing.Size(250, 23);
            this.cboEmpleado.TabIndex = 4;
            //
            // lblContratoVigente
            //
            this.lblContratoVigente.AutoSize = true;
            this.lblContratoVigente.Location = new System.Drawing.Point(420, 31);
            this.lblContratoVigente.Name = "lblContratoVigente";
            this.lblContratoVigente.TabIndex = 5;
            this.lblContratoVigente.Text = "Contrato Vigente:";
            //
            // txtContratoVigente
            //
            this.txtContratoVigente.Location = new System.Drawing.Point(535, 25);
            this.txtContratoVigente.Name = "txtContratoVigente";
            this.txtContratoVigente.ReadOnly = true;
            this.txtContratoVigente.Size = new System.Drawing.Size(245, 23);
            this.txtContratoVigente.TabIndex = 6;
            //
            // lblHorasAsignadas
            //
            this.lblHorasAsignadas.AutoSize = true;
            this.lblHorasAsignadas.Location = new System.Drawing.Point(15, 63);
            this.lblHorasAsignadas.Name = "lblHorasAsignadas";
            this.lblHorasAsignadas.TabIndex = 7;
            this.lblHorasAsignadas.Text = "Horas Asignadas:";
            //
            // txtHorasAsignadas
            //
            this.txtHorasAsignadas.Location = new System.Drawing.Point(125, 57);
            this.txtHorasAsignadas.Name = "txtHorasAsignadas";
            this.txtHorasAsignadas.ReadOnly = true;
            this.txtHorasAsignadas.Size = new System.Drawing.Size(110, 23);
            this.txtHorasAsignadas.TabIndex = 8;
            //
            // lblEstadoCobertura
            //
            this.lblEstadoCobertura.AutoSize = true;
            this.lblEstadoCobertura.Location = new System.Drawing.Point(420, 63);
            this.lblEstadoCobertura.Name = "lblEstadoCobertura";
            this.lblEstadoCobertura.TabIndex = 9;
            this.lblEstadoCobertura.Text = "Estado Cobertura Mes:";
            //
            // txtEstadoCobertura
            //
            this.txtEstadoCobertura.Location = new System.Drawing.Point(565, 57);
            this.txtEstadoCobertura.Name = "txtEstadoCobertura";
            this.txtEstadoCobertura.ReadOnly = true;
            this.txtEstadoCobertura.Size = new System.Drawing.Size(215, 23);
            this.txtEstadoCobertura.TabIndex = 10;
            //
            // gbAsignarTurno
            //
            this.gbAsignarTurno.Controls.Add(this.lblFechaTurno);
            this.gbAsignarTurno.Controls.Add(this.dtpFechaTurno);
            this.gbAsignarTurno.Controls.Add(this.lblTipoTurno);
            this.gbAsignarTurno.Controls.Add(this.cboTipoTurno);
            this.gbAsignarTurno.Controls.Add(this.lblHoraInicio);
            this.gbAsignarTurno.Controls.Add(this.dtpHoraInicio);
            this.gbAsignarTurno.Controls.Add(this.lblHoraFin);
            this.gbAsignarTurno.Controls.Add(this.dtpHoraFin);
            this.gbAsignarTurno.Controls.Add(this.btnAsignarTurno);
            this.gbAsignarTurno.Location = new System.Drawing.Point(12, 108);
            this.gbAsignarTurno.Name = "gbAsignarTurno";
            this.gbAsignarTurno.Size = new System.Drawing.Size(800, 100);
            this.gbAsignarTurno.TabIndex = 11;
            this.gbAsignarTurno.TabStop = false;
            this.gbAsignarTurno.Text = "Asignar Nuevo Turno";
            //
            // lblFechaTurno
            //
            this.lblFechaTurno.AutoSize = true;
            this.lblFechaTurno.Location = new System.Drawing.Point(15, 34);
            this.lblFechaTurno.Name = "lblFechaTurno";
            this.lblFechaTurno.TabIndex = 12;
            this.lblFechaTurno.Text = "Fecha:";
            //
            // dtpFechaTurno
            //
            this.dtpFechaTurno.Location = new System.Drawing.Point(80, 28);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaTurno.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaTurno.TabIndex = 13;
            //
            // lblTipoTurno
            //
            this.lblTipoTurno.AutoSize = true;
            this.lblTipoTurno.Location = new System.Drawing.Point(280, 34);
            this.lblTipoTurno.Name = "lblTipoTurno";
            this.lblTipoTurno.TabIndex = 14;
            this.lblTipoTurno.Text = "Tipo Turno:";
            //
            // cboTipoTurno
            //
            this.cboTipoTurno.Location = new System.Drawing.Point(360, 28);
            this.cboTipoTurno.Name = "cboTipoTurno";
            this.cboTipoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTurno.FormattingEnabled = true;
            this.cboTipoTurno.Size = new System.Drawing.Size(200, 23);
            this.cboTipoTurno.TabIndex = 15;
            //
            // lblHoraInicio
            //
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(15, 69);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.TabIndex = 16;
            this.lblHoraInicio.Text = "Hora Inicio:";
            //
            // dtpHoraInicio
            //
            this.dtpHoraInicio.Location = new System.Drawing.Point(100, 63);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(80, 23);
            this.dtpHoraInicio.TabIndex = 17;
            //
            // lblHoraFin
            //
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(280, 69);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.TabIndex = 18;
            this.lblHoraFin.Text = "Hora Fin:";
            //
            // dtpHoraFin
            //
            this.dtpHoraFin.Location = new System.Drawing.Point(360, 63);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(80, 23);
            this.dtpHoraFin.TabIndex = 19;
            //
            // btnAsignarTurno
            //
            this.btnAsignarTurno.Location = new System.Drawing.Point(600, 60);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(170, 30);
            this.btnAsignarTurno.TabIndex = 20;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            //
            // gbTurnosAsignados
            //
            this.gbTurnosAsignados.Controls.Add(this.dgvTurnosAsignados);
            this.gbTurnosAsignados.Controls.Add(this.lblMotivoModificacion);
            this.gbTurnosAsignados.Controls.Add(this.txtMotivoModificacion);
            this.gbTurnosAsignados.Controls.Add(this.btnModificarTurno);
            this.gbTurnosAsignados.Controls.Add(this.btnAnularTurno);
            this.gbTurnosAsignados.Controls.Add(this.btnPasarHorasExtra);
            this.gbTurnosAsignados.Location = new System.Drawing.Point(12, 216);
            this.gbTurnosAsignados.Name = "gbTurnosAsignados";
            this.gbTurnosAsignados.Size = new System.Drawing.Size(800, 300);
            this.gbTurnosAsignados.TabIndex = 21;
            this.gbTurnosAsignados.TabStop = false;
            this.gbTurnosAsignados.Text = "Turnos Asignados en el Mes";
            //
            // dgvTurnosAsignados
            //
            this.dgvTurnosAsignados.AllowUserToAddRows = false;
            this.dgvTurnosAsignados.AllowUserToDeleteRows = false;
            this.dgvTurnosAsignados.AllowUserToResizeRows = false;
            this.dgvTurnosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosAsignados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTurnosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFecha,
            this.colTipoTurno,
            this.colInicio,
            this.colFin,
            this.colEstado});
            this.dgvTurnosAsignados.Location = new System.Drawing.Point(12, 22);
            this.dgvTurnosAsignados.MultiSelect = false;
            this.dgvTurnosAsignados.Name = "dgvTurnosAsignados";
            this.dgvTurnosAsignados.ReadOnly = true;
            this.dgvTurnosAsignados.RowHeadersVisible = false;
            this.dgvTurnosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnosAsignados.Size = new System.Drawing.Size(776, 170);
            this.dgvTurnosAsignados.TabIndex = 22;
            //
            // lblMotivoModificacion
            //
            this.lblMotivoModificacion.AutoSize = true;
            this.lblMotivoModificacion.Location = new System.Drawing.Point(15, 211);
            this.lblMotivoModificacion.Name = "lblMotivoModificacion";
            this.lblMotivoModificacion.TabIndex = 23;
            this.lblMotivoModificacion.Text = "Motivo Modificación/Anulación:";
            //
            // txtMotivoModificacion
            //
            this.txtMotivoModificacion.Location = new System.Drawing.Point(220, 205);
            this.txtMotivoModificacion.Name = "txtMotivoModificacion";
            this.txtMotivoModificacion.Size = new System.Drawing.Size(560, 23);
            this.txtMotivoModificacion.TabIndex = 24;
            //
            // btnModificarTurno
            //
            this.btnModificarTurno.Location = new System.Drawing.Point(15, 250);
            this.btnModificarTurno.Name = "btnModificarTurno";
            this.btnModificarTurno.Size = new System.Drawing.Size(150, 30);
            this.btnModificarTurno.TabIndex = 25;
            this.btnModificarTurno.Text = "Modificar Turno";
            this.btnModificarTurno.UseVisualStyleBackColor = true;
            //
            // btnAnularTurno
            //
            this.btnAnularTurno.Location = new System.Drawing.Point(175, 250);
            this.btnAnularTurno.Name = "btnAnularTurno";
            this.btnAnularTurno.Size = new System.Drawing.Size(150, 30);
            this.btnAnularTurno.TabIndex = 26;
            this.btnAnularTurno.Text = "Anular Turno";
            this.btnAnularTurno.UseVisualStyleBackColor = true;
            //
            // btnPasarHorasExtra
            //
            this.btnPasarHorasExtra.Location = new System.Drawing.Point(335, 250);
            this.btnPasarHorasExtra.Name = "btnPasarHorasExtra";
            this.btnPasarHorasExtra.Size = new System.Drawing.Size(230, 30);
            this.btnPasarHorasExtra.TabIndex = 27;
            this.btnPasarHorasExtra.Text = "Pasar a Horas Extra (RF-02)";
            this.btnPasarHorasExtra.UseVisualStyleBackColor = true;
            //
            // tpHorasExtra
            //
            this.tpHorasExtra.Controls.Add(this.gbMenorTurnos);
            this.tpHorasExtra.Controls.Add(this.gbConsulta);
            this.tpHorasExtra.Location = new System.Drawing.Point(4, 24);
            this.tpHorasExtra.Name = "tpHorasExtra";
            this.tpHorasExtra.Padding = new System.Windows.Forms.Padding(3);
            this.tpHorasExtra.Size = new System.Drawing.Size(828, 568);
            this.tpHorasExtra.TabIndex = 28;
            this.tpHorasExtra.Text = "2. Horas Extra (RF-02)";
            this.tpHorasExtra.UseVisualStyleBackColor = true;
            //
            // gbMenorTurnos
            //
            this.gbMenorTurnos.Controls.Add(this.dgvEmpleadosMenorTurnos);
            this.gbMenorTurnos.Location = new System.Drawing.Point(12, 10);
            this.gbMenorTurnos.Name = "gbMenorTurnos";
            this.gbMenorTurnos.Size = new System.Drawing.Size(800, 230);
            this.gbMenorTurnos.TabIndex = 29;
            this.gbMenorTurnos.TabStop = false;
            this.gbMenorTurnos.Text = "Empleados con Menor Cantidad de Turnos en el Mes";
            //
            // dgvEmpleadosMenorTurnos
            //
            this.dgvEmpleadosMenorTurnos.AllowUserToAddRows = false;
            this.dgvEmpleadosMenorTurnos.AllowUserToDeleteRows = false;
            this.dgvEmpleadosMenorTurnos.AllowUserToResizeRows = false;
            this.dgvEmpleadosMenorTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosMenorTurnos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEmpleadosMenorTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosMenorTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colEmpleado,
            this.colTurnosMes,
            this.colDisponibilidad});
            this.dgvEmpleadosMenorTurnos.Location = new System.Drawing.Point(12, 22);
            this.dgvEmpleadosMenorTurnos.MultiSelect = false;
            this.dgvEmpleadosMenorTurnos.Name = "dgvEmpleadosMenorTurnos";
            this.dgvEmpleadosMenorTurnos.ReadOnly = true;
            this.dgvEmpleadosMenorTurnos.RowHeadersVisible = false;
            this.dgvEmpleadosMenorTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosMenorTurnos.Size = new System.Drawing.Size(776, 190);
            this.dgvEmpleadosMenorTurnos.TabIndex = 30;
            //
            // gbConsulta
            //
            this.gbConsulta.Controls.Add(this.lblFechaConsulta);
            this.gbConsulta.Controls.Add(this.dtpFechaConsulta);
            this.gbConsulta.Controls.Add(this.lblTurnoPropuesto);
            this.gbConsulta.Controls.Add(this.cboTurnoPropuesto);
            this.gbConsulta.Controls.Add(this.lblRespuesta);
            this.gbConsulta.Controls.Add(this.rdoAcepta);
            this.gbConsulta.Controls.Add(this.rdoNoAcepta);
            this.gbConsulta.Controls.Add(this.btnAgregarTurnoExtra);
            this.gbConsulta.Controls.Add(this.btnVerificarDisponibles);
            this.gbConsulta.Controls.Add(this.lblSiNadieAcepta);
            this.gbConsulta.Controls.Add(this.btnDerivarSubgerencia);
            this.gbConsulta.Location = new System.Drawing.Point(12, 250);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(800, 200);
            this.gbConsulta.TabIndex = 31;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Registro de Consulta y Respuesta";
            //
            // lblFechaConsulta
            //
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Location = new System.Drawing.Point(15, 34);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.TabIndex = 32;
            this.lblFechaConsulta.Text = "Fecha Consulta:";
            //
            // dtpFechaConsulta
            //
            this.dtpFechaConsulta.Location = new System.Drawing.Point(125, 28);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaConsulta.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaConsulta.TabIndex = 33;
            //
            // lblTurnoPropuesto
            //
            this.lblTurnoPropuesto.AutoSize = true;
            this.lblTurnoPropuesto.Location = new System.Drawing.Point(310, 34);
            this.lblTurnoPropuesto.Name = "lblTurnoPropuesto";
            this.lblTurnoPropuesto.TabIndex = 34;
            this.lblTurnoPropuesto.Text = "Turno Propuesto:";
            //
            // cboTurnoPropuesto
            //
            this.cboTurnoPropuesto.Location = new System.Drawing.Point(425, 28);
            this.cboTurnoPropuesto.Name = "cboTurnoPropuesto";
            this.cboTurnoPropuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurnoPropuesto.FormattingEnabled = true;
            this.cboTurnoPropuesto.Size = new System.Drawing.Size(250, 23);
            this.cboTurnoPropuesto.TabIndex = 35;
            //
            // lblRespuesta
            //
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(15, 73);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.TabIndex = 36;
            this.lblRespuesta.Text = "Respuesta del Empleado:";
            //
            // rdoAcepta
            //
            this.rdoAcepta.AutoSize = true;
            this.rdoAcepta.Location = new System.Drawing.Point(185, 69);
            this.rdoAcepta.Name = "rdoAcepta";
            this.rdoAcepta.Size = new System.Drawing.Size(150, 19);
            this.rdoAcepta.TabIndex = 37;
            this.rdoAcepta.TabStop = false;
            this.rdoAcepta.Text = "Acepta Horas Extra";
            this.rdoAcepta.UseVisualStyleBackColor = true;
            //
            // rdoNoAcepta
            //
            this.rdoNoAcepta.AutoSize = true;
            this.rdoNoAcepta.Location = new System.Drawing.Point(350, 69);
            this.rdoNoAcepta.Name = "rdoNoAcepta";
            this.rdoNoAcepta.Size = new System.Drawing.Size(100, 19);
            this.rdoNoAcepta.TabIndex = 38;
            this.rdoNoAcepta.TabStop = false;
            this.rdoNoAcepta.Text = "No Acepta";
            this.rdoNoAcepta.UseVisualStyleBackColor = true;
            //
            // btnAgregarTurnoExtra
            //
            this.btnAgregarTurnoExtra.Location = new System.Drawing.Point(15, 105);
            this.btnAgregarTurnoExtra.Name = "btnAgregarTurnoExtra";
            this.btnAgregarTurnoExtra.Size = new System.Drawing.Size(170, 30);
            this.btnAgregarTurnoExtra.TabIndex = 39;
            this.btnAgregarTurnoExtra.Text = "Agregar Turno Extra";
            this.btnAgregarTurnoExtra.UseVisualStyleBackColor = true;
            //
            // btnVerificarDisponibles
            //
            this.btnVerificarDisponibles.Location = new System.Drawing.Point(195, 105);
            this.btnVerificarDisponibles.Name = "btnVerificarDisponibles";
            this.btnVerificarDisponibles.Size = new System.Drawing.Size(210, 30);
            this.btnVerificarDisponibles.TabIndex = 40;
            this.btnVerificarDisponibles.Text = "Verificar Otros Disponibles";
            this.btnVerificarDisponibles.UseVisualStyleBackColor = true;
            //
            // lblSiNadieAcepta
            //
            this.lblSiNadieAcepta.AutoSize = true;
            this.lblSiNadieAcepta.Location = new System.Drawing.Point(15, 156);
            this.lblSiNadieAcepta.Name = "lblSiNadieAcepta";
            this.lblSiNadieAcepta.TabIndex = 41;
            this.lblSiNadieAcepta.Text = "*Si nadie acepta:";
            //
            // btnDerivarSubgerencia
            //
            this.btnDerivarSubgerencia.Location = new System.Drawing.Point(135, 148);
            this.btnDerivarSubgerencia.Name = "btnDerivarSubgerencia";
            this.btnDerivarSubgerencia.Size = new System.Drawing.Size(380, 30);
            this.btnDerivarSubgerencia.TabIndex = 42;
            this.btnDerivarSubgerencia.Text = "Derivar a Subgerencia por Falta de Cobertura (RF-03)";
            this.btnDerivarSubgerencia.UseVisualStyleBackColor = true;
            //
            // tpReclutamiento
            //
            this.tpReclutamiento.Controls.Add(this.gbSolicitudCobertura);
            this.tpReclutamiento.Controls.Add(this.gbEncontroEmpleado);
            this.tpReclutamiento.Location = new System.Drawing.Point(4, 24);
            this.tpReclutamiento.Name = "tpReclutamiento";
            this.tpReclutamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpReclutamiento.Size = new System.Drawing.Size(828, 568);
            this.tpReclutamiento.TabIndex = 43;
            this.tpReclutamiento.Text = "3. Reclutam.";
            this.tpReclutamiento.UseVisualStyleBackColor = true;
            //
            // gbSolicitudCobertura
            //
            this.gbSolicitudCobertura.Controls.Add(this.lblFechaSolicitud);
            this.gbSolicitudCobertura.Controls.Add(this.dtpFechaSolicitud);
            this.gbSolicitudCobertura.Controls.Add(this.lblTurnosPendientes);
            this.gbSolicitudCobertura.Controls.Add(this.numTurnosPendientes);
            this.gbSolicitudCobertura.Controls.Add(this.btnIniciarReclutamiento);
            this.gbSolicitudCobertura.Location = new System.Drawing.Point(12, 10);
            this.gbSolicitudCobertura.Name = "gbSolicitudCobertura";
            this.gbSolicitudCobertura.Size = new System.Drawing.Size(800, 120);
            this.gbSolicitudCobertura.TabIndex = 44;
            this.gbSolicitudCobertura.TabStop = false;
            this.gbSolicitudCobertura.Text = "Reclutamiento / Ventas (RF-03) - Solicitud Cobertura (Subgerencia)";
            //
            // lblFechaSolicitud
            //
            this.lblFechaSolicitud.AutoSize = true;
            this.lblFechaSolicitud.Location = new System.Drawing.Point(15, 34);
            this.lblFechaSolicitud.Name = "lblFechaSolicitud";
            this.lblFechaSolicitud.TabIndex = 45;
            this.lblFechaSolicitud.Text = "Fecha:";
            //
            // dtpFechaSolicitud
            //
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(70, 28);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(140, 23);
            this.dtpFechaSolicitud.TabIndex = 46;
            //
            // lblTurnosPendientes
            //
            this.lblTurnosPendientes.AutoSize = true;
            this.lblTurnosPendientes.Location = new System.Drawing.Point(260, 34);
            this.lblTurnosPendientes.Name = "lblTurnosPendientes";
            this.lblTurnosPendientes.TabIndex = 47;
            this.lblTurnosPendientes.Text = "Turnos Pendientes:";
            //
            // numTurnosPendientes
            //
            this.numTurnosPendientes.Location = new System.Drawing.Point(385, 28);
            this.numTurnosPendientes.Name = "numTurnosPendientes";
            this.numTurnosPendientes.DecimalPlaces = 0;
            this.numTurnosPendientes.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.numTurnosPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTurnosPendientes.Size = new System.Drawing.Size(60, 23);
            this.numTurnosPendientes.TabIndex = 48;
            //
            // btnIniciarReclutamiento
            //
            this.btnIniciarReclutamiento.Location = new System.Drawing.Point(15, 68);
            this.btnIniciarReclutamiento.Name = "btnIniciarReclutamiento";
            this.btnIniciarReclutamiento.Size = new System.Drawing.Size(230, 30);
            this.btnIniciarReclutamiento.TabIndex = 49;
            this.btnIniciarReclutamiento.Text = "Iniciar Proceso de Reclutamiento";
            this.btnIniciarReclutamiento.UseVisualStyleBackColor = true;
            //
            // gbEncontroEmpleado
            //
            this.gbEncontroEmpleado.Controls.Add(this.rdoSiEncontro);
            this.gbEncontroEmpleado.Controls.Add(this.btnIrDefinirTurnos);
            this.gbEncontroEmpleado.Controls.Add(this.rdoNoEncontro);
            this.gbEncontroEmpleado.Controls.Add(this.lblPeriodoReduccion);
            this.gbEncontroEmpleado.Controls.Add(this.dtpPeriodoReduccion);
            this.gbEncontroEmpleado.Controls.Add(this.lblMotivoReduccion);
            this.gbEncontroEmpleado.Controls.Add(this.txtMotivoReduccion);
            this.gbEncontroEmpleado.Controls.Add(this.btnRegistrarReduccion);
            this.gbEncontroEmpleado.Location = new System.Drawing.Point(12, 140);
            this.gbEncontroEmpleado.Name = "gbEncontroEmpleado";
            this.gbEncontroEmpleado.Size = new System.Drawing.Size(800, 230);
            this.gbEncontroEmpleado.TabIndex = 50;
            this.gbEncontroEmpleado.TabStop = false;
            this.gbEncontroEmpleado.Text = "¿Se encontró nuevo empleado a tiempo?";
            //
            // rdoSiEncontro
            //
            this.rdoSiEncontro.AutoSize = true;
            this.rdoSiEncontro.Location = new System.Drawing.Point(15, 30);
            this.rdoSiEncontro.Name = "rdoSiEncontro";
            this.rdoSiEncontro.Size = new System.Drawing.Size(50, 19);
            this.rdoSiEncontro.TabIndex = 51;
            this.rdoSiEncontro.TabStop = false;
            this.rdoSiEncontro.Text = "Sí";
            this.rdoSiEncontro.UseVisualStyleBackColor = true;
            //
            // btnIrDefinirTurnos
            //
            this.btnIrDefinirTurnos.Location = new System.Drawing.Point(90, 26);
            this.btnIrDefinirTurnos.Name = "btnIrDefinirTurnos";
            this.btnIrDefinirTurnos.Size = new System.Drawing.Size(180, 30);
            this.btnIrDefinirTurnos.TabIndex = 52;
            this.btnIrDefinirTurnos.Text = "Ir a Definir Turnos";
            this.btnIrDefinirTurnos.UseVisualStyleBackColor = true;
            //
            // rdoNoEncontro
            //
            this.rdoNoEncontro.AutoSize = true;
            this.rdoNoEncontro.Location = new System.Drawing.Point(15, 70);
            this.rdoNoEncontro.Name = "rdoNoEncontro";
            this.rdoNoEncontro.Size = new System.Drawing.Size(280, 19);
            this.rdoNoEncontro.TabIndex = 53;
            this.rdoNoEncontro.TabStop = false;
            this.rdoNoEncontro.Text = "No: Reducción Temporal de Ventas";
            this.rdoNoEncontro.UseVisualStyleBackColor = true;
            //
            // lblPeriodoReduccion
            //
            this.lblPeriodoReduccion.AutoSize = true;
            this.lblPeriodoReduccion.Location = new System.Drawing.Point(35, 111);
            this.lblPeriodoReduccion.Name = "lblPeriodoReduccion";
            this.lblPeriodoReduccion.TabIndex = 54;
            this.lblPeriodoReduccion.Text = "Periodo:";
            //
            // dtpPeriodoReduccion
            //
            this.dtpPeriodoReduccion.Location = new System.Drawing.Point(110, 105);
            this.dtpPeriodoReduccion.Name = "dtpPeriodoReduccion";
            this.dtpPeriodoReduccion.CustomFormat = "MMMM yyyy";
            this.dtpPeriodoReduccion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodoReduccion.Size = new System.Drawing.Size(170, 23);
            this.dtpPeriodoReduccion.TabIndex = 55;
            //
            // lblMotivoReduccion
            //
            this.lblMotivoReduccion.AutoSize = true;
            this.lblMotivoReduccion.Location = new System.Drawing.Point(35, 146);
            this.lblMotivoReduccion.Name = "lblMotivoReduccion";
            this.lblMotivoReduccion.TabIndex = 56;
            this.lblMotivoReduccion.Text = "Motivo:";
            //
            // txtMotivoReduccion
            //
            this.txtMotivoReduccion.Location = new System.Drawing.Point(110, 140);
            this.txtMotivoReduccion.Name = "txtMotivoReduccion";
            this.txtMotivoReduccion.Size = new System.Drawing.Size(350, 23);
            this.txtMotivoReduccion.TabIndex = 57;
            //
            // btnRegistrarReduccion
            //
            this.btnRegistrarReduccion.Location = new System.Drawing.Point(35, 178);
            this.btnRegistrarReduccion.Name = "btnRegistrarReduccion";
            this.btnRegistrarReduccion.Size = new System.Drawing.Size(230, 30);
            this.btnRegistrarReduccion.TabIndex = 58;
            this.btnRegistrarReduccion.Text = "Registrar Reducción de Ventas";
            this.btnRegistrarReduccion.UseVisualStyleBackColor = true;
            //
            // tpEnvio
            //
            this.tpEnvio.Controls.Add(this.gbConsolidadoMensual);
            this.tpEnvio.Location = new System.Drawing.Point(4, 24);
            this.tpEnvio.Name = "tpEnvio";
            this.tpEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnvio.Size = new System.Drawing.Size(828, 568);
            this.tpEnvio.TabIndex = 59;
            this.tpEnvio.Text = "4. Envío";
            this.tpEnvio.UseVisualStyleBackColor = true;
            //
            // gbConsolidadoMensual
            //
            this.gbConsolidadoMensual.Controls.Add(this.lblPeriodoEnvio);
            this.gbConsolidadoMensual.Controls.Add(this.dtpPeriodoEnvio);
            this.gbConsolidadoMensual.Controls.Add(this.btnGraficarHorario);
            this.gbConsolidadoMensual.Controls.Add(this.dgvHorarioMensual);
            this.gbConsolidadoMensual.Controls.Add(this.lblEstadoHorario);
            this.gbConsolidadoMensual.Controls.Add(this.txtEstadoHorario);
            this.gbConsolidadoMensual.Controls.Add(this.btnEnviarHorario);
            this.gbConsolidadoMensual.Controls.Add(this.lblMotivoAnulacionHorario);
            this.gbConsolidadoMensual.Controls.Add(this.txtMotivoAnulacionHorario);
            this.gbConsolidadoMensual.Controls.Add(this.btnAnularHorario);
            this.gbConsolidadoMensual.Location = new System.Drawing.Point(12, 10);
            this.gbConsolidadoMensual.Name = "gbConsolidadoMensual";
            this.gbConsolidadoMensual.Size = new System.Drawing.Size(800, 330);
            this.gbConsolidadoMensual.TabIndex = 60;
            this.gbConsolidadoMensual.TabStop = false;
            this.gbConsolidadoMensual.Text = "Graficar y Enviar Horario (RF-04) - Consolidado Mensual (Director RRHH)";
            //
            // lblPeriodoEnvio
            //
            this.lblPeriodoEnvio.AutoSize = true;
            this.lblPeriodoEnvio.Location = new System.Drawing.Point(15, 34);
            this.lblPeriodoEnvio.Name = "lblPeriodoEnvio";
            this.lblPeriodoEnvio.TabIndex = 61;
            this.lblPeriodoEnvio.Text = "Periodo:";
            //
            // dtpPeriodoEnvio
            //
            this.dtpPeriodoEnvio.Location = new System.Drawing.Point(80, 28);
            this.dtpPeriodoEnvio.Name = "dtpPeriodoEnvio";
            this.dtpPeriodoEnvio.CustomFormat = "MMMM yyyy";
            this.dtpPeriodoEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodoEnvio.Size = new System.Drawing.Size(170, 23);
            this.dtpPeriodoEnvio.TabIndex = 62;
            //
            // btnGraficarHorario
            //
            this.btnGraficarHorario.Location = new System.Drawing.Point(270, 25);
            this.btnGraficarHorario.Name = "btnGraficarHorario";
            this.btnGraficarHorario.Size = new System.Drawing.Size(200, 30);
            this.btnGraficarHorario.TabIndex = 63;
            this.btnGraficarHorario.Text = "Graficar Horario Mensual";
            this.btnGraficarHorario.UseVisualStyleBackColor = true;
            //
            // dgvHorarioMensual
            //
            this.dgvHorarioMensual.AllowUserToAddRows = false;
            this.dgvHorarioMensual.AllowUserToDeleteRows = false;
            this.dgvHorarioMensual.AllowUserToResizeRows = false;
            this.dgvHorarioMensual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarioMensual.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHorarioMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarioMensual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLun,
            this.colMar,
            this.colMie,
            this.colJue,
            this.colVie,
            this.colSab});
            this.dgvHorarioMensual.Location = new System.Drawing.Point(15, 70);
            this.dgvHorarioMensual.MultiSelect = false;
            this.dgvHorarioMensual.Name = "dgvHorarioMensual";
            this.dgvHorarioMensual.ReadOnly = true;
            this.dgvHorarioMensual.RowHeadersVisible = false;
            this.dgvHorarioMensual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarioMensual.Size = new System.Drawing.Size(770, 110);
            this.dgvHorarioMensual.TabIndex = 64;
            //
            // lblEstadoHorario
            //
            this.lblEstadoHorario.AutoSize = true;
            this.lblEstadoHorario.Location = new System.Drawing.Point(15, 203);
            this.lblEstadoHorario.Name = "lblEstadoHorario";
            this.lblEstadoHorario.TabIndex = 65;
            this.lblEstadoHorario.Text = "Estado:";
            //
            // txtEstadoHorario
            //
            this.txtEstadoHorario.Location = new System.Drawing.Point(70, 197);
            this.txtEstadoHorario.Name = "txtEstadoHorario";
            this.txtEstadoHorario.ReadOnly = true;
            this.txtEstadoHorario.Size = new System.Drawing.Size(250, 23);
            this.txtEstadoHorario.TabIndex = 66;
            //
            // btnEnviarHorario
            //
            this.btnEnviarHorario.Location = new System.Drawing.Point(340, 194);
            this.btnEnviarHorario.Name = "btnEnviarHorario";
            this.btnEnviarHorario.Size = new System.Drawing.Size(210, 30);
            this.btnEnviarHorario.TabIndex = 67;
            this.btnEnviarHorario.Text = "Enviar Horario a Empleados";
            this.btnEnviarHorario.UseVisualStyleBackColor = true;
            //
            // lblMotivoAnulacionHorario
            //
            this.lblMotivoAnulacionHorario.AutoSize = true;
            this.lblMotivoAnulacionHorario.Location = new System.Drawing.Point(15, 246);
            this.lblMotivoAnulacionHorario.Name = "lblMotivoAnulacionHorario";
            this.lblMotivoAnulacionHorario.TabIndex = 68;
            this.lblMotivoAnulacionHorario.Text = "Motivo Anulación:";
            //
            // txtMotivoAnulacionHorario
            //
            this.txtMotivoAnulacionHorario.Location = new System.Drawing.Point(140, 240);
            this.txtMotivoAnulacionHorario.Name = "txtMotivoAnulacionHorario";
            this.txtMotivoAnulacionHorario.Size = new System.Drawing.Size(400, 23);
            this.txtMotivoAnulacionHorario.TabIndex = 69;
            //
            // btnAnularHorario
            //
            this.btnAnularHorario.Location = new System.Drawing.Point(15, 280);
            this.btnAnularHorario.Name = "btnAnularHorario";
            this.btnAnularHorario.Size = new System.Drawing.Size(250, 30);
            this.btnAnularHorario.TabIndex = 70;
            this.btnAnularHorario.Text = "Anular Horario Antes del Envío";
            this.btnAnularHorario.UseVisualStyleBackColor = true;
            //
            // colId
            //
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            //
            // colFecha
            //
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            //
            // colTipoTurno
            //
            this.colTipoTurno.HeaderText = "Tipo Turno";
            this.colTipoTurno.Name = "colTipoTurno";
            this.colTipoTurno.ReadOnly = true;
            //
            // colInicio
            //
            this.colInicio.HeaderText = "Inicio";
            this.colInicio.Name = "colInicio";
            this.colInicio.ReadOnly = true;
            //
            // colFin
            //
            this.colFin.HeaderText = "Fin";
            this.colFin.Name = "colFin";
            this.colFin.ReadOnly = true;
            //
            // colEstado
            //
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
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
            // colTurnosMes
            //
            this.colTurnosMes.HeaderText = "Turnos en el Mes";
            this.colTurnosMes.Name = "colTurnosMes";
            this.colTurnosMes.ReadOnly = true;
            //
            // colDisponibilidad
            //
            this.colDisponibilidad.HeaderText = "Disponibilidad";
            this.colDisponibilidad.Name = "colDisponibilidad";
            this.colDisponibilidad.ReadOnly = true;
            //
            // colLun
            //
            this.colLun.HeaderText = "Lun";
            this.colLun.Name = "colLun";
            this.colLun.ReadOnly = true;
            //
            // colMar
            //
            this.colMar.HeaderText = "Mar";
            this.colMar.Name = "colMar";
            this.colMar.ReadOnly = true;
            //
            // colMie
            //
            this.colMie.HeaderText = "Mié";
            this.colMie.Name = "colMie";
            this.colMie.ReadOnly = true;
            //
            // colJue
            //
            this.colJue.HeaderText = "Jue";
            this.colJue.Name = "colJue";
            this.colJue.ReadOnly = true;
            //
            // colVie
            //
            this.colVie.HeaderText = "Vie";
            this.colVie.Name = "colVie";
            this.colVie.ReadOnly = true;
            //
            // colSab
            //
            this.colSab.HeaderText = "Sáb";
            this.colSab.Name = "colSab";
            this.colSab.ReadOnly = true;
            //
            // frmCoreTurnos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.tcTurnos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoreTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CORE TURNOS - Gestión de Programación Mensual";
            this.gbConsolidadoMensual.ResumeLayout(false);
            this.gbConsolidadoMensual.PerformLayout();
            this.tpEnvio.ResumeLayout(false);
            this.tpEnvio.PerformLayout();
            this.gbEncontroEmpleado.ResumeLayout(false);
            this.gbEncontroEmpleado.PerformLayout();
            this.gbSolicitudCobertura.ResumeLayout(false);
            this.gbSolicitudCobertura.PerformLayout();
            this.tpReclutamiento.ResumeLayout(false);
            this.tpReclutamiento.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbMenorTurnos.ResumeLayout(false);
            this.gbMenorTurnos.PerformLayout();
            this.tpHorasExtra.ResumeLayout(false);
            this.tpHorasExtra.PerformLayout();
            this.gbTurnosAsignados.ResumeLayout(false);
            this.gbTurnosAsignados.PerformLayout();
            this.gbAsignarTurno.ResumeLayout(false);
            this.gbAsignarTurno.PerformLayout();
            this.gbEmpleadoContrato.ResumeLayout(false);
            this.gbEmpleadoContrato.PerformLayout();
            this.tpDefinirTurnos.ResumeLayout(false);
            this.tpDefinirTurnos.PerformLayout();
            this.tcTurnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosMenorTurnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurnosPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarioMensual)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcTurnos;
        private System.Windows.Forms.TabPage tpDefinirTurnos;
        private System.Windows.Forms.GroupBox gbEmpleadoContrato;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lblContratoVigente;
        private System.Windows.Forms.TextBox txtContratoVigente;
        private System.Windows.Forms.Label lblHorasAsignadas;
        private System.Windows.Forms.TextBox txtHorasAsignadas;
        private System.Windows.Forms.Label lblEstadoCobertura;
        private System.Windows.Forms.TextBox txtEstadoCobertura;
        private System.Windows.Forms.GroupBox gbAsignarTurno;
        private System.Windows.Forms.Label lblFechaTurno;
        private System.Windows.Forms.DateTimePicker dtpFechaTurno;
        private System.Windows.Forms.Label lblTipoTurno;
        private System.Windows.Forms.ComboBox cboTipoTurno;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.GroupBox gbTurnosAsignados;
        private System.Windows.Forms.DataGridView dgvTurnosAsignados;
        private System.Windows.Forms.Label lblMotivoModificacion;
        private System.Windows.Forms.TextBox txtMotivoModificacion;
        private System.Windows.Forms.Button btnModificarTurno;
        private System.Windows.Forms.Button btnAnularTurno;
        private System.Windows.Forms.Button btnPasarHorasExtra;
        private System.Windows.Forms.TabPage tpHorasExtra;
        private System.Windows.Forms.GroupBox gbMenorTurnos;
        private System.Windows.Forms.DataGridView dgvEmpleadosMenorTurnos;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.Label lblTurnoPropuesto;
        private System.Windows.Forms.ComboBox cboTurnoPropuesto;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.RadioButton rdoAcepta;
        private System.Windows.Forms.RadioButton rdoNoAcepta;
        private System.Windows.Forms.Button btnAgregarTurnoExtra;
        private System.Windows.Forms.Button btnVerificarDisponibles;
        private System.Windows.Forms.Label lblSiNadieAcepta;
        private System.Windows.Forms.Button btnDerivarSubgerencia;
        private System.Windows.Forms.TabPage tpReclutamiento;
        private System.Windows.Forms.GroupBox gbSolicitudCobertura;
        private System.Windows.Forms.Label lblFechaSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label lblTurnosPendientes;
        private System.Windows.Forms.NumericUpDown numTurnosPendientes;
        private System.Windows.Forms.Button btnIniciarReclutamiento;
        private System.Windows.Forms.GroupBox gbEncontroEmpleado;
        private System.Windows.Forms.RadioButton rdoSiEncontro;
        private System.Windows.Forms.Button btnIrDefinirTurnos;
        private System.Windows.Forms.RadioButton rdoNoEncontro;
        private System.Windows.Forms.Label lblPeriodoReduccion;
        private System.Windows.Forms.DateTimePicker dtpPeriodoReduccion;
        private System.Windows.Forms.Label lblMotivoReduccion;
        private System.Windows.Forms.TextBox txtMotivoReduccion;
        private System.Windows.Forms.Button btnRegistrarReduccion;
        private System.Windows.Forms.TabPage tpEnvio;
        private System.Windows.Forms.GroupBox gbConsolidadoMensual;
        private System.Windows.Forms.Label lblPeriodoEnvio;
        private System.Windows.Forms.DateTimePicker dtpPeriodoEnvio;
        private System.Windows.Forms.Button btnGraficarHorario;
        private System.Windows.Forms.DataGridView dgvHorarioMensual;
        private System.Windows.Forms.Label lblEstadoHorario;
        private System.Windows.Forms.TextBox txtEstadoHorario;
        private System.Windows.Forms.Button btnEnviarHorario;
        private System.Windows.Forms.Label lblMotivoAnulacionHorario;
        private System.Windows.Forms.TextBox txtMotivoAnulacionHorario;
        private System.Windows.Forms.Button btnAnularHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurnosMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSab;
    }
}
