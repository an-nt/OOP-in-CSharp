using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DaGiac dagiac = new DaGiac();
            dagiac.NhapDaGiac("Nhap da giac");
            Console.WriteLine(dagiac.TinhChuVi());
        }
    }
}
