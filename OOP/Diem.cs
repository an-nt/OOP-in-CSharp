using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Diem
    {
        public int X;
        public int Y;

        public void NhapDiem(string ThongBaoNhap)
        {
            Console.WriteLine(ThongBaoNhap);

            Console.WriteLine("Nhap X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Y:");
            int y = int.Parse(Console.ReadLine());
            
            this.X = x;
            this.Y = y;
        }
        public double TinhKhoangCanhDen(Diem diem)
        {
            return Math.Sqrt((this.X - diem.X) * (this.X - diem.X) + (this.Y - diem.Y) * (this.Y - diem.Y));
        }
    }
}
