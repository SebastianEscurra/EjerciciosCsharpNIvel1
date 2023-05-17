namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int [] numeros= new int [10];
        int max,pos;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese su numero: ");
            numeros[x]= int.Parse(Console.ReadLine());
        }

        pos=1;
        max=numeros[0];

        for (int x = 0; x < 10; x++)
        {
            if (numeros[x]>max){
                max=numeros[x];
                pos=x+1;
            }
        }
        System.Console.WriteLine($"el numero maximo es {max} en la posicion {pos}.");
    }
}
