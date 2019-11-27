namespace UI.Autores
{
    partial class AutorForm
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
            this.AutoresGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoresDGV = new System.Windows.Forms.DataGridView();
            this.AutorGroupBox = new System.Windows.Forms.GroupBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DatosAutor = new UI.Autores.DatosAutor();
            this.AutoresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoresDGV)).BeginInit();
            this.AutorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoresGroupBox
            // 
            this.AutoresGroupBox.Controls.Add(this.AutoresDGV);
            this.AutoresGroupBox.Location = new System.Drawing.Point(13, 13);
            this.AutoresGroupBox.Name = "AutoresGroupBox";
            this.AutoresGroupBox.Size = new System.Drawing.Size(629, 640);
            this.AutoresGroupBox.TabIndex = 0;
            this.AutoresGroupBox.TabStop = false;
            this.AutoresGroupBox.Text = "Autores";
            // 
            // AutoresDGV
            // 
            this.AutoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoresDGV.Location = new System.Drawing.Point(7, 20);
            this.AutoresDGV.Name = "AutoresDGV";
            this.AutoresDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoresDGV.Size = new System.Drawing.Size(616, 614);
            this.AutoresDGV.TabIndex = 0;
            this.AutoresDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AutorGroupBox
            // 
            this.AutorGroupBox.Controls.Add(this.EliminarButton);
            this.AutorGroupBox.Controls.Add(this.ModificarButton);
            this.AutorGroupBox.Controls.Add(this.AgregarButton);
            this.AutorGroupBox.Controls.Add(this.DatosAutor);
            this.AutorGroupBox.Location = new System.Drawing.Point(667, 12);
            this.AutorGroupBox.Name = "AutorGroupBox";
            this.AutorGroupBox.Size = new System.Drawing.Size(335, 640);
            this.AutorGroupBox.TabIndex = 1;
            this.AutorGroupBox.TabStop = false;
            this.AutorGroupBox.Text = "AutorGroupBox";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(232, 138);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(115, 138);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 1;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(19, 138);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DatosAutor
            // 
            this.DatosAutor.Apellido = "";
            this.DatosAutor.Location = new System.Drawing.Point(19, 29);
            this.DatosAutor.Name = "DatosAutor";
            this.DatosAutor.Nombre = "";
            this.DatosAutor.NroAutor = 0;
            this.DatosAutor.Size = new System.Drawing.Size(288, 92);
            this.DatosAutor.TabIndex = 0;
            // 
            // AutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 665);
            this.Controls.Add(this.AutorGroupBox);
            this.Controls.Add(this.AutoresGroupBox);
            this.Name = "AutorForm";
            this.Text = "AutorForm";
            this.Load += new System.EventHandler(this.AutorForm_Load);
            this.AutoresGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoresDGV)).EndInit();
            this.AutorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutoresGroupBox;
        private System.Windows.Forms.DataGridView AutoresDGV;
        private System.Windows.Forms.GroupBox AutorGroupBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
        private DatosAutor DatosAutor;
    }
}