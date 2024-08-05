using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADV_03
{
   // public delegate bool CompareFuncDelegte<T>(T A, T B);
    internal class SortingAlgorithms<T>
    {

        #region Non Generic
        //public static void BubbleSort(int[] array, CompareFuncDelegte compareFunc)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //                //if (array[j] > array[j + 1])
        //                //if (CompareFunctions.ComapreGrt(array[j] , array[j+1]))
        //                // if (compareFunc.Invoke(array[j] , array[j+1]))  
        //                if (compareFunc(array[j], array[j + 1])) //Syntax Suger
        //                    SWAP(ref array[j], ref array[j + 1]);
        //        }
        //    }
        //}
        #endregion

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


        public static void BubbleSort(T[] array, Func<T , T , bool> compareFunc)
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

        private static void SWAP(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;

        }
    }
}
