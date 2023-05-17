namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604

        int num, resultado=0;

        System.Console.Write("ingrese su numero: ");
        num=int.Parse(Console.ReadLine());

        positivoNegativoCero(num,ref resultado);

        if (resultado==1)
        System.Console.WriteLine("el numero ingresado es positivo");
        else if (resultado==0)
        System.Console.WriteLine("el numero ingresado es cero");
        else
        System.Console.WriteLine("el numero ingresado es negativo");



    }


    static void positivoNegativoCero(int num, ref int variable)
    {
        if(num>0)
        variable=1;
        else if(num==0)
        variable=0;
        else
        variable=-1;
    }
}
