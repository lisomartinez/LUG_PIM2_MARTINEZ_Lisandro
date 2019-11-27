namespace UI.Autores
{
    partial class DatosAutor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NroAutorLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroCampoNumero = new UI.Shared.CampoNumero();
            this.ApellidoCampoTexto = new UI.Shared.CampoTexto();
            this.NombreCampoTexto = new UI.Shared.CampoTexto();
            this.SuspendLayout();
            // 
            // NroAutorLabel
            // 
            this.NroAutorLabel.AutoSize = true;
            this.NroAutorLabel.Location = new System.Drawing.Point(3, 6);
            this.NroAutorLabel.Name = "NroAutorLabel";
            this.NroAutorLabel.Size = new System.Drawing.Size(49, 13);
            this.NroAutorLabel.TabIndex = 18;
            this.NroAutorLabel.Text = "NroAutor";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(15, 74);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(50, 13);
            this.ApellidoLabel.TabIndex = 14;
            this.ApellidoLabel.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // NumeroCampoNumero
            // 
            this.NumeroCampoNumero.Location = new System.Drawing.Point(64, 0);
            this.NumeroCampoNumero.Name = "NumeroCampoNumero";
            this.NumeroCampoNumero.Numero = 0;
            this.NumeroCampoNumero.Size = new System.Drawing.Size(223, 21);
            this.NumeroCampoNumero.TabIndex = 19;
            this.NumeroCampoNumero.Load += new System.EventHandler(this.NumeroCampoNumero_Load);
            // 
            // ApellidoCampoTexto
            // 
            this.ApellidoCampoTexto.Location = new System.Drawing.Point(64, 66);
            this.ApellidoCampoTexto.Name = "ApellidoCampoTexto";
            this.ApellidoCampoTexto.Size = new System.Drawing.Size(223, 21);
            this.ApellidoCampoTexto.TabIndex = 16;
            this.ApellidoCampoTexto.Texto = "";
            // 
            // NombreCampoTexto
            // 
            this.NombreCampoTexto.Location = new System.Drawing.Point(64, 34);
            this.NombreCampoTexto.Name = "NombreCampoTexto";
            this.NombreCampoTexto.Size = new System.Drawing.Size(223, 21);
            this.NombreCampoTexto.TabIndex = 17;
            this.NombreCampoTexto.Texto = "";
            // 
            // DatosAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumeroCampoNumero);
            this.Controls.Add(this.NroAutorLabel);
            this.Controls.Add(this.ApellidoCampoTexto);
            this.Controls.Add(this.NombreCampoTexto);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.label1);
            this.Name = "DatosAutor";
            this.Size = new System.Drawing.Size(288, 92);
            this.Load += new System.EventHandler(this.DatosAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.CampoNumero NumeroCampoNumero;
        private System.Windows.Forms.Label NroAutorLabel;
        private Shared.CampoTexto ApellidoCampoTexto;
        private Shared.CampoTexto NombreCampoTexto;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.Label label1;
    }
}
