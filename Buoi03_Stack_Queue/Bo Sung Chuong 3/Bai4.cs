using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> lui = new Stack<string>();
        Stack<string> tien = new Stack<string>();

        string hienTai = "Google";

        while (true)
        {
            Console.WriteLine("\nTrang hien tai: " + hienTai);
            Console.WriteLine("1. Truy cap trang moi");
            Console.WriteLine("2. Quay lai");
            Console.WriteLine("3. Tien len");
            Console.WriteLine("0. Thoat");

            int chon = int.Parse(Console.ReadLine());

            if (chon == 1)
            {
                Console.Write("Nhap ten trang: ");
                lui.Push(hienTai);
                hienTai = Console.ReadLine();
                tien.Clear();
            }
            else if (chon == 2)
            {
                if (lui.Count > 0)
                {
                    tien.Push(hienTai);
                    hienTai = lui.Pop();
                }
                else
                    Console.WriteLine("Khong the quay lai!");
            }
            else if (chon == 3)
            {
                if (tien.Count > 0)
                {
                    lui.Push(hienTai);
                    hienTai = tien.Pop();
                }
                else
                    Console.WriteLine("Khong the tien len!");
            }
            else if (chon == 0)
                break;
        }
    }
}