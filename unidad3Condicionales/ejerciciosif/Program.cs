namespace ejerciciosif;
class Program
{
    static void Main(string[] args)
    {
        //positivo negativo igual a 0
        /*char n1;
        Console.Write("ingrese un numero: ");
        n1=char.Parse(Console.ReadLine());
        if (n1==0) Console.WriteLine("es igual a cero");
        else if (n1>0) Console.WriteLine("es positivo");
        else Console.WriteLine("es negativo");*/
        //descuentos
        /*float venta,importeFinal=0;
        Console.Write("ingrese el importe de la compra: ");
        venta=float.Parse(Console.ReadLine());

        if (venta>=5000) importeFinal=venta*0.82f;
        else if (venta>=1000) importeFinal= venta*0.9f;
        else importeFinal= venta;
        Console.WriteLine(importeFinal);*/
        //4 numeros distcharos mostrar el menor de ellos
        /*char n1=0,n2=0,n3=0,n4=0,menor;

        Console.Write("ingrese un numero: ");
        n1=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n2=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n3=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n4=char.Parse(Console.ReadLine());
       
        if (n1<n2) 
        menor=n1;
        else 
        menor=n2;

        if (n3<menor) 
        menor=n3;

        if (n4<menor) 
        menor=n4;
        Console.WriteLine("el menor es: "+ menor);*/
        
        /*char n1,n2,n3,n4;
        Console.Write("ingrese un numero: ");
        n1=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n2=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n3=char.Parse(Console.ReadLine());
        Console.Write("ingrese un numero: ");
        n4=char.Parse(Console.ReadLine());

        Console.WriteLine("los numeros mayores a 100 son: ");
        if (n1>100) Console.WriteLine(n1);
        if (n2>100) Console.WriteLine(n2);
        if (n3>100) Console.WriteLine(n3);
        if (n4>100) Console.WriteLine(n4);*/
        
        
        /*char n1,n2;
        Console.Write("ingrese el primer numero: ");
        n1=char.Parse(Console.ReadLine());
        Console.Write("ingrese els segundo numero: ");
        n2=char.Parse(Console.ReadLine());

        if (n1>n2)
        Console.WriteLine($"El resultado de restarle {n2} a {n1} es: {n1-n2}.");
        else if (n2==n1) 
        Console.WriteLine($"El resultado de sumar {n1} y {n2} es: {n1+n2}.");
        else
        Console.WriteLine($"El producto de {n1} y {n2} es: {n1*n2}.");

        Console.WriteLine("Fin del programa.");*/
        
        /*char litros;
        float importeTotal;

        Console.Write("ingrese el importe total de la venta: ");
        importeTotal=float.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de  litros vendida: ");
        litros=char.Parse(Console.ReadLine());

        if(litros>500)
        Console.WriteLine($"el precio final es: {importeTotal*.75f} con 25%");
        else if(litros>300)
        Console.WriteLine($"El precio final es: {importeTotal*.85f} con 15%");
        else if (litros>100)
        Console.WriteLine($"El precio final es: {importeTotal*.90f} con 10%");
        else
        Console.WriteLine($"El precio final es: {importeTotal}");*/

        
        /*char procesador,ram,disco;
        int precio=0;

        Console.Write("ingrese el procesador deseado: ");
        procesador=char.Parse(Console.ReadLine());
        Console.Write("ingrese la ram: ");
        ram=char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese si extiende disco: ");
        disco=char.Parse(Console.ReadLine());

        switch (procesador)
        {
             case '1':
             switch (ram)
             {
                case '1':
                precio=800;
                break;
                case '2':
                precio=900;
                break;
                default:
                precio=1000;
                break;
             }
             break;

             case '2':
             switch (ram)
             {
                case '1':
                precio=900;
                break;
                case '2':
                precio=1000;
                break;
                default:
                precio=1400;
                break;
             }
             break;
             default:
             switch (ram)
             {
                case '1':
                precio=1200;
                break;
                case '2':
                precio=1400;
                break;
                default:
                precio=2000;
                break;
             }
             break;
        }

        if (disco==1)
        Console.WriteLine($"el precio final es: {precio+300}.");   
        else
        Console.WriteLine($"el precio final es: {precio}.");*/

        #pragma warning disable CS8604
        int n1,n2,n3,n4;
        Console.Write("ingrese un numero: ");
        n1=int.Parse(Console.ReadLine());
                Console.Write("ingrese un numero: ");
        n2=int.Parse(Console.ReadLine());
                Console.Write("ingrese un numero: ");
        n3=int.Parse(Console.ReadLine());
                Console.Write("ingrese un numero: ");
        n4=int.Parse(Console.ReadLine());
        // maxi lo resolvio asi : if(n1>n2 && n2>n3 && n3>n4)
        if ((n1>n2 && n1>n3 && n1>n4) && (n2>n3 && n2>n4) && (n3>n4))
        Console.WriteLine("esta ordenado");
        else
        Console.WriteLine("no esta ordenado de manera decreciente.");
    }
}
