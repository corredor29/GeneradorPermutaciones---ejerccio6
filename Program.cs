using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {
        string Texto = "abc";
        List<string> Resultado = Permutaciones(Texto);
        Console.WriteLine("Permutaciones:");
        foreach (string p in Resultado)
        {
            Console.WriteLine(p);
        }        
    }
    static List<string> Permutaciones(string Texto)
    {
        List<string> Resultado = new List<string>();
        GenerarPermutaciones("", Texto, Resultado);
        return Resultado;
    }
    static void GenerarPermutaciones(string Prefijo, string Resto, List<string> Resultado)
    {
        if (Resto.Length == 0)
        {
            Resultado.Add(Prefijo);
            return;
        }

        for (int i = 0; i < Resto.Length; i++)
        {
            char Actual = Resto[i];
            string NuevoPrefijo = Prefijo + Actual;
            string NuevoResto = Resto.Substring(0, i) + Resto.Substring(i + 1);

            GenerarPermutaciones(NuevoPrefijo, NuevoResto, Resultado);
        }
    } 
}

