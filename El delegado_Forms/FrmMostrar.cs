using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_delegado_Forms
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            

        }
        public void ActualizarNombre(string texto)
        {
            lblNombre.Text = texto;

        }
    }
}
