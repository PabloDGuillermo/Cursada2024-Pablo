using I03_DefinitivamenteEstoNoEsSteam_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        Juego juegoElegido;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            nupPrecio.Maximum = 10000;
            juegoElegido = JuegoDAO.LeerPorId(codigoJuego);
            PintarForm();
        }

        private void PintarForm()
        {
            this.txtGenero.Text = juegoElegido.Genero;
            this.txtNombre.Text = juegoElegido.Nombre;
            this.nupPrecio.Value = (decimal)juegoElegido.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDAO.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)cmbUsuarios.SelectedItem;
            DialogResult = MessageBox.Show("Desea guardar los datos?","Confirmar",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            if (DialogResult == DialogResult.Yes)
            {
                Juego juego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,juegoElegido.CodigoJuego, usuario.CodigoUsuario);
                if(juegoElegido is not null)
                {
                    JuegoDAO.Modificar(juego);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    JuegoDAO.Guardar(juego);
                    DialogResult = DialogResult.OK;
                }
            }
            else if (DialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
