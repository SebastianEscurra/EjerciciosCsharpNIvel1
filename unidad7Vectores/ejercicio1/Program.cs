namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    { // vectores variables dimencionales
         #pragma warning disable CS8604
        
        // vector de char
        int tamaño;
        Console.WriteLine("ingrese el tamaño del la palabra a ingresar.");
        tamaño= int.Parse(Console.ReadLine()); //definimos el tamaño
        char [] nombre= new char [tamaño+1];// creamos el vector char

        Console.WriteLine("ingrese su nombre letra por letra: ");
        char letra;
        int indice =0;
        letra= char.Parse(Console.ReadLine()); //ingresamos la primer letra

        while (letra != '.' && indice< tamaño) // cargamos el vector
        {
            nombre[indice]=letra;
            indice++;
            letra=char.Parse(Console.ReadLine());
        }

        nombre[indice]='\0';
        indice=0;

System.Console.Write("\n\nhola ");
        while(nombre[indice] != '\0')//mostramos el vector
        {
            Console.Write(nombre[indice]);
            indice++;
        }

         
       
        
    }
}
