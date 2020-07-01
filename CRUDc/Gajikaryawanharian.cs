using System;
namespace CRUDc
{
    public class Gajikaryawanharian : Gajikaryawan
    {
        public override string Jenis { get; set; }
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double Jamkerja { get; set; }
        public double UpahPerjam { get; set; }
        public override double Gaji() => Jamkerja * UpahPerjam;
    }
}
