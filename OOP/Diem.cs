using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Diem
    {
        private int _X;
        private int _Y;
        public int X
        {
            get
            {
                return this._X;
            }
            set
            {
                this._X = value;
            }
        }
        public int Y
        {
            get
            {
                return this._Y;
            }
            set
            {
                this._Y = value;
            }
        }
        public Diem()
        {
            this._X = 0;
            this._Y = 0;
        }
        public Diem(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }
        public void NhapDiem(string ThongBaoNhap)
        {
            Console.WriteLine(ThongBaoNhap);

            Console.WriteLine("Nhap X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Y:");
            int y = int.Parse(Console.ReadLine());
            
            this._X = x;
            this._Y = y;
        }
        public double TinhKhoangCanhDen(Diem diem)
        {
            return Math.Sqrt((this._X - diem._X) * (this._X - diem._X) + (this._Y - diem._Y) * (this._Y - diem._Y));
        }
    }
}
