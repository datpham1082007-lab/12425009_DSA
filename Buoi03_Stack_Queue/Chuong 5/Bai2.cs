using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> back = new Stack<string>();
        Stack<string> forward = new Stack<string>();

        string hienTai = "Google";

        back.Push(hienTai);

        while (true)
        {
            Console.WriteLine("\nTrang hien tai: " + hienTai);
            Console.WriteLine("1. Truy cap trang moi");
            Console.WriteLine("2. Quay lai");
            Console.WriteLine("3. Chuyen tiep");
            Console.WriteLine("0. Thoat");

            int chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                Console.Write("Nhap trang: ");
                back.Push(hienTai);
                hienTai = Console.ReadLine();
                forward.Clear();
            }
            else if (chon == 2 && back.Count > 0)
            {
                forward.Push(hienTai);
                hienTai = back.Pop();
            }
            else if (chon == 3 && forward.Count > 0)
            {
                back.Push(hienTai);
                hienTai = forward.Pop();
            }
            else if (chon == 0)
                break;
            else
                Console.WriteLine("Khong the thuc hien!");
        }
    }
}