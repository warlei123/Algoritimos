using System;
using System.Collections.Generic;
using System.Linq;

namespace Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> InteiroA = new List<int>(){11, 22, 33, 44, 55, 66};
            List<int> InteiroB = new List<int>(){10, 2, 30, 4, 50};

            List<int> Array = new List<int>();

            Somar somar = new Somar();
            somar.SomarInteiros(InteiroA, InteiroB, Array);

            Ordem ordenar = new Ordem();
            ordenar.OrdemCrescente(InteiroA);
            ordenar.OrdemDecrescente(InteiroB);

            ordenar.OrdemCrescente(Array);
            

            int indice = 0;
            foreach (var item in Array)
            {
                Console.Write($"[{Array[indice]}]" ) ; 
                indice++;              
            }

        }
    }
}
