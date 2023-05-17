namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        int precio,cantidad;

        Console.Write("ingrese el precio del producto: ");
        precio=int.Parse(Console.ReadLine());
        Console.Write("ingrese la cantidad: ");
        cantidad=int.Parse(Console.ReadLine());
        System.Console.WriteLine("el precio final es: "+ producto(precio,cantidad));
    }


    static int producto(int _n1,int _n2)
    {
        return _n1*_n2;
    }
}