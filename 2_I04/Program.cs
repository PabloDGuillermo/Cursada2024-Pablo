namespace _2_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float operando1;
            float operando2;
            char operacion;
            float resultado;

            do
            {
                do
                {
                    Console.Write("Ingrese el primer operando: ");
                } while(!(float.TryParse(Console.ReadLine(), out operando1)));
                do
                {
                    Console.Write("Ingrese el segundo operando: ");
                } while (!(float.TryParse(Console.ReadLine(), out operando2)));
                do
                {
                    Console.Write("Ingrese la operacion ('+', '-', '*' o '/'): ");
                    char.TryParse(Console.ReadLine(), out operacion);
                } while (!(operacion != '+' || operacion != '-' || operacion != '*' || operacion != '/'));

                resultado = Calculadora.Calcular(operando1, operando2, operacion);

                if(resultado is not float.NaN)
                {
                    Console.WriteLine($"El resultado de {operando1} {operacion} {operando2} es {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0.");
                }
                
                Console.Write("Desea realizar otra operación? (S/N): ");
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
