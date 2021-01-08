using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class DaGiac
    {
        public Diem[] DanhSachCacDinh;

        public void NhapDaGiac(string ThongBaoNhap)
        {
            Console.WriteLine(ThongBaoNhap);
            Console.WriteLine("Nhap so dinh cua da giac");
            int N = int.Parse(Console.ReadLine());
            this.DanhSachCacDinh = new Diem[N];
            for (int i = 0; i < this.DanhSachCacDinh.Length; i++)
            {
                this.DanhSachCacDinh[i] = new Diem();
                this.DanhSachCacDinh[i].NhapDiem($"Nhap toa do dinh thu {i+1}:");
            }
        }
        public double TinhChuVi()
        {
            double chuvi = 0;
            for (int i = 0; i < this.DanhSachCacDinh.Length-1; i++)
            {
                chuvi += this.DanhSachCacDinh[i].TinhKhoangCanhDen(this.DanhSachCacDinh[i + 1]);
            }
            chuvi += this.DanhSachCacDinh[this.DanhSachCacDinh.Length - 1].TinhKhoangCanhDen(this.DanhSachCacDinh[0]);
            return chuvi;
        }
    }
}
