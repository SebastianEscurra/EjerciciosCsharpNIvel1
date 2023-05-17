namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        int num,acumulador=0,contador=0;
        System.Console.Write("(0/cortar) ingrese un numero: ");
        num=int.Parse(Console.ReadLine());

        while (num!=0)
        {
            if (primo(num)){
                acumulador+=num;
                contador++;
                System.Console.WriteLine(" es primo");
            }

            Console.Write("ingrese un numero: ");
            num=int.Parse(Console.ReadLine());
        }

        Console.WriteLine("solo teniendo en cuenta los numeros primos el promedio es: " + (acumulador/contador));
    }

    static bool primo(int num)
    {
        int contador=0;
        for (int x = 1; x <= num; x++)
        {
            if (num%x==0)
            contador ++;
        }
        if (contador==2)
            return true;
        else
            return false;
    }
}
