
FUNCTION Start() AS VOID STRICT

LOCAL cDoesExist := "Variable Exists" AS STRING
LOCAL directCB := { | obj | cDoesExist } AS CODEBLOCK
LOCAL cbStr := "{| obj | cDoesExist }" AS STRING

// Uncomment to make compiledCB Work
//XSharp.RT.Functions.MemVarPut("cDoesExist", cDoesExist)

LOCAL compiledCB := MCompile(cbStr) AS CODEBLOCK

Console.WriteLine(Eval(directCB))
Console.WriteLine("Next Codeblock")
Console.WriteLine(Eval(compiledCB))

Console.WriteLine("Press any key to continue...")
Console.ReadKey()
