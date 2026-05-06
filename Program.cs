 /*Leer un numero entero y mostrar todos sus antesores
 elevados al cubo*/

using Math = System.Math;
 int numero ;

 while (true)
{
    Console.Write("ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        breack;
    }
    else
    {
        Console.ForegroundColor= Console.Read;
        Console.WriteLine("Entrada no valida . por favor , ingrese un numero .");
        Console.ResetColor();
    }
}
Console.WriteLine("Los antecesores elevados al cubo son: ");
int contador = 1;
while (contador < numero)
{
    double cubo = Math.Pow(contador, 3);
    Console.WriteLine($"{contador} elevados al cubo = {cubo}");
    contador ++;
}

