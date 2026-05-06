//

using System.Linq.Expressions;
using System.Runtime.CompilerServices;

int[] notas = new int[15];
int suma = 0;
double promedio = 0;

for (int i = 0; i < notas.Length; i++)
{
    try
    {
        
        Console.WriteLine($"ingrese la nota del estudiante(1 + 1): ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre 0 y 100.");
        }
        
        notas[i] = nota;
        suma += nota;

    {
    catch (FormatException)
    }
       Console.WriteLine("Entrada no valida.por favor, ingree un numero entero.");
       i--;// Decrementar para volver a pedir la nota del mismo estudiante
    }
    catch (ArgumentOutOfRangeException ex)
    {
         Console.WriteLine(Exception.Messsagen);
         i--; // Decrementar para volver a pedir la nota del mismo estudiante 
    }
    Catch (Exception ex)
    {
        Console.WriteLine($"ocurrio un error : {ex.Message}");
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
    }
    
}   
