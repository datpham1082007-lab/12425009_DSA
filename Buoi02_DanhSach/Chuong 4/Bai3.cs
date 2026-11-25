using System;

class Bai3
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Nhap n (0 < n < 199): ");
            n = int.Parse(Console.ReadLine());
        }
        while (n <= 0 || n >= 199);

        int[,] a = new int[n, n];

        Console.WriteLine("Nhap cac phan tu ma tran:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
            // tính tổng các phần tử
            if (i == 0)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("Tong cac phan tu tren dong " + i + " la: " + sum);
            }
            // tìm giá trị dương nhỏ nhất của ma trận
            if (i == 0)
            {
                int minPositive = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0 && a[i, j] < minPositive)
                    {
                        minPositive = a[i, j];
                    }
                }
                if (minPositive != int.MaxValue)
                {
                    Console.WriteLine("Gia tri duong nho nhat tren dong " + i + " la: " + minPositive);
                }
                else
                {
                    Console.WriteLine("Khong co gia tri duong tren dong " + i);
                }
            }
    
        }
    }
}