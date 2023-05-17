namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604

        const float sueldo=15000,porcentaje=0.05f;
        float totalf,sueldofinal;
        Console.Write("ingrese el total facturado:");
        totalf=float.Parse(Console.ReadLine());
        sueldofinal=(totalf*porcentaje)+sueldo;
        Console.Write("sueldo: "+sueldofinal);

    }
}
