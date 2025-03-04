byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
int b = 10; //Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
decimal d = 20.3m; //Convert this value into "string" type (assign into another string type of variable)
short a1 = a;
short b1 = (short)b;
double c1 = Convert.ToDouble(c);
string d1 = d.ToString();
Console.WriteLine(a1);
Console.WriteLine(b1);
Console.WriteLine(c1);
Console.WriteLine(d1);