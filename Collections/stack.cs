using System.Collections.Generic;
class stk
{
    public void stackDemo()
    {
        Stack<string> country = new Stack<string>();
        country.Push("one");
        country.Push("two");
        country.Pop();
        Console.WriteLine("{0}", country.Peek());

    }
}