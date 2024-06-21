using CentralitaII;
namespace FormCentralita
{
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita();
        }

        private void FrmMenu_Load(object sender, EventArgs e) { }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
