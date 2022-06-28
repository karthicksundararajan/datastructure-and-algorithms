using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgo.Sorting
{
    public static class SortExtensions
    {
        public static void SelectionSort(this int[] array)
        {
            if (array == null) throw new ArgumentNullException("array");
            var arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var index_min = i;

                for (int j = i + 1; j < arrayLength; j++)
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

        public static void BubbleSort(this int[] array)
        {
            var arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //Swap
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(this int[] array)
        {
            var arrayLength = array.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    //shift
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
