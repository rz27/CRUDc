using System;
namespace CRUDc
{
    public abstract class Gajikaryawan
    {
        public abstract string Jenis { get; set; }
        public abstract string Nik { get; set; }
        public abstract string Nama { get; set; }
        public abstract double Gaji();
    }
}
