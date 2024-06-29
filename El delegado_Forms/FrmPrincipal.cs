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
    public partial class FrmPrincipal : Form
    {
        FrmMostrar frmMostrar;
        FrmTestDelegados frmTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados();
            frmTestDelegados.dele frmMostrar.ActualizarNombre;
            frmTestDelegados.MdiParent = this;
            mnuMostrar.Enabled = false;
        }

        private void mnuMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }

        private void smnuTestDelegados_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            if(frmTestDelegados.Visible == true)
            {
                mnuMostrar.Enabled = true;
            }
        }
    }
}
