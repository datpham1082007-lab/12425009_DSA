using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> st = new Stack<string>();

        st.Push("Main");
        Console.WriteLine("Goi ham Main");

        st.Push("Ham A");
        Console.WriteLine("Goi ham A");

        st.Push("Ham B");
        Console.WriteLine("Goi ham B");

        Console.WriteLine("Ham B ket thuc");
        st.Pop();

        Console.WriteLine("Ham A ket thuc");
        st.Pop();

        Console.WriteLine("Main ket thuc");
        st.Pop();
    }
}