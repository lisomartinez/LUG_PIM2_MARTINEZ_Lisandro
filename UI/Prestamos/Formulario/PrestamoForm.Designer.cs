namespace UI.Prestamos
{
    partial class PrestamoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrestamoGB = new System.Windows.Forms.GroupBox();
            this.DevolverBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.PrestarBTN = new System.Windows.Forms.Button();
            this.PrestamosGB = new System.Windows.Forms.GroupBox();
            this.PrestamosDGV = new System.Windows.Forms.DataGridView();
            this.LibroGB = new System.Windows.Forms.GroupBox();
            this.LibrosDGV = new System.Windows.Forms.DataGridView();
            this.SocioGB = new System.Windows.Forms.GroupBox();
            this.SociosDGV = new System.Windows.Forms.DataGridView();
            this.DatosPrestamo = new UI.Prestamos.Controles.DatosPrestamo();
            this.PrestamoGB.SuspendLayout();
            this.PrestamosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDGV)).BeginInit();
            this.LibroGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDGV)).BeginInit();
            this.SocioGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SociosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PrestamoGB
            // 
            this.PrestamoGB.Controls.Add(this.DatosPrestamo);
            this.PrestamoGB.Controls.Add(this.DevolverBTN);
            this.PrestamoGB.Controls.Add(this.ModificarBTN);
            this.PrestamoGB.Controls.Add(this.PrestarBTN);
            this.PrestamoGB.Location = new System.Drawing.Point(770, 12);
            this.PrestamoGB.Name = "PrestamoGB";
            this.PrestamoGB.Size = new System.Drawing.Size(341, 651);
            this.PrestamoGB.TabIndex = 3;
            this.PrestamoGB.TabStop = false;
            this.PrestamoGB.Text = "Prestamo";
            // 
            // DevolverBTN
            // 
            this.DevolverBTN.Location = new System.Drawing.Point(202, 221);
            this.DevolverBTN.Name = "DevolverBTN";
            this.DevolverBTN.Size = new System.Drawing.Size(75, 23);
            this.DevolverBTN.TabIndex = 6;
            this.DevolverBTN.Text = "Devolver";
            this.DevolverBTN.UseVisualStyleBackColor = true;
            this.DevolverBTN.Click += new System.EventHandler(this.DevolverBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(102, 221);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificarBTN.TabIndex = 8;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            // 
            // PrestarBTN
            // 
            this.PrestarBTN.Location = new System.Drawing.Point(6, 221);
            this.PrestarBTN.Name = "PrestarBTN";
            this.PrestarBTN.Size = new System.Drawing.Size(75, 23);
            this.PrestarBTN.TabIndex = 8;
            this.PrestarBTN.Text = "Prestar";
            this.PrestarBTN.UseVisualStyleBackColor = true;
            this.PrestarBTN.Click += new System.EventHandler(this.PrestarBTN_Click);
            // 
            // PrestamosGB
            // 
            this.PrestamosGB.Controls.Add(this.PrestamosDGV);
            this.PrestamosGB.Location = new System.Drawing.Point(12, 12);
            this.PrestamosGB.Name = "PrestamosGB";
            this.PrestamosGB.Size = new System.Drawing.Size(733, 215);
            this.PrestamosGB.TabIndex = 2;
            this.PrestamosGB.TabStop = false;
            this.PrestamosGB.Text = "Prestamos";
            // 
            // PrestamosDGV
            // 
            this.PrestamosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamosDGV.Location = new System.Drawing.Point(7, 20);
            this.PrestamosDGV.Name = "PrestamosDGV";
            this.PrestamosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrestamosDGV.Size = new System.Drawing.Size(719, 175);
            this.PrestamosDGV.TabIndex = 0;
            // 
            // LibroGB
            // 
            this.LibroGB.Controls.Add(this.LibrosDGV);
            this.LibroGB.Location = new System.Drawing.Point(12, 233);
            this.LibroGB.Name = "LibroGB";
            this.LibroGB.Size = new System.Drawing.Size(733, 214);
            this.LibroGB.TabIndex = 2;
            this.LibroGB.TabStop = false;
            this.LibroGB.Text = "Libros";
            // 
            // LibrosDGV
            // 
            this.LibrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrosDGV.Location = new System.Drawing.Point(8, 19);
            this.LibrosDGV.Name = "LibrosDGV";
            this.LibrosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibrosDGV.Size = new System.Drawing.Size(719, 189);
            this.LibrosDGV.TabIndex = 0;
            // 
            // SocioGB
            // 
            this.SocioGB.Controls.Add(this.SociosDGV);
            this.SocioGB.Location = new System.Drawing.Point(12, 453);
            this.SocioGB.Name = "SocioGB";
            this.SocioGB.Size = new System.Drawing.Size(733, 210);
            this.SocioGB.TabIndex = 3;
            this.SocioGB.TabStop = false;
            this.SocioGB.Text = "Socios";
            // 
            // SociosDGV
            // 
            this.SociosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SociosDGV.Location = new System.Drawing.Point(7, 19);
            this.SociosDGV.Name = "SociosDGV";
            this.SociosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SociosDGV.Size = new System.Drawing.Size(719, 184);
            this.SociosDGV.TabIndex = 0;
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.FechaPublicacion = new System.DateTime(2019, 11, 27, 17, 37, 20, 16);
            this.DatosPrestamo.Location = new System.Drawing.Point(6, 57);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Numero = 0;
            this.DatosPrestamo.Size = new System.Drawing.Size(319, 60);
            this.DatosPrestamo.TabIndex = 9;
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 684);
            this.Controls.Add(this.SocioGB);
            this.Controls.Add(this.PrestamoGB);
            this.Controls.Add(this.LibroGB);
            this.Controls.Add(this.PrestamosGB);
            this.Name = "PrestamoForm";
            this.Text = "PrestamoForm";
            this.Load += new System.EventHandler(this.PrestamoForm_Load);
            this.PrestamoGB.ResumeLayout(false);
            this.PrestamosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosDGV)).EndInit();
            this.LibroGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDGV)).EndInit();
            this.SocioGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SociosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PrestamoGB;
        private System.Windows.Forms.Button DevolverBTN;
        private System.Windows.Forms.Button PrestarBTN;
        private System.Windows.Forms.GroupBox PrestamosGB;
        private System.Windows.Forms.DataGridView PrestamosDGV;
        private System.Windows.Forms.GroupBox LibroGB;
        private System.Windows.Forms.DataGridView LibrosDGV;
        private System.Windows.Forms.GroupBox SocioGB;
        private System.Windows.Forms.DataGridView SociosDGV;
        private System.Windows.Forms.Button ModificarBTN;
        private Controles.DatosPrestamo DatosPrestamo;
    }
}