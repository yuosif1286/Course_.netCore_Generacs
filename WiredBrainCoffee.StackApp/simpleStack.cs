// See https://aka.ms/new-console-template for more information

public class simpleStack <T>
{
    private readonly T[] _item;
    private int CurrentIndex = -1;

    public simpleStack() => _item = new T[10];

    public void Push(T item) => _item[++CurrentIndex] = item;

    public T Pop() => _item[CurrentIndex--];

    public int Count => CurrentIndex + 1;

}