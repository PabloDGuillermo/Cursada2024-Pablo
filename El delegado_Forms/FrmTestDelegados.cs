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
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoActualizar(string texto);
        private DelegadoActualizar delegadoActualizar;
        public FrmTestDelegados(DelegadoActualizar delegadoActualizar)
        {
            InitializeComponent();
            this.delegadoActualizar = delegadoActualizar;
        }

    }
}
