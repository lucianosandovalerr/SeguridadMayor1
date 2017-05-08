namespace SegMayor
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            this.bt_asis = new System.Windows.Forms.Button();
            this.bt_he = new System.Windows.Forms.Button();
            this.bt_pagos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_asis
            // 
            this.bt_asis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_asis.Location = new System.Drawing.Point(186, 323);
            this.bt_asis.Name = "bt_asis";
            this.bt_asis.Size = new System.Drawing.Size(125, 50);
            this.bt_asis.TabIndex = 0;
            this.bt_asis.Text = "Asistencia";
            this.bt_asis.UseVisualStyleBackColor = true;
            this.bt_asis.Visible = false;
            this.bt_asis.Click += new System.EventHandler(this.bt_asis_Click);
            // 
            // bt_he
            // 
            this.bt_he.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_he.Location = new System.Drawing.Point(341, 323);
            this.bt_he.Name = "bt_he";
            this.bt_he.Size = new System.Drawing.Size(125, 50);
            this.bt_he.TabIndex = 1;
            this.bt_he.Text = "Horas extras";
            this.bt_he.UseVisualStyleBackColor = true;
            this.bt_he.Visible = false;
            this.bt_he.Click += new System.EventHandler(this.bt_he_Click);
            // 
            // bt_pagos
            // 
            this.bt_pagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pagos.Location = new System.Drawing.Point(497, 323);
            this.bt_pagos.Name = "bt_pagos";
            this.bt_pagos.Size = new System.Drawing.Size(125, 50);
            this.bt_pagos.TabIndex = 2;
            this.bt_pagos.Text = "Pagos";
            this.bt_pagos.UseVisualStyleBackColor = true;
            this.bt_pagos.Visible = false;
            this.bt_pagos.Click += new System.EventHandler(this.bt_pagos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(186, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 3;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_buscar.Location = new System.Drawing.Point(366, 181);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(125, 50);
            this.bt_buscar.TabIndex = 4;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_limpiar.Location = new System.Drawing.Point(497, 181);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(125, 50);
            this.bt_limpiar.TabIndex = 5;
            this.bt_limpiar.Text = "Limpiar";
            this.bt_limpiar.UseVisualStyleBackColor = true;
            // 
            // lb_texto
            // 
            this.lb_texto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(183, 181);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(177, 17);
            this.lb_texto.TabIndex = 6;
            this.lb_texto.Text = "Ingrese ROL de trabajador";
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_pagos);
            this.Controls.Add(this.bt_he);
            this.Controls.Add(this.bt_asis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "menuPrincipal";
            this.Text = "Seguridad Mayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_asis;
        private System.Windows.Forms.Button bt_he;
        private System.Windows.Forms.Button bt_pagos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.Label lb_texto;
    }
}

