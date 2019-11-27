namespace UI
{
    partial class DatosSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.NroSocioLabel = new System.Windows.Forms.Label();
            this.NumeroCampoNumero = new UI.Shared.CampoNumero();
            this.ApellidoCampoTexto = new UI.Shared.CampoTexto();
            this.NombreCampoTexto = new UI.Shared.CampoTexto();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(15, 77);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(50, 13);
            this.ApellidoLabel.TabIndex = 1;
            this.ApellidoLabel.Text = "Apellido: ";
            this.ApellidoLabel.Click += new System.EventHandler(this.ApellidoLabel_Click);
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Location = new System.Drawing.Point(15, 107);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(43, 13);
            this.EstadoLabel.TabIndex = 12;
            this.EstadoLabel.Text = "Estado:";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(64, 106);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ActivoCheckBox.TabIndex = 11;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // NroSocioLabel
            // 
            this.NroSocioLabel.AutoSize = true;
            this.NroSocioLabel.Location = new System.Drawing.Point(3, 9);
            this.NroSocioLabel.Name = "NroSocioLabel";
            this.NroSocioLabel.Size = new System.Drawing.Size(54, 13);
            this.NroSocioLabel.TabIndex = 10;
            this.NroSocioLabel.Text = "Nro Socio";
            this.NroSocioLabel.Click += new System.EventHandler(this.NroSocioLabel_Click);
            // 
            // NumeroCampoNumero
            // 
            this.NumeroCampoNumero.Location = new System.Drawing.Point(64, 3);
            this.NumeroCampoNumero.Name = "NumeroCampoNumero";
            this.NumeroCampoNumero.Numero = 0;
            this.NumeroCampoNumero.Size = new System.Drawing.Size(223, 21);
            this.NumeroCampoNumero.TabIndex = 13;
            this.NumeroCampoNumero.Load += new System.EventHandler(this.NumeroCampoNumero_Load);
            // 
            // ApellidoCampoTexto
            // 
            this.ApellidoCampoTexto.Location = new System.Drawing.Point(64, 69);
            this.ApellidoCampoTexto.Name = "ApellidoCampoTexto";
            this.ApellidoCampoTexto.Size = new System.Drawing.Size(223, 21);
            this.ApellidoCampoTexto.TabIndex = 2;
            this.ApellidoCampoTexto.Texto = "";
            this.ApellidoCampoTexto.Load += new System.EventHandler(this.ApellidoCampoTexto_Load);
            // 
            // NombreCampoTexto
            // 
            this.NombreCampoTexto.Location = new System.Drawing.Point(64, 37);
            this.NombreCampoTexto.Name = "NombreCampoTexto";
            this.NombreCampoTexto.Size = new System.Drawing.Size(223, 21);
            this.NombreCampoTexto.TabIndex = 2;
            this.NombreCampoTexto.Texto = "";
            this.NombreCampoTexto.Load += new System.EventHandler(this.NombreCampoTexto_Load);
            // 
            // DatosSocioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.NumeroCampoNumero);
            this.Controls.Add(this.EstadoLabel);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.NroSocioLabel);
            this.Controls.Add(this.ApellidoCampoTexto);
            this.Controls.Add(this.NombreCampoTexto);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.label1);
            this.Name = "DatosSocio";
            this.Size = new System.Drawing.Size(290, 126);
            this.Load += new System.EventHandler(this.NombreApellido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApellidoLabel;
        private Shared.CampoTexto NombreCampoTexto;
        private Shared.CampoTexto ApellidoCampoTexto;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label NroSocioLabel;
        private Shared.CampoNumero NumeroCampoNumero;
    }
}
