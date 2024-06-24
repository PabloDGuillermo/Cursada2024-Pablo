using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaV_Entidades;
namespace FormCentralita
{
    public partial class FrmMostrar : Form
    {
        public Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }
        public FrmMostrar(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if(tipoLlamada == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in centralita.Llamadas)
                {
                    rtbInfoLlamadas.Text += llamada.ToString();
                }
            }
            else if(tipoLlamada == Llamada.TipoLlamada.Local)
            {
                foreach(Llamada llamada in centralita.Llamadas)
                {
                    if(llamada is Local)
                    {
                        rtbInfoLlamadas.Text += llamada.ToString();
                    }
                }
            }
            else
            {
                foreach (Llamada llamada in centralita.Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        rtbInfoLlamadas.Text += llamada.ToString();
                    }
                }
            }
        }
    }
}
