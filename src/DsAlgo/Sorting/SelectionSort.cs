using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.Sorting
{
    public static class SelectionSortExtension
    {
        public static void SelectionSort(this int[] array)
        {
            if(array == null) throw new ArgumentNullException("array");

            for(int i = 0; i < array.Length; i++)
            {
                var index_min = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[index_min])
                    {
                        index_min = j;
                    }
                }

                //Swap
                var temp = array[i];
                array[i] = array[index_min];
                array[index_min] = temp;
            }
        }
    }
}
