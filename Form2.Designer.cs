namespace SegMayor
{
    partial class menuAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_texto = new System.Windows.Forms.Label();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_rol = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasColacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seguridadMayorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seguridadMayorDataSet = new SegMayor.SeguridadMayorDataSet();
            this.asistenciaTableAdapter = new SegMayor.SeguridadMayorDataSetTableAdapters.AsistenciaTableAdapter();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.cb_tipoturno = new System.Windows.Forms.ComboBox();
            this.checkb_efectivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_zona = new System.Windows.Forms.Label();
            this.lb_rut = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.mtb_hentrada = new System.Windows.Forms.MaskedTextBox();
            this.mtb_hsalida = new System.Windows.Forms.MaskedTextBox();
            this.mtb_colacion = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_just = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadMayorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadMayorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(9, 12);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(177, 17);
            this.lb_texto.TabIndex = 10;
            this.lb_texto.Text = "Ingrese ROL de trabajador";
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_limpiar.Location = new System.Drawing.Point(327, 12);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(125, 50);
            this.bt_limpiar.TabIndex = 9;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = true;
            this.bt_limpiar.Click += new System.EventHandler(this.bt_limpiar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.Location = new System.Drawing.Point(196, 12);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(125, 50);
            this.bt_buscar.TabIndex = 8;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // tb_rol
            // 
            this.tb_rol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_rol.Location = new System.Drawing.Point(12, 32);
            this.tb_rol.Name = "tb_rol";
            this.tb_rol.Size = new System.Drawing.Size(146, 22);
            this.tb_rol.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horasColacionDataGridViewTextBoxColumn,
            this.horaSalidaDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asistenciaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1218, 129);
            this.dataGridView1.TabIndex = 11;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaEntradaDataGridViewTextBoxColumn
            // 
            this.horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.HeaderText = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            // 
            // horasColacionDataGridViewTextBoxColumn
            // 
            this.horasColacionDataGridViewTextBoxColumn.DataPropertyName = "HorasColacion";
            this.horasColacionDataGridViewTextBoxColumn.HeaderText = "HorasColacion";
            this.horasColacionDataGridViewTextBoxColumn.Name = "horasColacionDataGridViewTextBoxColumn";
            // 
            // horaSalidaDataGridViewTextBoxColumn
            // 
            this.horaSalidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSalida";
            this.horaSalidaDataGridViewTextBoxColumn.HeaderText = "HoraSalida";
            this.horaSalidaDataGridViewTextBoxColumn.Name = "horaSalidaDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataMember = "Asistencia";
            this.asistenciaBindingSource.DataSource = this.seguridadMayorDataSetBindingSource;
            // 
            // seguridadMayorDataSetBindingSource
            // 
            this.seguridadMayorDataSetBindingSource.DataSource = this.seguridadMayorDataSet;
            this.seguridadMayorDataSetBindingSource.Position = 0;
            this.seguridadMayorDataSetBindingSource.CurrentChanged += new System.EventHandler(this.seguridadMayorDataSetBindingSource_CurrentChanged);
            // 
            // seguridadMayorDataSet
            // 
            this.seguridadMayorDataSet.DataSetName = "SeguridadMayorDataSet";
            this.seguridadMayorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(863, 237);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(123, 44);
            this.bt_guardar.TabIndex = 16;
            this.bt_guardar.Text = "Guardar Turno";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // cb_tipoturno
            // 
            this.cb_tipoturno.FormattingEnabled = true;
            this.cb_tipoturno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "4 Y 1"});
            this.cb_tipoturno.Location = new System.Drawing.Point(902, 175);
            this.cb_tipoturno.Name = "cb_tipoturno";
            this.cb_tipoturno.Size = new System.Drawing.Size(121, 24);
            this.cb_tipoturno.TabIndex = 17;
            this.cb_tipoturno.Text = "Seleccione...";
            // 
            // checkb_efectivo
            // 
            this.checkb_efectivo.AutoSize = true;
            this.checkb_efectivo.Enabled = false;
            this.checkb_efectivo.Location = new System.Drawing.Point(849, 204);
            this.checkb_efectivo.Name = "checkb_efectivo";
            this.checkb_efectivo.Size = new System.Drawing.Size(137, 21);
            this.checkb_efectivo.TabIndex = 18;
            this.checkb_efectivo.Text = "Pago en Efectivo";
            this.checkb_efectivo.UseVisualStyleBackColor = true;
            this.checkb_efectivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Horario de entrada (HH:MM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Horario de salida (HH:MM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tiempo de colación (HH:MM)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo de turno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre de trabajador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "RUT de trabajador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Zona de trabajo:";
            // 
            // lb_zona
            // 
            this.lb_zona.AutoSize = true;
            this.lb_zona.Location = new System.Drawing.Point(169, 127);
            this.lb_zona.Name = "lb_zona";
            this.lb_zona.Size = new System.Drawing.Size(39, 17);
            this.lb_zona.TabIndex = 28;
            this.lb_zona.Text = "zona";
            this.lb_zona.Visible = false;
            this.lb_zona.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_rut
            // 
            this.lb_rut.AutoSize = true;
            this.lb_rut.Location = new System.Drawing.Point(169, 101);
            this.lb_rut.Name = "lb_rut";
            this.lb_rut.Size = new System.Drawing.Size(25, 17);
            this.lb_rut.TabIndex = 27;
            this.lb_rut.Text = "rut";
            this.lb_rut.Visible = false;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(169, 74);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(43, 17);
            this.lb_nombre.TabIndex = 26;
            this.lb_nombre.Text = "name";
            this.lb_nombre.Visible = false;
            this.lb_nombre.Click += new System.EventHandler(this.label10_Click);
            // 
            // mtb_hentrada
            // 
            this.mtb_hentrada.Location = new System.Drawing.Point(652, 174);
            this.mtb_hentrada.Mask = "00:00";
            this.mtb_hentrada.Name = "mtb_hentrada";
            this.mtb_hentrada.Size = new System.Drawing.Size(100, 22);
            this.mtb_hentrada.TabIndex = 29;
            this.mtb_hentrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_hentrada.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_hsalida
            // 
            this.mtb_hsalida.Location = new System.Drawing.Point(652, 207);
            this.mtb_hsalida.Mask = "00:00";
            this.mtb_hsalida.Name = "mtb_hsalida";
            this.mtb_hsalida.Size = new System.Drawing.Size(100, 22);
            this.mtb_hsalida.TabIndex = 30;
            this.mtb_hsalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_hsalida.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_colacion
            // 
            this.mtb_colacion.Location = new System.Drawing.Point(652, 236);
            this.mtb_colacion.Mask = "00:00";
            this.mtb_colacion.Name = "mtb_colacion";
            this.mtb_colacion.Size = new System.Drawing.Size(100, 22);
            this.mtb_colacion.TabIndex = 31;
            this.mtb_colacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtb_colacion.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Asistencia";
            // 
            // cb_just
            // 
            this.cb_just.Enabled = false;
            this.cb_just.FormattingEnabled = true;
            this.cb_just.Items.AddRange(new object[] {
            "Permisos",
            "Licencia",
            "Mutual",
            "Vacaciones",
            "Inactivo"});
            this.cb_just.Location = new System.Drawing.Point(114, 213);
            this.cb_just.Name = "cb_just";
            this.cb_just.Size = new System.Drawing.Size(121, 24);
            this.cb_just.TabIndex = 38;
            this.cb_just.Text = "Seleccione...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Justificación";
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Location = new System.Drawing.Point(114, 182);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(41, 21);
            this.rb_si.TabIndex = 40;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "Si";
            this.rb_si.UseVisualStyleBackColor = true;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(172, 182);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(47, 21);
            this.rb_no.TabIndex = 41;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // menuAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 981);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rb_no);
            this.Controls.Add(this.rb_si);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_just);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtb_colacion);
            this.Controls.Add(this.mtb_hsalida);
            this.Controls.Add(this.mtb_hentrada);
            this.Controls.Add(this.lb_zona);
            this.Controls.Add(this.lb_rut);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkb_efectivo);
            this.Controls.Add(this.cb_tipoturno);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_rol);
            this.MinimumSize = new System.Drawing.Size(1260, 600);
            this.Name = "menuAsistencia";
            this.Text = "Menú Asistencia";
            this.Load += new System.EventHandler(this.menuAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadMayorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguridadMayorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_rol;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource seguridadMayorDataSetBindingSource;
        private SeguridadMayorDataSet seguridadMayorDataSet;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private SeguridadMayorDataSetTableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ComboBox cb_tipoturno;
        private System.Windows.Forms.CheckBox checkb_efectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_zona;
        private System.Windows.Forms.Label lb_rut;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.MaskedTextBox mtb_hentrada;
        private System.Windows.Forms.MaskedTextBox mtb_hsalida;
        private System.Windows.Forms.MaskedTextBox mtb_colacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasColacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_just;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}