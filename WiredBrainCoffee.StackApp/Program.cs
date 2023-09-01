// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using WiredBrainCoffee.StackApp;

var stack = new SimpleStack<double>();

stack.Push(1.2);
stack.Push(2.2);
stack.Push(4.0);

double sum = 0.0;
while (stack.Count>0)
{
    var item= stack.Pop();
    Console.WriteLine($"item index:{stack.Count} => Value:{item}");
    sum += item;
}

Console.WriteLine($"sum item in stack : {sum}");



Console.WriteLine("this for type int");
var stackInt = new SimpleStack<int>();

stackInt.Push(1);
stackInt.Push(2);
stackInt.Push(4);

 sum = 0.0;
while (stackInt.Count > 0)
{
   var item= stackInt.Pop();
    Console.WriteLine($"item index:{stackInt.Count} => Value:{item}");
    sum += item;
}

Console.WriteLine($"sum item in stack : {sum}");

Console.ReadLine();


