using StackApp.Exceptions;

namespace StackApp.Model;
/// <summary>
/// Represents a stack data structure, which follows the Last In, First Out (LIFO) principle.
/// </summary>
public class CFStack
{
    /// <summary>
    /// 
    /// </summary>
    public int[] Stack { get; set; }
    public int Top { get; set; }
    public int Size { get; set; }

    public CFStack()
    {
        Size = 100;
        Top = -1;
        Stack = new int[100];
    }

    public CFStack(int size)
    {
        Size = size;
        Stack = new int[size];
        Top = -1;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool IsFull()
    {
        return Top == Size - 1;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return Top == -1;
    }

    /// <summary>
    /// Stack[++Top] = value; --> ++ is required , because is initialized in zero
    /// </summary>
    /// <param name="value"></param>
    /// <exception cref="StackIsFullException"></exception>
    public void Push(int value)
    {
        if (IsFull())
        {
            throw new StackIsFullException("Stack is full");
        } Stack[++Top] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new StackIsEmptyException("Stack is empty");
        }
        return Stack[Top--];
    }

    public void Traverse()
    {
        for (int i = 0; i < Top; i++)
        {
            Console.WriteLine(Stack[i] + " ");
        }
    }
}