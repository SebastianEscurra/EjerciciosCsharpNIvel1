namespace TPFinal_Escurra;
class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que permita ingresar una lista de números que corta cuando 
        //se ingresa un cero. A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.

        //Nota: evaluar el uso de una función que analice si un número dado es primo o no 
        //y que devuelva true o false según corresponda.
        
        int num,contImpar=0,maxPar=0,minPrimo=0;
        bool banPar=false,banPrimo=false;

        Console.Write("ingrese su numero: ");
        num=int.Parse(Console.ReadLine());

        while (num!=0)
        {
            if (parImpar(num))
            {
                if (!banPar)
                {
                    banPar=true;
                    maxPar=num;
                } else if (num>maxPar)
                    maxPar=num;
            }else 
            contImpar ++;

            if (primo(num))
            {
                if(!banPrimo)
                {
                    banPrimo=true;
                    minPrimo=num;
                } else if (num<minPrimo)
                    minPrimo=num;
            }
                
            Console.Write("(salir=0) ingrese su numero: ");
            num=int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("El mayor numero Par es: -" + maxPar + "-");
        Console.WriteLine("La cantidad de numeros Impares es: -" + contImpar + "-");
        Console.WriteLine("El menor numero Primo es: -" + minPrimo + "-");
    }

    static bool parImpar(int num)
    {
        if (num%2==0)
            return true;
        else
            return false;
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
