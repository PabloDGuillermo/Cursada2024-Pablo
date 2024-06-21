namespace _14_I03
{
    public partial class frmNotepad : Form
    {
        FileDialog ultimoArchivoUsado = null;
        public frmNotepad()
        {
            InitializeComponent();
            this.RefrescarToolStrip();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(ofd.OpenFile());
                    this.ultimoArchivoUsado = ofd;
                    rtbNotepad.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Algo falló pipi");
                }
            }
        }

        public void RefrescarToolStrip()
        {
            tsslCaracteres.Text = $"{rtbNotepad.Text.Count().ToString()} caracteres";
        }

        private void rtbNotepad_TextChanged(object sender, EventArgs e)
        {
            this.RefrescarToolStrip();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                sfd.Filter = "Archivo de texto|.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.OpenFile());
                    this.ultimoArchivoUsado = sfd;
                    sw.Write(rtbNotepad.Text);
                    sw.Close();
                    MessageBox.Show("Archivo guardado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ultimoArchivoUsado is null)
                {
                    guardarComoToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(ultimoArchivoUsado.FileName);
                    sw.Write(rtbNotepad.Text);
                    sw.Close();
                    MessageBox.Show("Archivo guardado con éxito");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo falló otra vez pipi");
            }
        }
    }
}
