FUNCTION Test_XS() AS ARRAY

LOCAl aTest AS ARRAY

aTest := ArrayNew(1,2)

aTest[1,1] := "Codeblock"
aTest[1,2] := {| name | Greetings(name) }

RETURN aTest