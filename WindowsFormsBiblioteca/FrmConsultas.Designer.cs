
namespace WindowsFormsBiblioteca
{
    partial class FrmConsultas
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
            this.GrpTipoConsulta = new System.Windows.Forms.GroupBox();
            this.RdbEditorial = new System.Windows.Forms.RadioButton();
            this.RdbAutor = new System.Windows.Forms.RadioButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutorEditorial = new System.Windows.Forms.Label();
            this.LblFotoAlta = new System.Windows.Forms.Label();
            this.LstAutorEditorial = new System.Windows.Forms.ListBox();
            this.LstTitulo = new System.Windows.Forms.ListBox();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.GrpTipoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpTipoConsulta
            // 
            this.GrpTipoConsulta.Controls.Add(this.RdbEditorial);
            this.GrpTipoConsulta.Controls.Add(this.RdbAutor);
            this.GrpTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpTipoConsulta.Location = new System.Drawing.Point(34, 30);
            this.GrpTipoConsulta.Name = "GrpTipoConsulta";
            this.GrpTipoConsulta.Size = new System.Drawing.Size(421, 93);
            this.GrpTipoConsulta.TabIndex = 0;
            this.GrpTipoConsulta.TabStop = false;
            this.GrpTipoConsulta.Text = "Tipo de Consulta";
            // 
            // RdbEditorial
            // 
            this.RdbEditorial.AutoSize = true;
            this.RdbEditorial.Location = new System.Drawing.Point(16, 59);
            this.RdbEditorial.Name = "RdbEditorial";
            this.RdbEditorial.Size = new System.Drawing.Size(104, 28);
            this.RdbEditorial.TabIndex = 1;
            this.RdbEditorial.TabStop = true;
            this.RdbEditorial.Text = "Editorial";
            this.RdbEditorial.UseVisualStyleBackColor = true;
            this.RdbEditorial.CheckedChanged += new System.EventHandler(this.BotonesRadio_CheckedChanged);
            // 
            // RdbAutor
            // 
            this.RdbAutor.AutoSize = true;
            this.RdbAutor.Location = new System.Drawing.Point(16, 28);
            this.RdbAutor.Name = "RdbAutor";
            this.RdbAutor.Size = new System.Drawing.Size(78, 28);
            this.RdbAutor.TabIndex = 0;
            this.RdbAutor.TabStop = true;
            this.RdbAutor.Text = "Autor";
            this.RdbAutor.UseVisualStyleBackColor = true;
            this.RdbAutor.CheckedChanged += new System.EventHandler(this.BotonesRadio_CheckedChanged);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(30, 189);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(68, 24);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Título:";
            // 
            // LblAutorEditorial
            // 
            this.LblAutorEditorial.AutoSize = true;
            this.LblAutorEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutorEditorial.Location = new System.Drawing.Point(269, 189);
            this.LblAutorEditorial.Name = "LblAutorEditorial";
            this.LblAutorEditorial.Size = new System.Drawing.Size(155, 24);
            this.LblAutorEditorial.TabIndex = 2;
            this.LblAutorEditorial.Text = "Autor / Editoral:";
            // 
            // LblFotoAlta
            // 
            this.LblFotoAlta.AutoSize = true;
            this.LblFotoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFotoAlta.Location = new System.Drawing.Point(604, 189);
            this.LblFotoAlta.Name = "LblFotoAlta";
            this.LblFotoAlta.Size = new System.Drawing.Size(135, 24);
            this.LblFotoAlta.TabIndex = 5;
            this.LblFotoAlta.Text = "Foto Portada:";
            // 
            // LstAutorEditorial
            // 
            this.LstAutorEditorial.FormattingEnabled = true;
            this.LstAutorEditorial.Location = new System.Drawing.Point(273, 236);
            this.LstAutorEditorial.Name = "LstAutorEditorial";
            this.LstAutorEditorial.Size = new System.Drawing.Size(195, 160);
            this.LstAutorEditorial.TabIndex = 6;
            this.LstAutorEditorial.SelectedIndexChanged += new System.EventHandler(this.LstAutorEditorial_SelectedIndexChanged);
            // 
            // LstTitulo
            // 
            this.LstTitulo.FormattingEnabled = true;
            this.LstTitulo.Location = new System.Drawing.Point(34, 236);
            this.LstTitulo.Name = "LstTitulo";
            this.LstTitulo.Size = new System.Drawing.Size(195, 160);
            this.LstTitulo.TabIndex = 7;
            this.LstTitulo.SelectedIndexChanged += new System.EventHandler(this.LstTitulo_SelectedIndexChanged);
            // 
            // PctFoto
            // 
            this.PctFoto.Location = new System.Drawing.Point(608, 236);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(100, 146);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 10;
            this.PctFoto.TabStop = false;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.LstTitulo);
            this.Controls.Add(this.LstAutorEditorial);
            this.Controls.Add(this.LblFotoAlta);
            this.Controls.Add(this.LblAutorEditorial);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GrpTipoConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.Text = "Consulta de Libros";
            this.GrpTipoConsulta.ResumeLayout(false);
            this.GrpTipoConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpTipoConsulta;
        private System.Windows.Forms.RadioButton RdbEditorial;
        private System.Windows.Forms.RadioButton RdbAutor;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAutorEditorial;
        private System.Windows.Forms.Label LblFotoAlta;
        private System.Windows.Forms.ListBox LstAutorEditorial;
        private System.Windows.Forms.ListBox LstTitulo;
        private System.Windows.Forms.PictureBox PctFoto;
    }
}