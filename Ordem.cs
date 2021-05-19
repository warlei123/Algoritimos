namespace Algoritimos
{
   
    using System.Collections.Generic;
    public class Ordem
    {
        public void OrdemCrescente(List<int> Array)
        {


            for (int i = 0; i < Array.Count; i++)
            {
                var item = Array[i];
                var currentIndex = i;

                while (currentIndex > 0 && Array[currentIndex - 1] > item)
                {
                    Array[currentIndex] = Array[currentIndex - 1];
                    currentIndex--;
                }
                Array[currentIndex] = item;
            }
        }

         public void OrdemDecrescente(List<int> Array)
        {


            for (int i = 0; i < Array.Count; i++)
            {
                var item = Array[i];
                var currentIndex = i;

                while (currentIndex > 0 && Array[currentIndex - 1] > item)
                {
                    Array[currentIndex] = Array[currentIndex - 1];
                    currentIndex--;
                }
                Array[currentIndex] = item;
            }
        }
    }
}