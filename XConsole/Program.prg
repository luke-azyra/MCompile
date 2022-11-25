
FUNCTION Start() AS VOID STRICT
LOCAL aXArr AS ARRAY
LOCAL aCArr AS ARRAY

aXArr := Test_XS()
aCArr := Test.CSClass.Test_CS()
Console.WriteLine("Press any key to continue...")
Console.ReadKey()
