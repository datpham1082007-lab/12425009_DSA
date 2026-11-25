using System;
using System.Collections.Generic;

class NhanVien
{
    public string MaNV;
    public string HoTen;
    public string GioiTinh;
    public string PhongBan;
    public double LuongCoBan;
}

class Bai2
{
    static void Main()
    {
        List< NhanVien > ds = new List< NhanVien >();

    Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            NhanVien nv = new NhanVien();

            Console.WriteLine("\nNhap nhan vien thu " + (i + 1));

            Console.Write("Ma NV: ");
            nv.MaNV = Console.ReadLine();

            Console.Write("Ho ten: ");
            nv.HoTen = Console.ReadLine();

            Console.Write("Gioi tinh: ");
            nv.GioiTinh = Console.ReadLine();

            Console.Write("Phong ban: ");
            nv.PhongBan = Console.ReadLine();

            Console.Write("Luong co ban: ");
            nv.LuongCoBan = double.Parse(Console.ReadLine());

            ds.Add(nv);
        }

        Console.WriteLine("\n===== DANH SACH NHAN VIEN =====");

        foreach (NhanVien nv in ds)
        {
            Console.WriteLine("Ma NV: " + nv.MaNV);
            Console.WriteLine("Ho ten: " + nv.HoTen);
            Console.WriteLine("Gioi tinh: " + nv.GioiTinh);
            Console.WriteLine("Phong ban: " + nv.PhongBan);
            Console.WriteLine("Luong co ban: " + nv.LuongCoBan);
            Console.WriteLine("-------------------------");
            // tính tổng lương nhân viên
            if (nv.GioiTinh.ToLower() == "nam")
            {
                Console.WriteLine("Tong luong nhan vien nam: " + nv.LuongCoBan);
            }
            else if (nv.GioiTinh.ToLower() == "nu")
            {
                Console.WriteLine("Tong luong nhan vien nu: " + nv.LuongCoBan);
            }
        }
    }

}
