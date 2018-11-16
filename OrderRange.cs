using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OrderRange
{
    static void Main(string[] args)
    {
        Console.Write("Entrada: ");
        String cadena = Console.ReadLine();

        String[] strEnteros = cadena.Substring(1, cadena.Length - 2).Split(new string[] { ", " }, StringSplitOptions.None);
        int[] enteros = new int[strEnteros.Length];
        for (int i = 0; i < strEnteros.Length; i++)
            enteros[i] = int.Parse(strEnteros[i]);

        List<int> pares, impares;
        Build(enteros, out pares, out impares);

        Console.WriteLine("Salida: [" + EnterosAcadena(pares) + "] [" + EnterosAcadena(impares) + "]");
    }

    static void Build(int[] enteros, out List<int> pares, out List<int> impares)
    {
        Array.Sort(enteros);
        pares = new List<int>();
        impares = new List<int>();
        for (int i = 0; i < enteros.Length; i++)
        {
            if (enteros[i] % 2 == 0)
                pares.Add(enteros[i]);
            else
                impares.Add(enteros[i]);
        }
    }

    static String EnterosAcadena(List<int> enteros)
    {
        String resultado = "";
        for (int i = 0; i < enteros.Count(); i++)
        {
            resultado += enteros[i].ToString() + ", ";
        }
        if (resultado.Length > 0)
            resultado = resultado.Substring(0, resultado.Length - 2);
        return resultado;
    }
}
