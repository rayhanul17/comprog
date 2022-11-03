using Test;
var a = new A();
int? v = 10;
var objects = new List<object>() { 5, 'C', a, DateTime.Now, v };
foreach(var i in objects)
{
    Type t = i.GetType();
    Console.WriteLine($"{i} is type of {t} IsPrimitive:{IsPrimitiveType(t)}");
}

bool IsPrimitiveType(Type t)
{
    return t.IsPrimitive || t.Namespace == null || t.Namespace.Equals("System");
}