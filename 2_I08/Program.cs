namespace _2_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            Console.Write("Día: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Año: ");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcularDiasVividos(new DateTime(año, mes, dia)));
        }

        public static int CalcularDiasVividos(DateTime fechaNacimiento)
        {
            TimeSpan diasVividos;
            diasVividos = DateTime.Today - fechaNacimiento;

            return diasVividos.Days;
        }
    }
}
