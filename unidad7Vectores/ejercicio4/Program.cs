namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        #pragma warning disable CS8604
        
        string cadena;
        char cambiar,buscar;
        System.Console.WriteLine("ingrese su palabra o frase: ");
        cadena= Console.ReadLine();
        System.Console.Write("ingrese el caracater que desea reemplazar: ");
        buscar=char.Parse(Console.ReadLine());
        System.Console.Write("ingrese el caracter por el que lo quiera reemplazar: ");
        cambiar=char.Parse(Console.ReadLine());

       cadena= cadena.Replace(buscar,cambiar);

        System.Console.WriteLine($"palabra o frase modificada: {cadena}");

        /*char [] palabra=new char [31];
        int indice=0;
        char letra;
        char buscar, cambiar;

        Console.WriteLine("ingrese su palabra letra por letra: ");
        letra=char.Parse(Console.ReadLine());

         while (indice<30 && letra!='.')
         {
            palabra[indice]=letra;
            letra=char.Parse(Console.ReadLine());
            indice++;
         }

        System.Console.Write("\n\ningrese el caracater que desea reemplazar: ");
        buscar=char.Parse(Console.ReadLine());
        System.Console.Write("ingrese el caracter por el que lo quiera reemplazar: ");
        cambiar=char.Parse(Console.ReadLine());

         palabra[indice]='\0';
        indice=0;
         while (palabra[indice]!= '\0')
         {
            if (palabra[indice]==buscar){
                palabra[indice]=cambiar;
            }
            indice++;
         }
        indice=0;
         Console.Write($"\n\npalabra o frase modificada: ");

         while (palabra[indice] != '\0')
         {
            Console.Write(palabra[indice]);
            indice++;
         }*/
    }
}
