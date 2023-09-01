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
    Console.WriteLine($"item index:{stack.Count} => Value:{stack.Pop}");
}

Console.WriteLine($"sum item in stack : {sum}");



Console.WriteLine("this for type int");
var stackint = new simpleStack<int>();

stackint.Push(1);
stackint.Push(2);
stackint.Push(4);

 sum = 0.0;
while (stackint.Count > 0)
{
    sum += stackint.Pop();
    Console.WriteLine($"item index:{stackint.Count} => Value:{stackint.Pop}");
}

Console.WriteLine($"sum item in stack : {sum}");

Console.ReadLine();


