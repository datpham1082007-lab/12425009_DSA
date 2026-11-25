using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<char> st = new Stack<char>();

        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        foreach (char c in s)
        {
            if (c == '(')
                st.Push(c);

            else if (c == ')')
            {
                if (st.Count == 0)
                {
                    Console.WriteLine("Chuoi khong dung");
                    return;
                }

                st.Pop();
            }
        }

        if (st.Count == 0)
            Console.WriteLine("Chuoi dung");
        else
            Console.WriteLine("Chuoi khong dung");
    }
}