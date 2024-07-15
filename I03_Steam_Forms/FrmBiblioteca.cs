using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I03_DefinitivamenteEstoNoEsSteam_Entidades;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
            dtgvBiblioteca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = null;
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Sólo se puede elegir un elemento a la vez");
                }
                else if(dtgvBiblioteca.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Se debe elegir un elemento");
                }
                else
                {
                    Biblioteca biblioteca = dtgvBiblioteca.CurrentRow.DataBoundItem as Biblioteca;
                    if (MessageBox.Show($"Seguro que desea eliminar {biblioteca.Juego}","Eliminar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        JuegoDAO.Eliminar(biblioteca.CodigoJuego);
                        RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            try
            {
                if(frmAlta.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("El juego se dio de alta correctamente.");
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Sólo se puede elegir un elemento a la vez");
                }
                else if (dtgvBiblioteca.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Se debe elegir un elemento");
                }
                else
                {
                    Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
                    FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);
                    if(frmAlta.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Se modificó el juego correctamente");
                        RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
