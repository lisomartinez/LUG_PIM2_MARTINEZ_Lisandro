namespace UI.Socios
{
    partial class SocioForm
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
            this.SociosGB = new System.Windows.Forms.GroupBox();
            this.SociosDGV = new System.Windows.Forms.DataGridView();
            this.SocioGB = new System.Windows.Forms.GroupBox();
            this.DatosSocio = new UI.NombreApellido();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.ModificarBTN = new System.Windows.Forms.Button();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.SociosGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SociosDGV)).BeginInit();
            this.SocioGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SociosGB
            // 
            this.SociosGB.Controls.Add(this.SociosDGV);
            this.SociosGB.Location = new System.Drawing.Point(12, 12);
            this.SociosGB.Name = "SociosGB";
            this.SociosGB.Size = new System.Drawing.Size(662, 533);
            this.SociosGB.TabIndex = 0;
            this.SociosGB.TabStop = false;
            this.SociosGB.Text = "Socios:";
            // 
            // SociosDGV
            // 
            this.SociosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SociosDGV.Location = new System.Drawing.Point(6, 29);
            this.SociosDGV.Name = "SociosDGV";
            this.SociosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SociosDGV.Size = new System.Drawing.Size(650, 488);
            this.SociosDGV.TabIndex = 0;
            this.SociosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SociosDGV_CellClick);
            // 
            // SocioGB
            // 
            this.SocioGB.Controls.Add(this.DatosSocio);
            this.SocioGB.Controls.Add(this.EliminarBTN);
            this.SocioGB.Controls.Add(this.ModificarBTN);
            this.SocioGB.Controls.Add(this.AgregarBTN);
            this.SocioGB.Location = new System.Drawing.Point(680, 12);
            this.SocioGB.Name = "SocioGB";
            this.SocioGB.Size = new System.Drawing.Size(353, 533);
            this.SocioGB.TabIndex = 0;
            this.SocioGB.TabStop = false;
            this.SocioGB.Text = "Socio:";
            this.SocioGB.Enter += new System.EventHandler(this.SocioGB_Enter);
            // 
            // DatosSocio
            // 
            this.DatosSocio.Activo = false;
            this.DatosSocio.Apellido = "";
            this.DatosSocio.AutoSize = true;
            this.DatosSocio.Location = new System.Drawing.Point(24, 29);
            this.DatosSocio.Name = "DatosSocio";
            this.DatosSocio.Nombre = "";
            this.DatosSocio.NroSocio = 0;
            this.DatosSocio.Size = new System.Drawing.Size(290, 126);
            this.DatosSocio.TabIndex = 6;
            this.DatosSocio.Load += new System.EventHandler(this.nombreApellido1_Load_1);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Location = new System.Drawing.Point(239, 194);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(75, 23);
            this.EliminarBTN.TabIndex = 5;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // ModificarBTN
            // 
            this.ModificarBTN.Location = new System.Drawing.Point(125, 194);
            this.ModificarBTN.Name = "ModificarBTN";
            this.ModificarBTN.Size = new System.Drawing.Size(75, 23);
            this.ModificarBTN.TabIndex = 5;
            this.ModificarBTN.Text = "Modificar";
            this.ModificarBTN.UseVisualStyleBackColor = true;
            this.ModificarBTN.Click += new System.EventHandler(this.ModificarBTN_Click);
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Location = new System.Drawing.Point(11, 194);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(75, 23);
            this.AgregarBTN.TabIndex = 5;
            this.AgregarBTN.Text = "Agregar";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // SocioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 549);
            this.Controls.Add(this.SocioGB);
            this.Controls.Add(this.SociosGB);
            this.Name = "SocioForm";
            this.Text = "SocioForm";
            this.Load += new System.EventHandler(this.SocioForm_Load);
            this.SociosGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SociosDGV)).EndInit();
            this.SocioGB.ResumeLayout(false);
            this.SocioGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SociosGB;
        private System.Windows.Forms.GroupBox SocioGB;
        private System.Windows.Forms.DataGridView SociosDGV;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.Button ModificarBTN;
        private System.Windows.Forms.Button AgregarBTN;
        private NombreApellido DatosSocio;
    }
}