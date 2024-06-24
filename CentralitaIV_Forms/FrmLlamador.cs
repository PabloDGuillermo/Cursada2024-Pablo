using CentralitaIV_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormCentralita
{
    public partial class FrmLlamador : Form
    {
        public Centralita centralita;
        private System.Windows.Forms.TextBox txtSeleccionado;
        public FrmLlamador(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
            InitializeKeypadButtons();
        }
        public Centralita Centralita { get { return this.centralita; } }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            cmbFranja.Enabled = false;
            txtSeleccionado = txtNroDestino;
        }

        private void InitializeKeypadButtons()
        {
            foreach (Control control in gbPanel.Controls)
            {
                if (control is System.Windows.Forms.Button)
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)control;
                    btn.Click += new EventHandler(Button_Click);
                    // Asigna el valor del botón usando la propiedad Tag
                    btn.Tag = btn.Text;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            if (clickedButton != null)
            {
                // Recupera el valor del botón desde la propiedad Tag
                string value = clickedButton.Tag.ToString();
                // Agrega el valor al TextBox
                txtSeleccionado.Text += value;
                EsProvincial(txtNroDestino.Text);
            }
        }

        private void EsProvincial(string nroDestino)
        {
            if (nroDestino.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSeleccionado.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroOrigen_Enter(object sender, EventArgs e)
        {
            txtSeleccionado = sender as System.Windows.Forms.TextBox;
        }

        private void txtNroDestino_Enter(object sender, EventArgs e)
        {
            txtSeleccionado = sender as System.Windows.Forms.TextBox;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (txtNroDestino.Text != "" && txtNroOrigen.Text != "")
            {
                try
                {
                    if (txtNroDestino.Text.StartsWith("#"))
                    {
                        Provincial provincial = new Provincial(random.Next(1, 50), txtNroDestino.Text, txtNroOrigen.Text, (Provincial.Franja)cmbFranja.SelectedValue);
                        centralita += provincial;
                    }
                    else
                    {
                        Local local = new Local(random.Next(1, 50), txtNroDestino.Text, txtNroOrigen.Text, (random.NextSingle() + random.Next(0, 5)));
                        centralita += local;
                    }
                    MessageBox.Show("Llamada exitosa");
                }
                catch(CentralitaException ex)
                {
                    MessageBox.Show($"Mensaje: {ex.Message}\nClase: {ex.NombreClase}\nMetodo: {ex.NombreMetodo}");
                }
            }
            else
            {
                MessageBox.Show("Los números de Origen y/o Destino no pueden estar vacíos");
            }
            
        }
    }
}
