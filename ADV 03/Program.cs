namespace ADV_03
{
    ///Step 0 : Declare Delegate
    ///public delegate int StringFuncDelegate(string str);
    /// New Class [Delegate]
    /// Any Reference From This Delegate Can Refer TO
    /// Function Or More [Pointer To Function)
    /// This Function May be Static Function [Class Member Function]
    /// This Function May be Non Static Function [Object Member Function]
    /// But These Functions Must be with the Same Signature of The Delegate
    /// Regardless Function Name & Access Modifier

    #region Built_in Delegate

    // 1. Predicate
    // Can Refer To Function That Take One Parameter {Of Any datatype)only and Must be Return bool

    //2. Func
    // Can Refer To Function That Can Take [0-16]] Parameter and Must be Return bool
    // Func<>

    //3. Action
    //  Can Refer To Function Take [0-16]] Parameter and Must be Void
    //

    #endregion


    internal class Program
    {

        static void Main(string[] args)
        {
            #region 07 Delegate
            //// Delegate is a C# Lanaguge Feature
            //// has 2 Usages
            //// 1. Pointer To Function
            //// 2. Event — Driven Programming

            //int X = 5;

            ////int Y =  StringFunctions.GetCountOfUpperChars; //Invalid

            ////Step 01 Declare Reference From Delegate
            //StringFuncDelegate stringFuncDelegate;

            ////Step 02 Intialize Reference From Delegate
            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.GetCountOfUpperChars);
            ////Syntax Suger
            //stringFuncDelegate = StringFunctions.GetCountOfUpperChars;

            ////Step 03 Use The Delegate Reference [Call Method ]
            //int Result =  stringFuncDelegate.Invoke("OmAr Alaa");
            //Console.WriteLine(Result);//3


            ////stringFuncDelegate = StringFunctions.GetCountOfLowerChars;
            ////stringFuncDelegate ==> GetCountOfLowerChars Only

            //stringFuncDelegate += StringFunctions.GetCountOfLowerChars;
            ////stringFuncDelegate ==> GetCountOfUpperChars + GetCountOfLowerChars

            // //Result = stringFuncDelegate.Invoke("OmAr Alaa");
            //// Console.WriteLine(Result);//5

            //stringFuncDelegate -= StringFunctions.GetCountOfLowerChars;
            ////stringFuncDelegate ==> GetCountOfUpperChars Only

            //Result = stringFuncDelegate.Invoke("OmAr Alaa");
            //Console.WriteLine(Result);//3

            #endregion

            #region Delegate EX 02
            //int[] numbers = { 10, 2, 3, 5, 15, 1, 8, 20 };
            //SortingAlgorithms.BubbleSort(numbers, CompareFunctions.ComapreGrt);

            //CompareFuncDelegte compareFunc = CompareFunctions.ComapreLess;

            //SortingAlgorithms.BubbleSort(numbers, compareFunc);
            //foreach (int Number in numbers)
            //    Console.WriteLine(Number); 
            #endregion

            #region Delegate Ex 02 Using Generics

            //string[] Names = { "Ahmed ", " Mona", "Amr ", "Aya" };

            //Func<string, string, bool> compareFunc = CompareFunctions.SortDescending;
            //SortingAlgorithms<string>.BubbleSort(Names, compareFunc);


            //foreach (string Name in Names)
            //    Console.WriteLine(Name);

            #endregion




        }
    }
}
