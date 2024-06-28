using System.Text;

namespace CRUD_Entidades
{
    public class PersonaDTO //Data Transfer Objects DTO sirve para cargar info de una BDD y usarla en el codigo
    {
        private int id;
        private string nombre;
        private string apellido;
        
        public PersonaDTO(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public PersonaDTO(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(nombre);
            sb.AppendLine($" {apellido}");
            return sb.ToString();
        }
    }
}
