using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> q = new Queue<string>();

        q.Enqueue("Du lieu 1");
        q.Enqueue("Du lieu 2");
        q.Enqueue("Du lieu 3");

        while (q.Count > 0)
        {
            Console.WriteLine("Dang xu ly: " + q.Dequeue());
        }

        Console.WriteLine("Da xu ly xong!");
    }
}