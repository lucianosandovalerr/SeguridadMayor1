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
            this.label2 = new System.Windows.Forms.Label();
            this.mskEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mskSalida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTiempo = new System.Windows.Forms.MaskedTextBox();
            this.dt_fechaTurno = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_tipoDia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbJustificacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTurno = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codTurno = new System.Windows.Forms.Label();
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COD TURNO";
            // 
            // mskEntrada
            // 
            this.mskEntrada.Location = new System.Drawing.Point(130, 118);
            this.mskEntrada.Mask = "00:00";
            this.mskEntrada.Name = "mskEntrada";
            this.mskEntrada.Size = new System.Drawing.Size(34, 20);
            this.mskEntrada.TabIndex = 4;
            this.mskEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // mskSalida
            // 
            this.mskSalida.Location = new System.Drawing.Point(170, 118);
            this.mskSalida.Mask = "00:00";
            this.mskSalida.Name = "mskSalida";
            this.mskSalida.Size = new System.Drawing.Size(34, 20);
            this.mskSalida.TabIndex = 4;
            this.mskSalida.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Entrada y Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colación";
            // 
            // mskTiempo
            // 
            this.mskTiempo.Location = new System.Drawing.Point(286, 118);
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
            this.dt_fechaTurno.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // lb_tipoDia
            // 
            this.lb_tipoDia.AutoSize = true;
            this.lb_tipoDia.Location = new System.Drawing.Point(391, 49);
            this.lb_tipoDia.Name = "lb_tipoDia";
            this.lb_tipoDia.Size = new System.Drawing.Size(64, 13);
            this.lb_tipoDia.TabIndex = 9;
            this.lb_tipoDia.Text = "Tipo de Día";
            this.lb_tipoDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Horas Extras del Turno:";
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
            this.label8.Location = new System.Drawing.Point(346, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cantidad horas del Turno";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // mskTurno
            // 
            this.mskTurno.Location = new System.Drawing.Point(478, 118);
            this.mskTurno.Mask = "00:00";
            this.mskTurno.Name = "mskTurno";
            this.mskTurno.Size = new System.Drawing.Size(34, 20);
            this.mskTurno.TabIndex = 4;
            this.mskTurno.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad de Restricciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.codTurno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mskEntrada);
            this.panel1.Controls.Add(this.mskSalida);
            this.panel1.Controls.Add(this.mskTiempo);
            this.panel1.Controls.Add(this.mskTurno);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(26, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 258);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // codTurno
            // 
            this.codTurno.AutoSize = true;
            this.codTurno.Location = new System.Drawing.Point(335, 14);
            this.codTurno.Name = "codTurno";
            this.codTurno.Size = new System.Drawing.Size(16, 13);
            this.codTurno.TabIndex = 18;
            this.codTurno.Text = "   ";
            this.codTurno.Click += new System.EventHandler(this.codTurno_Click);
            // 
            // PruebaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbJustificacion);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lb_tipoDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_fechaTurno);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskEntrada;
        private System.Windows.Forms.MaskedTextBox mskSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTiempo;
        private System.Windows.Forms.DateTimePicker dt_fechaTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_tipoDia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbJustificacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTurno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label codTurno;
    }
}