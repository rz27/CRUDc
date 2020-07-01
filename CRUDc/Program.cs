using System;
using System.Collections.Generic;

namespace CRUDc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gajikaryawan> gajikaryawans = new List<Gajikaryawan>();

            int Pilihan,PilihanJ;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Aplikasi");
                Console.WriteLine("");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("");
                Console.Write("Pilih menu 1...4 : ");
                Pilihan = int.Parse(Console.ReadLine());

             if (Pilihan == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Tambah Data Karyawan");
                        Console.WriteLine("");
                        Console.Write("Pilih Karyawan 1. Karyawan Tetap, " +
                            " 2. Karyawan Harian, " +
                            " 3.Sales : ");
                        PilihanJ = int.Parse(Console.ReadLine());

                        if (PilihanJ >= 4)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" Maaf pilihan anda tidak tersedia ");
                            Console.WriteLine("");
                            Console.WriteLine(" Tekan ENTER untuk mengulang ");
                            Console.ReadKey(true);
                        }
                    } while (PilihanJ >= 4);

                    if (PilihanJ == 1 )
                    {
                        Console.WriteLine("");
                        string jenis = " Karyawan Tetap";
                        Console.Write(" Nik : ");
                        string nik = Console.ReadLine();
                        Console.Write(" Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write(" Gaji Bulanan : ");
                        double gajiB = Double.Parse(Console.ReadLine());

                        gajikaryawans.Add(new GajikaryawanTetap { Nik = nik , Nama = nama , Gajibulanan = gajiB , Jenis = jenis});
                    }
                    else if (PilihanJ == 2)
                    {
                        Console.WriteLine("");
                        string jenis = " Karyawan Harian";
                        Console.Write(" Nik : ");
                        string nik = Console.ReadLine();
                        Console.Write(" Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write(" Jumlah Jam Kerja : ");
                        double JamK = Double.Parse(Console.ReadLine());
                        Console.Write(" Upah Per Jam : ");
                        double UpahP = Double.Parse(Console.ReadLine());

                        gajikaryawans.Add(new Gajikaryawanharian { Nik = nik, Nama = nama, Jamkerja = JamK, UpahPerjam = UpahP , Jenis = jenis });
                    }
                    else if (PilihanJ == 3)
                    {
                        Console.WriteLine("");
                        string jenis = "Sales";
                        Console.Write(" Nik : ");
                        string nik = Console.ReadLine();
                        Console.Write(" Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write(" Jumlah Penjualan : ");
                        double Jumlahp = Double.Parse(Console.ReadLine());
                        Console.Write(" Komisi : ");
                        double Komisi = Double.Parse(Console.ReadLine());

                        gajikaryawans.Add(new Sales { Nik = nik, Nama = nama, JmlhP = Jumlahp, Komisi = Komisi , Jenis = jenis });
                    }

                    Console.WriteLine("");
                    Console.WriteLine(" Tekan ENTER untuk kembali ke Menu");
                    Console.ReadKey(true);
                }
             else if (Pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine(" Hapus Data Karyawan");
                    Console.WriteLine("");
                    Console.Write(" Masukan Nik yang ingin dihapus : ");
                    string Delete = Console.ReadLine();
                    int H = 0;
                    bool Data = false;

                    foreach (Gajikaryawan gajikaryawan in gajikaryawans)
                    {
                        if (Delete == gajikaryawan.Nik)
                        {
                            gajikaryawans.RemoveAt(H);
                            Data = true;
                            break;
                        }
                        H++;
                    }
                    if (Data == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Maaf data tidak ditemukan");
                    }

                    Console.WriteLine("");
                    Console.WriteLine(" Tekan ENTER untuk kembali ke Menu");
                    Console.ReadKey(true);
                }
             else if (Pilihan == 3)
                {
                    Console.Clear();
                    Console.WriteLine(" Menampilkan data Karyawan ");
                    Console.WriteLine("");
                    int No = 1;
                    bool Data = false;
                    foreach (Gajikaryawan gajikaryawan in gajikaryawans)
                    {
                        Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : Rp.{3 : 0} ,{4}",
                        No, gajikaryawan.Nik, gajikaryawan.Nama, gajikaryawan.Gaji() , gajikaryawan.Jenis);
                        Data = true;
                        No++;
                    }
                    if (Data == false)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(" Maaf data Kosong ");
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine(" Tekan ENTER untuk kembali ke Menu ");
                    Console.ReadKey(true);
                }
                else if (Pilihan == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Terima Kasih Bosku");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(" Maaf pilihan anda tidak tersedia ");
                    Console.WriteLine("");
                    Console.WriteLine(" Tekan ENTER untuk memilih ulang ");
                    Console.ReadKey(true);
                }
            } while (Pilihan != 4);
        }
    }
}
