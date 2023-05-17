namespace forwhile;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        /*Console.Write("ingrese un numero: ");
        int num =int.Parse(Console.ReadLine());
        int contador=0,x=1;
        /*for (int x = 1; x <= num; x++)
        {
            if (num%x==0) 
            contador ++;
        }
        if (contador==2)
        Console.WriteLine($"el numero {num} es primo.");
        else
        Console.WriteLine($"el numero {num} No es primo.");*/
        /*while(x<=num)
        {
            if (num%x==0) 
            contador ++;
            x ++;
        }
        if (contador==2)
        Console.WriteLine($"el numero {num} es primo.");
        else
        Console.WriteLine($"el numero {num} No es primo.");*/
        int num,max=0,min=0,banderaPar=0,banderaImpar=0;
        for (int x = 0; x < 20; x++)
        {
            Console.Write($"v{x+1}--ingrese un numero: ");
            num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                if (banderaPar==0)
                {
                max=num;
                banderaPar=1;
                }
                else if (num>max)
                max=num;
            }else if(banderaImpar==0)
                {
                min=num;
                banderaImpar=1;
                }
                else if (num<min)
                min=num;     
        }
        System.Console.WriteLine($"el maximo par es {max} y el minimo par es {min}.");
    }
}
