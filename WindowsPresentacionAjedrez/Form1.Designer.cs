namespace WindowsPresentacionAjedrez
{
    partial class Form1
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
            this.btnMuePeo = new System.Windows.Forms.Button();
            this.btnMueTor = new System.Windows.Forms.Button();
            this.btnMueCab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMuePeo
            // 
            this.btnMuePeo.Location = new System.Drawing.Point(104, 170);
            this.btnMuePeo.Name = "btnMuePeo";
            this.btnMuePeo.Size = new System.Drawing.Size(96, 23);
            this.btnMuePeo.TabIndex = 0;
            this.btnMuePeo.Text = "Mueve Peon";
            this.btnMuePeo.UseVisualStyleBackColor = true;
            this.btnMuePeo.Click += new System.EventHandler(this.btnMuePeo_Click);
            // 
            // btnMueTor
            // 
            this.btnMueTor.Location = new System.Drawing.Point(253, 170);
            this.btnMueTor.Name = "btnMueTor";
            this.btnMueTor.Size = new System.Drawing.Size(91, 23);
            this.btnMueTor.TabIndex = 1;
            this.btnMueTor.Text = "Mueve Torre";
            this.btnMueTor.UseVisualStyleBackColor = true;
            this.btnMueTor.Click += new System.EventHandler(this.btnMueTor_Click);
            // 
            // btnMueCab
            // 
            this.btnMueCab.Location = new System.Drawing.Point(390, 170);
            this.btnMueCab.Name = "btnMueCab";
            this.btnMueCab.Size = new System.Drawing.Size(94, 23);
            this.btnMueCab.TabIndex = 2;
            this.btnMueCab.Text = "Mueve Caballo";
            this.btnMueCab.UseVisualStyleBackColor = true;
            this.btnMueCab.Click += new System.EventHandler(this.btnMueCab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMueCab);
            this.Controls.Add(this.btnMueTor);
            this.Controls.Add(this.btnMuePeo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuePeo;
        private System.Windows.Forms.Button btnMueTor;
        private System.Windows.Forms.Button btnMueCab;
    }
}

