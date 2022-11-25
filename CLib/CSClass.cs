using XSharp;
using GreetLib;


namespace Test
{ 
    public static partial class CSClass
    {
        public static __Array Test_CS()
        {
            __Array testArr = XSharp.RT.Functions.ArrayNew(1, 2);

            // uncomment to load in the DLL
            //string testResult = GreetLib.Functions.Test();

            testArr[0, 0] = "Codeblock";
            testArr[0, 1] = XSharp.RT.Functions.MCompile("{| name | Greetings(name) }");
            return testArr;
        }
    }
}
