namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604

        int n1;
        Console.Write("ingrese un numero: ");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("elevado al cubo: "  + (n1*n1*n1));
    }
}
