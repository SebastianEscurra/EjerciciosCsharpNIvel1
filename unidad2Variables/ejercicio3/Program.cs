namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        
        float km,velocidad,tiempo;
        Console.WriteLine("km");
        km=float.Parse(Console.ReadLine());
        Console.WriteLine("velocidad");
        velocidad=float.Parse(Console.ReadLine());
        tiempo=km/velocidad;
        Console.WriteLine("tiempo: "+ tiempo);
        
    }
}
