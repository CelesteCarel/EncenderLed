namespace EncenderLed
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
            this.Encender = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encender
            // 
            this.Encender.Location = new System.Drawing.Point(102, 91);
            this.Encender.Name = "Encender";
            this.Encender.Size = new System.Drawing.Size(89, 39);
            this.Encender.TabIndex = 0;
            this.Encender.Text = "Encender";
            this.Encender.UseVisualStyleBackColor = true;
            this.Encender.Click += new System.EventHandler(this.button2_Click);
            // 
            // Apagar
            // 
            this.Apagar.Location = new System.Drawing.Point(102, 146);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(89, 31);
            this.Apagar.TabIndex = 1;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = true;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encender LED";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.Encender);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Encender;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Label label2;
    }
}

