namespace FormsLaListaDelSuper
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }
        public FrmAltaModificacion(string titulo, string texto, string textoBoton)
        {
            InitializeComponent();
            this.Text = titulo;
            this.txtObjeto.Text = texto;
            this.btnConfirmar.Text = textoBoton;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Confirmacion();
        }

        internal void Confirmacion()
        {
            if (txtObjeto.Text == null || txtObjeto.Text == "")
            {
                MessageBox.Show("El texto no puede estar vacío");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Confirmacion();
            }
            else if (e.KeyChar == (char)27)
            {
                this.DialogResult= DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
