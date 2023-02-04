namespace ejerciciio
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
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.MOSTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(149, 55);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 22);
            this.numero.TabIndex = 1;
            // 
            // MOSTRAR
            // 
            this.MOSTRAR.Location = new System.Drawing.Point(142, 112);
            this.MOSTRAR.Name = "MOSTRAR";
            this.MOSTRAR.Size = new System.Drawing.Size(107, 47);
            this.MOSTRAR.TabIndex = 2;
            this.MOSTRAR.Text = "MOSTRAR";
            this.MOSTRAR.UseVisualStyleBackColor = true;
            this.MOSTRAR.Click += new System.EventHandler(this.MOSTRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 301);
            this.Controls.Add(this.MOSTRAR);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button MOSTRAR;
    }
}

