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
    public partial class FrmBiblioteca : Form
    {
        List<Libro> Biblioteca;

        FrmHora FormularioHora;
        FrmAltas FormularioAltas;
        FrmConsultas FormularioConsultas;

        public FrmBiblioteca()
        {
            InitializeComponent();
            this.Biblioteca = new List<Libro>();

            //Inicializo la biblioteca con algunos libros para probar mejor las consultas.

            /*
            Biblioteca.Add(new Libro("El Quijote", "Cervantes", "Anaya", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Desert.jpg", false));
            Biblioteca.Add(new Libro("El Hobbit", "J.R.Tolkien", "Alfaguara", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Lighthouse.jpg", false));
            Biblioteca.Add(new Libro("El señor de los anillos", "J.R.Tolkien", "Anaya", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Hydrangeas.jpg", false));
            Biblioteca.Add(new Libro("Novelas Ejemplares", "Cervantes", "Alfaguara", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Jellyfish.jpg", false));
            Biblioteca.Add(new Libro("El Silmarillon", "J.R.Tolkien", "SM", "C:\\Users\\Public\\Pictures\\Sample Pictures\\Koala.jpg", false));
            */
            Biblioteca.Add(new Libro("El Quijote", "Cervantes", "Anaya", "..\\..\\Pictures\\Quijote.jpg", false));
            Biblioteca.Add(new Libro("El Hobbit", "J.R.Tolkien", "Alfaguara", "..\\..\\Pictures\\Hobbit.jpg", false));
            Biblioteca.Add(new Libro("El señor de los anillos", "J.R.Tolkien", "Anaya", "..\\..\\Pictures\\SeñorAnillos.jpg", false));
            Biblioteca.Add(new Libro("Novelas Ejemplares", "Cervantes", "Alfaguara", "..\\..\\Pictures\\NovelasEjemplares.jpeg", false));
            Biblioteca.Add(new Libro("El Silmarillon", "J.R.Tolkien", "SM", "..\\..\\Pictures\\Silmarillon.jpeg", false));
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            //El formularioHora solo se va a mostrar dentro del formulario principal al arranca el programa,
            //luego ya solo se veran los otros dos formularios hilos (el de Altas y el de Consultas) en
            //función de que elemento del menú pinchemos.
            
            FormularioHora = new FrmHora();
            FormularioHora.MdiParent = this;
            FormularioHora.Dock = DockStyle.Fill;
            FormularioHora.Show();
        }

        private void FrmBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {           
            DialogResult resultado = MessageBox.Show("¿Desea realmente salir?", "Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {
                if (e != null) //esta saliendo por el boton X del formulario
                    e.Cancel = true;
                // sino, el evento es "null", es decir, está saliando por el menu "Salir"
            }
            else
            {
                if (e == null)
                    Environment.Exit(0);
                //sino, se produjo el evento "FormClosing" por haber picnchado sonbre la "X" del
                //formulario, con lo que ya se va a cerrar el formulario (y por tanto la aplicación),
                //con lo que no es necesiario ejecutar la función "Exit".
            }                          
        }

        private void MnuFicheroSalir_Click(object sender, EventArgs e)
        {
            FrmBiblioteca_FormClosing(null, null);
        }


        private void MnuFicheroAlta_Click(object sender, EventArgs e)
        {
            if (FormularioAltas == null)
            {
                FormularioAltas = new FrmAltas(Biblioteca);
                FormularioAltas.MdiParent = this;
                FormularioAltas.Dock = DockStyle.Fill;
                FormularioAltas.Show();
            }
            else
            {
                FormularioAltas.LimpiarCampos();
                FormularioAltas.Activate();
            }
                        
            this.Text = FormularioAltas.Text;
        }

        private void MnuFicheroConsulta_Click(object sender, EventArgs e)
        {
            if (FormularioConsultas == null)
            {
                FormularioConsultas = new FrmConsultas(Biblioteca);
                FormularioConsultas.MdiParent = this;
                FormularioConsultas.Dock = DockStyle.Fill;
                FormularioConsultas.Show();
            }
            else
                FormularioConsultas.Activate();
            
            FormularioConsultas.LimpiarCampos();
            this.Text = FormularioConsultas.Text;
        }
    }
}
