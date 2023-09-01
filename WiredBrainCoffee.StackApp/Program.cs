
using WiredBrainCoffee.StackApp;



StackDouble();
StackString();

void StackString()
{
   var stack=new Stack<string>();

    stack.Push("first item");
    stack.Push("secound item");

    while (stack.Count>0)
    {
        Console.WriteLine($"item :{stack.Pop()}");
    }
}

Console.ReadLine();


 static void StackDouble()
{
    var stack = new SimpleStack<double>();

    stack.Push(1.2);
    stack.Push(2.2);
    stack.Push(4.0);

    double sum = 0.0;
    while (stack.Count > 0)
    {
        var item = stack.Pop();
        Console.WriteLine($"item index:{stack.Count} => Value:{item}");
        sum += item;
    }

    Console.WriteLine($"sum item in stack : {sum}");
}