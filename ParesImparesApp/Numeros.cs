using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImparesApp
{
    class Numeros
    {
        private int inicio, fim;
        public Numeros(int i, int f)
        {
            if (i > 0) inicio = i;
            if (f > i) fim = f;
        }
        public int[] Calcular(bool p, bool i)
        {
            int[] vetor = new int[fim - inicio];
            int cont2 = inicio;
            int cont = 0;
            if (p == true && i == true)
            {
                while (cont <= fim - inicio)
                {
                    vetor[cont] = cont2;
                    cont++;
                    cont2++;
                }
            }
            else if (p == true && i == false)
            {
                while (cont <= fim - inicio)
                {
                    if (cont2 % 2 == 0) vetor[cont] = cont2;
                    cont++;
                    cont2++;
                }
            }
            else if (p == false && i == true)
            {
                while (cont <= fim - inicio)
                {
                    if (cont2 % 2 != 0) vetor[cont] = cont2;
                    cont++;
                    cont2++;
                }
            }
            return vetor;
        }
    }
}
