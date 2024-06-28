using CRUD_Entidades;
namespace CRUD_Forms
{
    public partial class Form1 : Form
    {
        List<PersonaDTO> listaPersonas;
        PersonaDTO personaDTO = null;
        public Form1()
        {
            InitializeComponent();
            listaPersonas = new List<PersonaDTO>();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                listaPersonas = PersonaDAO.Leer();
                lstPersonas.DataSource = listaPersonas;
                lstPersonas.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                personaDTO = lstPersonas.SelectedItem as PersonaDTO;
                txtNombre.Text = personaDTO.Nombre;
                txtApellido.Text = personaDTO.Apellido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarPersonaSeleccionada())
                {
                    if (MessageBox.Show("Seguro que desea modificar los datos?", "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PersonaDAO.Modificar(personaDTO.Id, txtNombre.Text, txtApellido.Text);
                        RefrescarListBox();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefrescarListBox()
        {
            listaPersonas = PersonaDAO.Leer();
            lstPersonas.DataSource = null;
            lstPersonas.DataSource = listaPersonas;
            personaDTO = null;
            lstPersonas.SelectedItem = null;
        }
        private bool ValidarPersonaSeleccionada()
        {
            if (lstPersonas.SelectedItem != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna persona.","Oh nooo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarPersonaSeleccionada())
                {
                    PersonaDAO.Guardar(txtNombre.Text, txtApellido.Text);
                    RefrescarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarPersonaSeleccionada())
                {
                    personaDTO = lstPersonas.SelectedItem as PersonaDTO;
                    PersonaDAO.Borrar(personaDTO.Id);
                    RefrescarListBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
