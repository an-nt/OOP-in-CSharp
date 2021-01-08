using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class TamGiac
    {
        public Diem DinhA;
        public Diem DinhB;
        public Diem DinhC;

        public void NhapTamGiac(string ThongBaoNhap)
        {
            this.DinhA = new Diem();
            this.DinhB = new Diem();
            this.DinhC = new Diem();

            Console.WriteLine(ThongBaoNhap);

            this.DinhA.NhapDiem("Nhap dinh thu nhat");
            this.DinhB.NhapDiem("Nhap dinh thu hai");
            this.DinhC.NhapDiem("Nhap dinh thu ba");
        }
        public double TinhChuVi()
        {
            return DinhA.TinhKhoangCanhDen(DinhB) + DinhB.TinhKhoangCanhDen(DinhC) + DinhC.TinhKhoangCanhDen(DinhA);
        }
        public double TinhDienTich()
        {
            double c = this.DinhA.TinhKhoangCanhDen(this.DinhB);
            double a = this.DinhB.TinhKhoangCanhDen(this.DinhC);
            double b = this.DinhC.TinhKhoangCanhDen(this.DinhA);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
