namespace Algoritimos
{
    using System;
    using System.Collections.Generic;
    public class gerarArray
    {
        Random indice = new Random();
        Random Vetores = new Random();

        public int indiceAleatorio()
        {
            int retornoIndice = indice.Next(10,10);
            return retornoIndice;
        }

        public void gerarArrayDuplo(List<int> intA, List<int> IntB)
        {
            var indiceSorteadoA = indice.Next(999, 1000);
            for (int i = 0; i < indiceSorteadoA; i++)
            {
                var vetorA = Vetores.Next(1, 99);
                intA.Add(vetorA);
            }

            var indiceSorteadoB = indice.Next(999, 1000);
            for (int i = 0; i < indiceSorteadoB; i++)
            {
                var vetorB = Vetores.Next(1, 99);
                IntB.Add(vetorB);
            }
        }
        public void gerarArrayUnico(List<int> intU)
        {
            var indiceSorteadoA = indice.Next(10, 10);
            for (int i = 0; i < indiceSorteadoA; i++)
            {
                var vetorA = Vetores.Next(1, 99);
                intU.Add(vetorA);
            }
        }
        public void gerarArrayUnicoSimples(int[] intU, int indiceSorteado)
        {
            
            for (int i = 0; i < indiceSorteado; i++)
            {
                var vetorA = Vetores.Next(1, 99);
                intU[i] = vetorA;
            }
        }
    }
}