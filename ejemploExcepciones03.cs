using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        uint b, c, a;
        int[] arreglo = { 1, 2, 3, 4 };
        a = 2;
        b = 2;

        try
        {
            c = a / b;
            Console.WriteLine($"{a} / {b} = {c}");
            Console.WriteLine($"{arreglo[5]}");
        }
        catch(DivideByZeroException e1)
        {
            Console.WriteLine("Vuestra merced ha tenido el infortunio de encontrar una división entre cero");
            Console.WriteLine(e1.Message);
        }
        catch(IndexOutOfRangeException e2)
        {
            Console.WriteLine("Parcero, me parece que esta intentando entrar a un valor no válido");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Excepción: {e.ToString()}");
        }
        finally
        {
            Console.WriteLine("Haiga sido como haiga sido");
        }
    }
}
