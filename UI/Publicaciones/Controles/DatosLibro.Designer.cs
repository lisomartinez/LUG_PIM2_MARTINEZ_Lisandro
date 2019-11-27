namespace UI.Publicaciones
{
    partial class DatosLibro
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
            this.FechaDTP = new System.Windows.Forms.DateTimePicker();
            this.EditorialLabel = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.NroLabel = new System.Windows.Forms.Label();
            this.TituloCampo = new UI.Shared.CampoTextoCompuesto();
            this.EditorialCampo = new UI.Shared.CampoTextoCompuesto();
            this.NumeroCampo = new UI.Shared.CampoNumero();
            this.IsbnCampo = new UI.Publicaciones.CampoISBN();
            this.SuspendLayout();
            // 
            // FechaDTP
            // 
            this.FechaDTP.Location = new System.Drawing.Point(59, 30);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(220, 20);
            this.FechaDTP.TabIndex = 21;
            // 
            // EditorialLabel
            // 
            this.EditorialLabel.AutoSize = true;
            this.EditorialLabel.Location = new System.Drawing.Point(10, 140);
            this.EditorialLabel.Name = "EditorialLabel";
            this.EditorialLabel.Size = new System.Drawing.Size(44, 13);
            this.EditorialLabel.TabIndex = 16;
            this.EditorialLabel.Text = "Editorial";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(9, 105);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(32, 13);
            this.ISBNLabel.TabIndex = 17;
            this.ISBNLabel.Text = "ISBN";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Location = new System.Drawing.Point(9, 66);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(33, 13);
            this.TituloLabel.TabIndex = 18;
            this.TituloLabel.Text = "Titulo";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(9, 37);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 19;
            this.FechaLabel.Text = "Fecha";
            // 
            // NroLabel
            // 
            this.NroLabel.AutoSize = true;
            this.NroLabel.Location = new System.Drawing.Point(12, 11);
            this.NroLabel.Name = "NroLabel";
            this.NroLabel.Size = new System.Drawing.Size(24, 13);
            this.NroLabel.TabIndex = 20;
            this.NroLabel.Text = "Nro";
            // 
            // TituloCampo
            // 
            this.TituloCampo.Location = new System.Drawing.Point(59, 66);
            this.TituloCampo.Name = "TituloCampo";
            this.TituloCampo.Size = new System.Drawing.Size(220, 19);
            this.TituloCampo.TabIndex = 22;
            this.TituloCampo.Texto = "";
            // 
            // EditorialCampo
            // 
            this.EditorialCampo.Location = new System.Drawing.Point(60, 134);
            this.EditorialCampo.Name = "EditorialCampo";
            this.EditorialCampo.Size = new System.Drawing.Size(219, 19);
            this.EditorialCampo.TabIndex = 23;
            this.EditorialCampo.Texto = "";
            // 
            // NumeroCampo
            // 
            this.NumeroCampo.Location = new System.Drawing.Point(59, 3);
            this.NumeroCampo.Name = "NumeroCampo";
            this.NumeroCampo.Numero = 0;
            this.NumeroCampo.Size = new System.Drawing.Size(220, 21);
            this.NumeroCampo.TabIndex = 24;
            // 
            // IsbnCampo
            // 
            this.IsbnCampo.Location = new System.Drawing.Point(59, 99);
            this.IsbnCampo.Name = "IsbnCampo";
            this.IsbnCampo.Size = new System.Drawing.Size(220, 19);
            this.IsbnCampo.TabIndex = 25;
            // 
            // DatosLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsbnCampo);
            this.Controls.Add(this.NumeroCampo);
            this.Controls.Add(this.EditorialCampo);
            this.Controls.Add(this.TituloCampo);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.EditorialLabel);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.NroLabel);
            this.Name = "DatosLibro";
            this.Size = new System.Drawing.Size(292, 163);
            this.Load += new System.EventHandler(this.DatosLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.CampoNumero NroCampoNumero;
        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.Label EditorialLabel;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label NroLabel;
        private Shared.CampoTextoCompuesto TituloCampo;
        private Shared.CampoTextoCompuesto EditorialCampo;
        private Shared.CampoNumero NumeroCampo;
        private CampoISBN IsbnCampo;
    }
}
