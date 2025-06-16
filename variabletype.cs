using System;
class variabletype
{
static int x;
static void Main()
{
Console. Clear();
Console.WriteLine("Field x value is: "+ x +" and it is type is :" + x.GetType());

int y =10;
Console.WriteLine("Variable y value is:" + y + "and its typeis:"+ y.GetType());

float f=3.14f;
 Console.WriteLine("Variable f value is :" + f +"and its type is:" +f.GetType());

double d=3.14;
 Console.WriteLine("Variable d value is :" + d +"and its type is:" +d.GetType());

decimal de=3.14m;
 Console.WriteLine("Variable de value is :" + de +"and its type is:" +de.GetType());

bool b=true;
 Console.WriteLine("Variable b value is :" + b +"and its type is:" +b.GetType());

Char ch='S';
 Console.WriteLine("Variable ch value is :" + ch +"and its type is:" +ch.GetType());


}
}