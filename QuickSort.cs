using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSort
    {
        public static void Sortuj(int[] tab, int lewy, int prawy)
        {
            int i = lewy, j = prawy;
            int x, tmp;
            x = tab[(lewy + prawy) / 2];
            while (i <= j)
            {
                while (tab[i] < x)
                {
                    i++;
                }
                while (x < tab[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    tmp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = tmp;
                    i++; j--;
                }
            }
            if (lewy < j) Sortuj(tab, lewy, j);
            if (i < prawy) Sortuj(tab, i, prawy);
        }

        
        public static void StartSort(int[] tab)
        {
            Sortuj(tab, 0, tab.Length - 1);
        }
    }
}
