// See https://aka.ms/new-console-template for more information

namespace WiredBrainCoffee.StackApp;

public class SimpleStack <T>
{
    private readonly T[] _item;
    private int _currentIndex = -1;

    public SimpleStack() => _item = new T[10];

    public void Push(T item) => _item[++_currentIndex] = item;

    public T Pop() => _item[_currentIndex--];

    public int Count => _currentIndex + 1;

}