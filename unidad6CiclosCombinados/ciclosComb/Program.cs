namespace ciclosComb;
class Program
{
    static void Main(string[] args)
    {
        //CORTE DE CONTROL

        /*int equipo,equipoActual=0, edad, sueldo;

        Console.Write("(0/TERMINAR)ingrese el numero de equipo: ");
        equipo=int.Parse(Console.ReadLine());
        Console.Write("ingrese edad: ");
        edad=int.Parse(Console.ReadLine());
        Console.Write("ingrese la sueldo: ");
        sueldo=int.Parse(Console.ReadLine());

        while (equipo!=0)
        {
            equipoActual=equipo;
            while (equipo==equipoActual)
            {
                //ACA PROCESAMOS
                Console.Write("(0/TERMINAR)ingrese el numero de equipo: ");
                equipo=int.Parse(Console.ReadLine());
                Console.Write("ingrese edad: ");
                edad=int.Parse(Console.ReadLine());
                Console.Write("ingrese la sueldo: ");
                sueldo=int.Parse(Console.ReadLine());
                Console.WriteLine($"bloque {equipoActual}");
            }
            //ACA SE MUESTRA
        }*/

        //FOR CON WHILE

        #pragma warning disable CS8604

        int num,grupoMax=0,porcentajeMax=0,porcentajeI,contadorNum,contadorImpar,contadorOrdenados=0,max;
        bool ordenados;
        for (int x = 0; x < 5; x++)
        {
            contadorNum=0;
            contadorImpar=0;
            ordenados=true;
            

            Console.WriteLine($"grupo nº{x+1}.");
            Console.Write("(0/Terminar) ingrese el numero: ");
            num=int.Parse(Console.ReadLine());
            max=num;
            while (num!=0)
            {   
                contadorNum++;
                if(num%2!=0)
                {
                contadorImpar++;
                }
                if (num>max)
                {
                ordenados=false;
                }else 
                max=num;
                Console.Write("(0/termiar) ingrese el numero: ");
                num=int.Parse(Console.ReadLine());
            }
            
                porcentajeI=(contadorImpar*100)/contadorNum;
                
                if (porcentajeI>porcentajeMax)
                {
                    grupoMax=x+1;
                    porcentajeMax=porcentajeI;
                }
                if (ordenados)
                contadorOrdenados++;
            
        }
        Console.WriteLine($"el grupo con mayor poncentaje de impares es el -{grupoMax}- con {porcentajeMax}% de numeros impares.");
        Console.WriteLine($"el numeros de grupos ordenados de mayor a menor es: {contadorOrdenados}");
    }
}
