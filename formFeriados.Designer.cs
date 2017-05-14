namespace SegMayor
{
    partial class formFeriados
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
            this.pickerFeriado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarFeriado = new System.Windows.Forms.Button();
            this.listaFeriados = new System.Windows.Forms.ListView();
            this.bt_guardarFeriados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickerFeriado
            // 
            this.pickerFeriado.Location = new System.Drawing.Point(12, 78);
            this.pickerFeriado.Name = "pickerFeriado";
            this.pickerFeriado.Size = new System.Drawing.Size(200, 20);
            this.pickerFeriado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configurar Feriados";
            // 
            // AgregarFeriado
            // 
            this.AgregarFeriado.Location = new System.Drawing.Point(221, 75);
            this.AgregarFeriado.Name = "AgregarFeriado";
            this.AgregarFeriado.Size = new System.Drawing.Size(75, 23);
            this.AgregarFeriado.TabIndex = 2;
            this.AgregarFeriado.Text = "Agregar";
            this.AgregarFeriado.UseVisualStyleBackColor = true;
            this.AgregarFeriado.Click += new System.EventHandler(this.AgregarFeriado_Click);
            // 
            // listaFeriados
            // 
            this.listaFeriados.Location = new System.Drawing.Point(45, 127);
            this.listaFeriados.Name = "listaFeriados";
            this.listaFeriados.Size = new System.Drawing.Size(209, 97);
            this.listaFeriados.TabIndex = 3;
            this.listaFeriados.UseCompatibleStateImageBehavior = false;
            this.listaFeriados.View = System.Windows.Forms.View.List;
            // 
            // bt_guardarFeriados
            // 
            this.bt_guardarFeriados.Location = new System.Drawing.Point(114, 230);
            this.bt_guardarFeriados.Name = "bt_guardarFeriados";
            this.bt_guardarFeriados.Size = new System.Drawing.Size(75, 23);
            this.bt_guardarFeriados.TabIndex = 4;
            this.bt_guardarFeriados.Text = "Guardar";
            this.bt_guardarFeriados.UseVisualStyleBackColor = true;
            this.bt_guardarFeriados.Click += new System.EventHandler(this.bt_guardarFeriados_Click);
            // 
            // formFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.Controls.Add(this.bt_guardarFeriados);
            this.Controls.Add(this.listaFeriados);
            this.Controls.Add(this.AgregarFeriado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickerFeriado);
            this.Name = "formFeriados";
            this.Text = "Ingreso de Feriados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pickerFeriado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarFeriado;
        private System.Windows.Forms.ListView listaFeriados;
        private System.Windows.Forms.Button bt_guardarFeriados;
    }
}