using System;
namespace CRUDc
{
    public class GajikaryawanTetap : Gajikaryawan
    {
        public override string Jenis { get; set; }
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double Gajibulanan { get; set; }
        public override double Gaji() => Gajibulanan;

    }
}
