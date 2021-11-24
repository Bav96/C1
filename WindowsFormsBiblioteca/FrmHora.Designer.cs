
namespace WindowsFormsBiblioteca
{
    partial class FrmHora
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
            this.components = new System.ComponentModel.Container();
            this.StaBarra = new System.Windows.Forms.StatusStrip();
            this.StaLblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.StaBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaBarra
            // 
            this.StaBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StaBarra.Dock = System.Windows.Forms.DockStyle.None;
            this.StaBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaLblHora});
            this.StaBarra.Location = new System.Drawing.Point(743, 419);
            this.StaBarra.Name = "StaBarra";
            this.StaBarra.Size = new System.Drawing.Size(48, 22);
            this.StaBarra.TabIndex = 0;
            this.StaBarra.Text = "statusStrip1";
            // 
            // StaLblHora
            // 
            this.StaLblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaLblHora.Name = "StaLblHora";
            this.StaLblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // FrmHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHora";
            this.Text = "Hora";
            this.StaBarra.ResumeLayout(false);
            this.StaBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StaBarra;
        private System.Windows.Forms.ToolStripStatusLabel StaLblHora;
        private System.Windows.Forms.Timer Temporizador;
    }
}