using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBiblioteca
{
    public partial class FrmAltas : Form
    {
        List<Libro> Biblioteca;
        String RutaFoto;
        
        public FrmAltas()
        {
            InitializeComponent();
            this.RutaFoto = "";
        }

        public FrmAltas(List<Libro> biblio)
        {
            InitializeComponent();
            this.Biblioteca = biblio;
            this.RutaFoto = "";
        }

        public void LimpiarCampos()
        {
            this.TxtTitulo.Clear();
            this.TxtAutor.Clear();
            this.TxtEditorial.Clear();
            this.ChkNuevo.Checked = false;
            //Libero los recursos que usa la imagen de la foto antes de ponerla a null
            if (this.PctFoto.Image != null)
            {
                this.PctFoto.Image.Dispose();
                this.PctFoto.Image = null;
            }
            //Inicilizo la propiedad que almacena la ruta de la foto.
            this.RutaFoto = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            OpnFleDiaFoto.Filter = "Jpg files(*.jpg;*.jpeg)|*.jpg;*.jpeg";
            OpnFleDiaFoto.FilterIndex = 1;
            resultado = OpnFleDiaFoto.ShowDialog();

            if (resultado.Equals(DialogResult.OK))
            {
                RutaFoto = OpnFleDiaFoto.FileName;
                PctFoto.Image = new Bitmap(RutaFoto);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text == "" || TxtAutor.Text == "" || TxtEditorial.Text == "" || RutaFoto == "")
               MessageBox.Show("Debe rellenar todos los campos", "Error");
            else
            {
                Libro libro = new Libro(TxtTitulo.Text, TxtAutor.Text, TxtEditorial.Text,
                                        RutaFoto, ChkNuevo.Checked);
                Biblioteca.Add(libro);
                MessageBox.Show(libro.ToString(), "Alta correcta");
                LimpiarCampos();
            }
        }
    }
}
