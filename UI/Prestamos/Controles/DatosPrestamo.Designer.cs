namespace UI.Prestamos.Controles
{
    partial class DatosPrestamo
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
            this.NumeroCampoNumero = new UI.Shared.CampoNumero();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.FechaDevolucionDTP = new System.Windows.Forms.DateTimePicker();
            this.FechaDevolucionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroCampoNumero
            // 
            this.NumeroCampoNumero.Location = new System.Drawing.Point(97, 0);
            this.NumeroCampoNumero.Name = "NumeroCampoNumero";
            this.NumeroCampoNumero.Numero = 0;
            this.NumeroCampoNumero.Size = new System.Drawing.Size(228, 21);
            this.NumeroCampoNumero.TabIndex = 17;
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Location = new System.Drawing.Point(6, 0);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(44, 13);
            this.NumeroLabel.TabIndex = 16;
            this.NumeroLabel.Text = "Numero";
            // 
            // FechaDevolucionDTP
            // 
            this.FechaDevolucionDTP.Location = new System.Drawing.Point(97, 38);
            this.FechaDevolucionDTP.Name = "FechaDevolucionDTP";
            this.FechaDevolucionDTP.Size = new System.Drawing.Size(218, 20);
            this.FechaDevolucionDTP.TabIndex = 15;
            // 
            // FechaDevolucionLabel
            // 
            this.FechaDevolucionLabel.AutoSize = true;
            this.FechaDevolucionLabel.Location = new System.Drawing.Point(2, 45);
            this.FechaDevolucionLabel.Name = "FechaDevolucionLabel";
            this.FechaDevolucionLabel.Size = new System.Drawing.Size(92, 13);
            this.FechaDevolucionLabel.TabIndex = 14;
            this.FechaDevolucionLabel.Text = "Fecha devolución";
            // 
            // DatosPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumeroCampoNumero);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.FechaDevolucionDTP);
            this.Controls.Add(this.FechaDevolucionLabel);
            this.Name = "DatosPrestamo";
            this.Size = new System.Drawing.Size(319, 60);
            this.Load += new System.EventHandler(this.DatosPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shared.CampoNumero NumeroCampoNumero;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.DateTimePicker FechaDevolucionDTP;
        private System.Windows.Forms.Label FechaDevolucionLabel;
    }
}
