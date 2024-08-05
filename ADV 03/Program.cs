namespace ADV_03
{
    //Step 0 : Declare Delegate
    public delegate int StringFuncDelegate(string str);
    // New Class [Delegate]
    // Any Reference From This Delegate Can Refer TO
    // Function Or More [Pointer To Function)
    // This Function May be Static Function [Class Member Function]
    // This Function May be Non Static Function [Object Member Function]
    // But These Functions Must be with the Same Signature of The Delegate
    // Regardless Function Name & Access Modifier


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


        }
    }
}
