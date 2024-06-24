using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLaListaDelSuper
{
    public partial class FrmListaSuper : Form
    {
        public string ruta = $"{Environment.SpecialFolder.ApplicationData}";
        public string nombreArchivo = "listaSupermercado.xml";
        public List<string> listaSupermercado;
        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lstObjetos.DataSource = listaSupermercado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            if (frmAltaModificacion.ShowDialog() == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
                this.RefrescarListBox();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem != null)
            {
                if (MessageBox.Show("Seguro que desea eliminar el objeto?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listaSupermercado.Remove(lstObjetos.SelectedItem.ToString());
                    this.RefrescarListBox();
                }
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem == null)
            {
                MessageBox.Show("No hay ningún objeto seleccionado");
            }
            else
            {
                FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                if (frmAltaModificacion.ShowDialog() == DialogResult.OK)
                {
                    listaSupermercado[lstObjetos.SelectedIndex] = frmAltaModificacion.Objeto;
                    this.RefrescarListBox();
                }

            }
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            ttAgregar.SetToolTip(btnAgregar, "Agregar objeto");
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            ttAgregar.SetToolTip(btnEliminar, "Eliminar objeto");
        }

        private void btnModificar_MouseHover(object sender, EventArgs e)
        {
            ttAgregar.SetToolTip(btnModificar, "Modificar objeto");
        }

        internal void RefrescarListBox()
        {
            lstObjetos.DataSource = null;
            this.lstObjetos.DataSource = listaSupermercado;
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            listaSupermercado = EntidadSerializadora<List<string>>.Leer(ruta, nombreArchivo);
            this.RefrescarListBox();
        }

        private void FrmListaSuper_FormClosing(object sender, FormClosingEventArgs e)
        {
            EntidadSerializadora<List<string>>.Guardar(ruta, nombreArchivo, listaSupermercado);
        }
    }
}
