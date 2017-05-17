namespace SegMayor
{
    partial class PruebaIngreso
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbCodTurno = new System.Windows.Forms.Label();
            this.mskEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mskSalida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTiempo = new System.Windows.Forms.MaskedTextBox();
            this.dt_fechaTurno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHorasExtras = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbJustificacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCantRestricciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_horasTurno = new System.Windows.Forms.ComboBox();
            this.lb_detallesRestricciones = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(Ninguo)",
            "Mañana",
            "Tarde",
            "Noche"});
            this.comboBox1.Location = new System.Drawing.Point(83, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Turno";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(394, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Descanso";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbCodTurno
            // 
            this.lbCodTurno.AutoSize = true;
            this.lbCodTurno.Location = new System.Drawing.Point(429, 345);
            this.lbCodTurno.Name = "lbCodTurno";
            this.lbCodTurno.Size = new System.Drawing.Size(88, 13);
            this.lbCodTurno.TabIndex = 3;
            this.lbCodTurno.Text = "Código del Turno";
            // 
            // mskEntrada
            // 
            this.mskEntrada.Location = new System.Drawing.Point(127, 94);
            this.mskEntrada.Mask = "00:00";
            this.mskEntrada.Name = "mskEntrada";
            this.mskEntrada.Size = new System.Drawing.Size(34, 20);
            this.mskEntrada.TabIndex = 4;
            this.mskEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mskSalida
            // 
            this.mskSalida.Location = new System.Drawing.Point(167, 94);
            this.mskSalida.Mask = "00:00";
            this.mskSalida.Name = "mskSalida";
            this.mskSalida.Size = new System.Drawing.Size(34, 20);
            this.mskSalida.TabIndex = 4;
            this.mskSalida.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Entrada y Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colación";
            // 
            // mskTiempo
            // 
            this.mskTiempo.Location = new System.Drawing.Point(283, 94);
            this.mskTiempo.Mask = "00:00";
            this.mskTiempo.Name = "mskTiempo";
            this.mskTiempo.Size = new System.Drawing.Size(34, 20);
            this.mskTiempo.TabIndex = 4;
            this.mskTiempo.ValidatingType = typeof(System.DateTime);
            // 
            // dt_fechaTurno
            // 
            this.dt_fechaTurno.Location = new System.Drawing.Point(121, 43);
            this.dt_fechaTurno.Name = "dt_fechaTurno";
            this.dt_fechaTurno.Size = new System.Drawing.Size(200, 20);
            this.dt_fechaTurno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Turno";
            // 
            // lbHorasExtras
            // 
            this.lbHorasExtras.AutoSize = true;
            this.lbHorasExtras.Location = new System.Drawing.Point(46, 345);
            this.lbHorasExtras.Name = "lbHorasExtras";
            this.lbHorasExtras.Size = new System.Drawing.Size(118, 13);
            this.lbHorasExtras.TabIndex = 10;
            this.lbHorasExtras.Text = "Horas Extras del Turno:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Asistió";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No Asistió";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbJustificacion
            // 
            this.cbJustificacion.Enabled = false;
            this.cbJustificacion.FormattingEnabled = true;
            this.cbJustificacion.Items.AddRange(new object[] {
            "Falta",
            "Licencia",
            "Mutual",
            "Vacaciones",
            "Permiso sin Goce de Sueldo",
            "Permiso con Goce de Sueldo"});
            this.cbJustificacion.Location = new System.Drawing.Point(199, 75);
            this.cbJustificacion.Name = "cbJustificacion";
            this.cbJustificacion.Size = new System.Drawing.Size(175, 21);
            this.cbJustificacion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cantidad horas del Turno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Configurar Feriados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCantRestricciones
            // 
            this.lbCantRestricciones.AutoSize = true;
            this.lbCantRestricciones.Location = new System.Drawing.Point(234, 345);
            this.lbCantRestricciones.Name = "lbCantRestricciones";
            this.lbCantRestricciones.Size = new System.Drawing.Size(131, 13);
            this.lbCantRestricciones.TabIndex = 17;
            this.lbCantRestricciones.Text = "Cantidad de Restricciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_horasTurno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mskEntrada);
            this.panel1.Controls.Add(this.mskSalida);
            this.panel1.Controls.Add(this.mskTiempo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(121, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 141);
            this.panel1.TabIndex = 18;
            // 
            // cb_horasTurno
            // 
            this.cb_horasTurno.FormattingEnabled = true;
            this.cb_horasTurno.Items.AddRange(new object[] {
            "8"});
            this.cb_horasTurno.Location = new System.Drawing.Point(136, 61);
            this.cb_horasTurno.Name = "cb_horasTurno";
            this.cb_horasTurno.Size = new System.Drawing.Size(72, 21);
            this.cb_horasTurno.TabIndex = 19;
            // 
            // lb_detallesRestricciones
            // 
            this.lb_detallesRestricciones.AutoSize = true;
            this.lb_detallesRestricciones.Location = new System.Drawing.Point(237, 378);
            this.lb_detallesRestricciones.Name = "lb_detallesRestricciones";
            this.lb_detallesRestricciones.Size = new System.Drawing.Size(0, 13);
            this.lb_detallesRestricciones.TabIndex = 19;
            // 
            // PruebaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 445);
            this.Controls.Add(this.lb_detallesRestricciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbJustificacion);
            this.Controls.Add(this.lbCantRestricciones);
            this.Controls.Add(this.lbCodTurno);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_fechaTurno);
            this.Controls.Add(this.lbHorasExtras);
            this.Name = "PruebaIngreso";
            this.Text = "PruebaIngreso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbCodTurno;
        private System.Windows.Forms.MaskedTextBox mskEntrada;
        private System.Windows.Forms.MaskedTextBox mskSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTiempo;
        private System.Windows.Forms.DateTimePicker dt_fechaTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHorasExtras;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbJustificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbCantRestricciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_horasTurno;
        private System.Windows.Forms.Label lb_detallesRestricciones;
    }
}