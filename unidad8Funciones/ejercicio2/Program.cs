namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int contador=0;
        int [] num= new int [20];
        cargar(num);
        for (int x = 0; x < 20; x++)
        {
            if (par(num[x])==1)
                contador++;
        }
        System.Console.WriteLine("los pares son: "+ contador);

    }

    static int par (int num)
    {
        if (num%2==0)
            return 1;
         else 
            return 0;
    }

    static void cargar(int []vector)
    {
        for (int x = 0; x < 20; x++)
        {
            System.Console.WriteLine("ingrese su numero: ");
            vector[x]=int.Parse(Console.ReadLine());
        }
    }
}
