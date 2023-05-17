namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int [] numeros =new int [10];
        int promedio,acu=0;

        for (int x = 0; x < 10; x++)
        {
            System.Console.Write($"ingrese su numero {x+1}: ");
            numeros[x]= int.Parse(Console.ReadLine());
            acu += numeros[x];
        }

        promedio= acu/10;

        for (int x = 0; x < 10; x++)
        {
            if (numeros[x]>promedio){
                System.Console.WriteLine($"el numero {numeros[x]} es mayor al promedio ({promedio})");
            }
        }
    }
}
