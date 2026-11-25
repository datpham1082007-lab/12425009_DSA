using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<char> st = new Stack<char>();

        Console.Write("Nhap bieu thuc: ");
        string s = Console.ReadLine();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
                st.Push(c);

            else if (c == ')' || c == ']' || c == '}')
            {
                if (st.Count == 0)
                {
                    Console.WriteLine("Sai");
                    return;
                }

                char x = st.Pop();

                if ((c == ')' && x != '(') ||
                    (c == ']' && x != '[') ||
                    (c == '}' && x != '{'))
                {
                    Console.WriteLine("Sai");
                    return;
                }
            }
        }

        if (st.Count == 0)
            Console.WriteLine("Bieu thuc dung");
        else
            Console.WriteLine("Bieu thuc sai");
    }
}