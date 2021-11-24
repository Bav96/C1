
namespace WindowsFormsBiblioteca
{
    partial class FrmAltas
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblEditorial = new System.Windows.Forms.Label();
            this.LblNuevo = new System.Windows.Forms.Label();
            this.LblFotoAlta = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.ChkNuevo = new System.Windows.Forms.CheckBox();
            this.PctFoto = new System.Windows.Forms.PictureBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.OpnFleDiaFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(89, 76);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(68, 24);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título:";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Location = new System.Drawing.Point(89, 115);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(66, 24);
            this.LblAutor.TabIndex = 1;
            this.LblAutor.Text = "Autor:";
            // 
            // LblEditorial
            // 
            this.LblEditorial.AutoSize = true;
            this.LblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditorial.Location = new System.Drawing.Point(89, 157);
            this.LblEditorial.Name = "LblEditorial";
            this.LblEditorial.Size = new System.Drawing.Size(92, 24);
            this.LblEditorial.TabIndex = 2;
            this.LblEditorial.Text = "Editorial:";
            // 
            // LblNuevo
            // 
            this.LblNuevo.AutoSize = true;
            this.LblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevo.Location = new System.Drawing.Point(89, 201);
            this.LblNuevo.Name = "LblNuevo";
            this.LblNuevo.Size = new System.Drawing.Size(77, 24);
            this.LblNuevo.TabIndex = 3;
            this.LblNuevo.Text = "Nuevo:";
            // 
            // LblFotoAlta
            // 
            this.LblFotoAlta.AutoSize = true;
            this.LblFotoAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFotoAlta.Location = new System.Drawing.Point(584, 33);
            this.LblFotoAlta.Name = "LblFotoAlta";
            this.LblFotoAlta.Size = new System.Drawing.Size(135, 24);
            this.LblFotoAlta.TabIndex = 4;
            this.LblFotoAlta.Text = "Foto Portada:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(219, 76);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(205, 26);
            this.TxtTitulo.TabIndex = 5;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(219, 115);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(205, 26);
            this.TxtAutor.TabIndex = 6;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditorial.Location = new System.Drawing.Point(219, 157);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(205, 26);
            this.TxtEditorial.TabIndex = 7;
            // 
            // ChkNuevo
            // 
            this.ChkNuevo.AutoSize = true;
            this.ChkNuevo.Location = new System.Drawing.Point(219, 208);
            this.ChkNuevo.Name = "ChkNuevo";
            this.ChkNuevo.Size = new System.Drawing.Size(15, 14);
            this.ChkNuevo.TabIndex = 8;
            this.ChkNuevo.UseVisualStyleBackColor = true;
            // 
            // PctFoto
            // 
            this.PctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctFoto.Location = new System.Drawing.Point(588, 76);
            this.PctFoto.Name = "PctFoto";
            this.PctFoto.Size = new System.Drawing.Size(100, 146);
            this.PctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctFoto.TabIndex = 9;
            this.PctFoto.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(93, 291);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 42);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(303, 291);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 42);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarFoto.Location = new System.Drawing.Point(588, 291);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(131, 42);
            this.BtnCargarFoto.TabIndex = 12;
            this.BtnCargarFoto.Text = "Cargar Foto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            this.BtnCargarFoto.Click += new System.EventHandler(this.BtnCargarFoto_Click);
            // 
            // OpnFleDiaFoto
            // 
            this.OpnFleDiaFoto.FileName = "OpnFleDiaFoto";
            // 
            // FrmAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.PctFoto);
            this.Controls.Add(this.ChkNuevo);
            this.Controls.Add(this.TxtEditorial);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblFotoAlta);
            this.Controls.Add(this.LblNuevo);
            this.Controls.Add(this.LblEditorial);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltas";
            this.Text = "Alta de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.PctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblEditorial;
        private System.Windows.Forms.Label LblNuevo;
        private System.Windows.Forms.Label LblFotoAlta;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.CheckBox ChkNuevo;
        private System.Windows.Forms.PictureBox PctFoto;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.OpenFileDialog OpnFleDiaFoto;
    }
}