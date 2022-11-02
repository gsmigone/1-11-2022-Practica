namespace WindowsPresentacion
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
            this.btnAfiVio = new System.Windows.Forms.Button();
            this.btnAfiPia = new System.Windows.Forms.Button();
            this.btnAfiGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfiVio
            // 
            this.btnAfiVio.Location = new System.Drawing.Point(165, 171);
            this.btnAfiVio.Name = "btnAfiVio";
            this.btnAfiVio.Size = new System.Drawing.Size(75, 23);
            this.btnAfiVio.TabIndex = 0;
            this.btnAfiVio.Text = "Afinar Violin";
            this.btnAfiVio.UseVisualStyleBackColor = true;
            this.btnAfiVio.Click += new System.EventHandler(this.btnAfiVio_Click);
            // 
            // btnAfiPia
            // 
            this.btnAfiPia.Location = new System.Drawing.Point(280, 171);
            this.btnAfiPia.Name = "btnAfiPia";
            this.btnAfiPia.Size = new System.Drawing.Size(75, 23);
            this.btnAfiPia.TabIndex = 1;
            this.btnAfiPia.Text = "Afinar Piano";
            this.btnAfiPia.UseVisualStyleBackColor = true;
            this.btnAfiPia.Click += new System.EventHandler(this.btnAfiPia_Click);
            // 
            // btnAfiGui
            // 
            this.btnAfiGui.Location = new System.Drawing.Point(395, 171);
            this.btnAfiGui.Name = "btnAfiGui";
            this.btnAfiGui.Size = new System.Drawing.Size(93, 23);
            this.btnAfiGui.TabIndex = 2;
            this.btnAfiGui.Text = "Afinar Guitarra";
            this.btnAfiGui.UseVisualStyleBackColor = true;
            this.btnAfiGui.Click += new System.EventHandler(this.btnAfiGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiGui);
            this.Controls.Add(this.btnAfiPia);
            this.Controls.Add(this.btnAfiVio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfiVio;
        private System.Windows.Forms.Button btnAfiPia;
        private System.Windows.Forms.Button btnAfiGui;
    }
}

