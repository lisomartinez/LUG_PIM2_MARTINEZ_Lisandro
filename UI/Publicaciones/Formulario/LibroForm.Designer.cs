namespace UI.Publicaciones
{
    partial class LibroForm
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
            this.LibrosGB = new System.Windows.Forms.GroupBox();
            this.LibrosDGV = new System.Windows.Forms.DataGridView();
            this.LibroGB = new System.Windows.Forms.GroupBox();
            this.AutoresLibroLB = new System.Windows.Forms.ListBox();
            this.AutoresLB = new System.Windows.Forms.ListBox();
            this.EliminarAutorButton = new System.Windows.Forms.Button();
            this.AgregarAutorButton = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.DatosLibro = new UI.Publicaciones.DatosLibro();
            this.LibrosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDGV)).BeginInit();
            this.LibroGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // LibrosGB
            // 
            this.LibrosGB.Controls.Add(this.LibrosDGV);
            this.LibrosGB.Location = new System.Drawing.Point(12, 24);
            this.LibrosGB.Name = "LibrosGB";
            this.LibrosGB.Size = new System.Drawing.Size(673, 501);
            this.LibrosGB.TabIndex = 0;
            this.LibrosGB.TabStop = false;
            this.LibrosGB.Text = "Libros";
            // 
            // LibrosDGV
            // 
            this.LibrosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibrosDGV.Location = new System.Drawing.Point(7, 20);
            this.LibrosDGV.Name = "LibrosDGV";
            this.LibrosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LibrosDGV.Size = new System.Drawing.Size(650, 464);
            this.LibrosDGV.TabIndex = 0;
            this.LibrosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibrosDGV_CellClick);
            // 
            // LibroGB
            // 
            this.LibroGB.Controls.Add(this.DatosLibro);
            this.LibroGB.Controls.Add(this.AutoresLibroLB);
            this.LibroGB.Controls.Add(this.AutoresLB);
            this.LibroGB.Controls.Add(this.EliminarAutorButton);
            this.LibroGB.Controls.Add(this.AgregarAutorButton);
            this.LibroGB.Controls.Add(this.EliminarBTN);
            this.LibroGB.Controls.Add(this.ModificarBTN);
            this.LibroGB.Controls.Add(this.AgregarBTN);
            this.LibroGB.Location = new System.Drawing.Point(691, 24);
            this.LibroGB.Name = "LibroGB";
            this.LibroGB.Size = new System.Drawing.Size(529, 501);
            this.LibroGB.TabIndex = 1;
            this.LibroGB.TabStop = false;
            this.LibroGB.Text = "Libro";
            // 
            // AutoresLibroLB
            // 
            this.AutoresLibroLB.FormattingEnabled = true;
            this.AutoresLibroLB.Location = new System.Drawing.Point(293, 231);
            this.AutoresLibroLB.Name = "AutoresLibroLB";
            this.AutoresLibroLB.Size = new System.Drawing.Size(236, 186);
            this.AutoresLibroLB.TabIndex = 1;
            // 
            // AutoresLB
            // 
            this.AutoresLB.FormattingEnabled = true;
            this.AutoresLB.Location = new System.Drawing.Point(2, 230);
            this.AutoresLB.Name = "AutoresLB";
            this.AutoresLB.Size = new System.Drawing.Size(236, 186);
            this.AutoresLB.TabIndex = 1;
            // 
            // EliminarAutorButton
            // 
            this.EliminarAutorButton.Location = new System.Drawing.Point(244, 328);
            this.EliminarAutorButton.Name = "EliminarAutorButton";
            this.EliminarAutorButton.Size = new System.Drawing.Size(45, 89);
            this.EliminarAutorButton.TabIndex = 12;
            this.EliminarAutorButton.Text = "<<";
            this.EliminarAutorButton.UseVisualStyleBackColor = true;
            this.EliminarAutorButton.Click += new System.EventHandler(this.EliminarAutorButton_Click);
            // 
            // AgregarAutorButton
            // 
            this.AgregarAutorButton.Location = new System.Drawing.Point(244, 230);
            this.AgregarAutorButton.Name = "AgregarAutorButton";
            this.AgregarAutorButton.Size = new System.Drawing.Size(45, 89);
            this.AgregarAutorButton.TabIndex = 12;
            this.AgregarAutorButton.Text = ">>";
            this.AgregarAutorButton.UseVisualStyleBackColor = true;
            this.AgregarAutorButton.Click += new System.EventHandler(this.AgregarAutorButton_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(275, 457);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(75, 23);
            this.EliminarBTN.TabIndex = 6;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(161, 457);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificarBTN.TabIndex = 7;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Location = new System.Drawing.Point(47, 457);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(75, 23);
            this.AgregarBTN.TabIndex = 8;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // DatosLibroControl
            // 
            this.DatosLibro.Location = new System.Drawing.Point(6, 19);
            this.DatosLibro.Name = "DatosLibro";
            this.DatosLibro.Size = new System.Drawing.Size(374, 204);
            this.DatosLibro.TabIndex = 13;
            // 
            // LibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 644);
            this.Controls.Add(this.LibroGB);
            this.Controls.Add(this.LibrosGB);
            this.Name = "LibroForm";
            this.Text = "LibroForm";
            this.Load += new System.EventHandler(this.LibroForm_Load);
            this.LibrosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosDGV)).EndInit();
            this.LibroGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LibrosGB;
        private System.Windows.Forms.DataGridView LibrosDGV;
        private System.Windows.Forms.GroupBox LibroGB;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button AgregarBTN;
        private Shared.CampoNumero NroCampoNumero;
        private System.Windows.Forms.Button EliminarAutorButton;
        private System.Windows.Forms.Button AgregarAutorButton;
        private Shared.CampoTexto EditorialCampoTexto;
        private Shared.CampoTexto TitulocampoTexto;
        private System.Windows.Forms.ListBox AutoresLibroLB;
        private System.Windows.Forms.ListBox AutoresLB;
        private DatosLibro DatosLibro;
    }
}