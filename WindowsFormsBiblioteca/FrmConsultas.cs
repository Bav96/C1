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
    public partial class FrmConsultas : Form
    {
        List<Libro> Biblioteca;

        public FrmConsultas()
        {
            InitializeComponent();
        }

        public FrmConsultas(List<Libro> biblio)
        {
            InitializeComponent();
            Biblioteca = biblio;
        }

        public void LimpiarBasico()
        {
            this.LstTitulo.Items.Clear();
            this.LstAutorEditorial.Items.Clear();
            
            if (PctFoto.Image != null)
            {
                this.PctFoto.Image.Dispose();
                this.PctFoto.Image = null;
            }
        }

        public void LimpiarCampos()
        {
            this.RdbAutor.Checked = this.RdbEditorial.Checked = false;
            this.LstTitulo.Items.Clear();
            this.LimpiarBasico();
        }

        private void BotonesRadio_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarBasico();

            if (RdbAutor.Checked) //Han seleccionado el RadioButton Autor
            {
                foreach (Libro lib in Biblioteca)
                    if (! LstAutorEditorial.Items.Contains(lib.GetAutor()))
                        LstAutorEditorial.Items.Add(lib.GetAutor());
            }
            else //Han seleccionado el RadioButton Editorial
            {
                foreach (Libro lib in Biblioteca)
                    if (! LstAutorEditorial.Items.Contains(lib.GetEditorial()))
                        LstAutorEditorial.Items.Add(lib.GetEditorial());
            }
        }

        private void LstAutorEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstAutorEditorial.SelectedIndex >= 0)
            {
                LstTitulo.Items.Clear();

                if (RdbAutor.Checked) //En el Listbox de Autores-Editoriales hay Autores.
                {
                    String autor = (String)LstAutorEditorial.Items[LstAutorEditorial.SelectedIndex];
                    foreach (Libro lib in Biblioteca)
                        if (lib.GetAutor().Equals(autor))
                            LstTitulo.Items.Add(lib.GetTitulo());
                }
                else //En el Listbox de Autores-Editoriales hay Editoriales.
                {
                    String editorial = (String)LstAutorEditorial.Items[LstAutorEditorial.SelectedIndex];
                    foreach (Libro lib in Biblioteca)
                        if (lib.GetEditorial().Equals(editorial))
                            LstTitulo.Items.Add(lib.GetTitulo());
                }
            }
        }

        private void LstTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstTitulo.SelectedIndex >= 0)
            {
                int i;
                String titulo = (String)LstTitulo.Items[LstTitulo.SelectedIndex];

                for (i = 0; i < Biblioteca.Count && !Biblioteca[i].GetTitulo().Equals(titulo); i++) ;

                String rutaImagen = Biblioteca[i].GetRutaImagen();
                PctFoto.Image = new Bitmap(rutaImagen);
            }
        }
    }
}
