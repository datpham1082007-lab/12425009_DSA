using System;
class Bai1
{
    static void Main()
    {
        int n;

        Console.Write("Nhap so nguyen n: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("So nguyen vua nhap la: " + n);
         
        if (n > 0)
        {
            Console.WriteLine("Danh sach cac so nguyen tu 1 den " + n + ":");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Vui long nhap so nguyen duong.");
        }
        
        if (n > 0)
        {
            Console.Write("Nhap phan tu x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri k: ");
            int k = int.Parse(Console.ReadLine());
            if (k >= 1 && k <= n + 1)
            {
                Console.WriteLine("Danh sach sau khi chen phan tu x vao vi tri k:");
                for (int i = 1; i <= n + 1; i++)
                {
                    if (i == k)
                        Console.Write(x + " ");
                    else
                        Console.Write(i + " ");
                }
            }
            else
            {
                Console.WriteLine("Vi tri chen khong hop le.");
            }
        }
    }
}