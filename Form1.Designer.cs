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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_asis
            // 
            this.bt_asis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_asis.Location = new System.Drawing.Point(128, 133);
            this.bt_asis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_asis.Name = "bt_asis";
            this.bt_asis.Size = new System.Drawing.Size(94, 41);
            this.bt_asis.TabIndex = 0;
            this.bt_asis.Text = "Asistencia";
            this.bt_asis.UseVisualStyleBackColor = true;
            this.bt_asis.Click += new System.EventHandler(this.bt_asis_Click);
            // 
            // bt_he
            // 
            this.bt_he.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_he.Location = new System.Drawing.Point(244, 133);
            this.bt_he.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_he.Name = "bt_he";
            this.bt_he.Size = new System.Drawing.Size(94, 41);
            this.bt_he.TabIndex = 1;
            this.bt_he.Text = "Horas extras";
            this.bt_he.UseVisualStyleBackColor = true;
            this.bt_he.Click += new System.EventHandler(this.bt_he_Click);
            // 
            // bt_pagos
            // 
            this.bt_pagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_pagos.Location = new System.Drawing.Point(361, 133);
            this.bt_pagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_pagos.Name = "bt_pagos";
            this.bt_pagos.Size = new System.Drawing.Size(94, 41);
            this.bt_pagos.TabIndex = 2;
            this.bt_pagos.Text = "Pagos";
            this.bt_pagos.UseVisualStyleBackColor = true;
            this.bt_pagos.Click += new System.EventHandler(this.bt_pagos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Administración de trabajadores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modo Desarrollador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_pagos);
            this.Controls.Add(this.bt_he);
            this.Controls.Add(this.bt_asis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "menuPrincipal";
            this.Text = "Seguridad Mayor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_asis;
        private System.Windows.Forms.Button bt_he;
        private System.Windows.Forms.Button bt_pagos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

