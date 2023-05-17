namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604

        float n1,n2,n3,promedio;
        Console.WriteLine("n1");
        n1=float.Parse(Console.ReadLine());
        Console.WriteLine("n2");
        n2=float.Parse(Console.ReadLine());
        Console.WriteLine("n3");
        n3=float.Parse(Console.ReadLine());
        promedio=(n1+n2+n3)/3;
        Console.WriteLine( "el promedio es: " + promedio.ToString("0.0") );

    }
}
