using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            gerarArray gerar = new gerarArray();
            var indiceX = gerar.indiceAleatorio();

            int[] Array = new int[indiceX];
            
            
            gerar.gerarArrayUnicoSimples(Array, indiceX);

          
            

            Ordem ordenar = new Ordem();

            ordenar.OrdemCrescenteSimples(Array);
            
            Console.WriteLine();
            int indice = 0;
            foreach (var item in Array)
            {
                Console.Write($"[{Array[indice]}]" ) ; 
                indice++;              
            }
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(stopwatch.Elapsed);

            


        }
    }
}
