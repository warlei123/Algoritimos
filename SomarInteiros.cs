namespace Algoritimos
{
    using System;
    using System.Collections.Generic;
    public class Somar
    {
        public void SomarInteiros(List<int> intA, List<int> intB, List<int> Resultado)
        {
            int indice = 0;
            while (intA.Count != indice && intB.Count != indice)
            {
                if (intB.Count < intA.Count)
                {
                    foreach (var item in intB)
                    {
                        Resultado.Add(intA[indice] + intB[indice]);
                        indice++;
                    }
                    for (int i = indice; i < intA.Count; i++)
                    {
                       Resultado.Add(intA[i]); 
                    }
                    
                }
                else if (intB.Count > intA.Count)
                {
                    foreach (var item in intA)
                    {
                        Resultado.Add(intA[indice] + intB[indice]);
                        indice++;
                    }
                    for (int i = indice; i < intB.Count; i++)
                    {
                       Resultado.Add(intB[i]); 
                    }
                }
                else
                {
                    Resultado.Add(intA[indice] + intB[indice]);
                    indice++;
                }
            }
        }
    }
}