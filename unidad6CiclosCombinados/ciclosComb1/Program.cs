namespace ciclosComb1;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604

        int num,contLista=0, contNum;

        System.Console.Write("ingrese su numero: ");
        num=int.Parse(Console.ReadLine());
        while (num>=0)
        {
            contLista++;
            contNum=0;
            while (num!=0)
            {
                contNum ++;

                System.Console.Write("(0/salir)ingrese su numero: ");
                num=int.Parse(Console.ReadLine());
            }//fin del while

            Console.WriteLine($"en la lista {contLista} hay {contNum} numeros.");

            Console.Write("(salir del programa?/numero negativo)\n ingrese su numero: ");
            num=int.Parse(Console.ReadLine());
        }//fin del whlile
        System.Console.WriteLine("Fin del programa.");

    }
}
