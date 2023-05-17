namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        int [] articulos= new int [15];
        int max,articuloMax,numArticulo,cantidad;

        System.Console.Write("ingrese el numero de articulo: ");
        numArticulo=int.Parse(Console.ReadLine());
        System.Console.Write("ingrese la cantidad vendida: ");
        cantidad=int.Parse(Console.ReadLine());
        
        while (numArticulo!=0)
        {
            articulos[numArticulo-1]+=cantidad;
            System.Console.Write("ingrese el numero de articulo: ");
            numArticulo=int.Parse(Console.ReadLine());
            System.Console.Write("ingrese la cantidad vendida: ");
            cantidad=int.Parse(Console.ReadLine());
        }

        max=articulos[0];
        articuloMax=1;
        System.Console.WriteLine();

        for (int x = 0; x < 15; x++)
        {
            if (articulos[x]>max){
                max=articulos[x];
                articuloMax=x+1;
            }
            
        }

        System.Console.WriteLine("\n\n la cantidad vendida del articulo 10 es: "+ articulos[10-1]);
        System.Console.WriteLine($"el articulo can mas ventas es: {articuloMax} con {max} vendidos.");

        for (int x = 0; x < 15; x++)
        {
             if(articulos[x]==0){
                    System.Console.WriteLine($"el articulo {x+1} no tuvo ventas.");
                }
        }
    }
}
