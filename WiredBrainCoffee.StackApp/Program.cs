// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

var stack = new simpleStack<double>();

stack.Push(1.2);
stack.Push(2.2);
stack.Push(4.0);

double sum = 0.0;
while (stack.Count>0)
{
    sum += stack.Pop();
    Console.WriteLine($"item index:{stack.Count} => Value:{stack.Pop()}");
}

Console.WriteLine($"sum item in stack : {sum}");



Console.WriteLine("this for type int");
var stackInt = new simpleStack<int>();

stackInt.Push(1);
stackInt.Push(2);
stackInt.Push(4);

 sum = 0.0;
while (stackInt.Count > 0)
{
    sum += stackInt.Pop();
    Console.WriteLine($"item index:{stackInt.Count} => Value:{stackInt.Pop()}");
}

Console.WriteLine($"sum item in stack : {sum}");

Console.ReadLine();


