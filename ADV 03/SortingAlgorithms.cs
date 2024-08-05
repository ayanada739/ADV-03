using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADV_03
{
    public delegate bool CompareFuncDelegte(int A, int B);
    internal class SortingAlgorithms
    {

        public static void BubbleSort(int[] array , CompareFuncDelegte compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                        //if (array[j] > array[j + 1])
                        //if (CompareFunctions.ComapreGrt(array[j] , array[j+1]))
                        // if (compareFunc.Invoke(array[j] , array[j+1]))  
                        if (compareFunc(array[j], array[j + 1])) //Syntax Suger
                            SWAP(ref array[j], ref array[j + 1]);
                }
            }
        }

        //public static void BubbleSortDesc(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //                if (array[j] < array[j + 1])
        //                    SWAP(ref array[j], ref array[j + 1]);
        //        }
        //    }
        //}



        private static void SWAP(ref int v1, ref int v2)
        {
            int Temp = v1;
            v1 = v2;
            v2 = Temp;

        }
    }
}
