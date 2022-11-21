// See https://aka.ms/new-console-template for more information
using Ref_parameterType_Example;

Console.WriteLine("Hello, World!");
RefType obj = new RefType();
int a = 10;
int b= 20;
Console.WriteLine("before swaping the  value of x :"+a);
Console.WriteLine("before swaping the value of y ;"+b);
obj.Swap(ref a, ref b);
Console.WriteLine("after swaping the  value of x :" + a);
Console.WriteLine("after  swaping the  value of y :" + b);
Console.WriteLine("________________________");
int addition = 0;
int multiplication;

obj.Opetarions(2, 3, ref addition, out multiplication);
Console.WriteLine("the value is :"+addition);
Console.WriteLine("the value is :"+multiplication);
