namespace Algoritimos
{
    using System;
    using System.Collections.Generic;
    public class Pesquisa
    {
        public Pesquisa(List<int> Array)
        {
            Console.WriteLine();
            Console.WriteLine("Informe o valor");
            Console.WriteLine();
            var valor = Console.ReadLine();
            var valorProucurado = Convert.ToInt32(valor);

            if (!Array.Contains(valorProucurado))
            {
                Console.WriteLine("Esse valor não existe nessa lista");
            }

            for (int i = 0; i < Array.Count; i++)
            {
                if (Array[i] == valorProucurado)
                {
                    Console.WriteLine($"Valor {valorProucurado} encontrado na posicao {i}");
                }

            }
        }
    }
}