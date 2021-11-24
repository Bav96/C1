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
    public partial class FrmHora : Form
    {
        public FrmHora()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            StaLblHora.Text = "Hora Actual: " + DateTime.Now.ToString("T");
        }
    }
}
