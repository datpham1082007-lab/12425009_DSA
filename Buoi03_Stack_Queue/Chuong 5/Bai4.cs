using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> q = new Queue<string>();

        q.Enqueue("Tai lieu 1");
        q.Enqueue("Tai lieu 2");
        q.Enqueue("Tai lieu 3");

        while (q.Count > 0)
        {
            Console.WriteLine("Dang in: " + q.Dequeue());
        }

        Console.WriteLine("Da in xong!");
    }
}