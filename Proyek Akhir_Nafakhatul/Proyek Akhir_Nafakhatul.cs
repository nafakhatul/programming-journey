using System;
namespace Proyek_Akhir_Nafakhatul
{ 
    internal class Program
    {
        // Deklarasi array global untuk menyimpan nama siswa
        static string[] namaSiswa;
        // Array untuk menyimpan status kehadiran (H, I, S, A)
        static char[] keteranganKehadiran;

        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("       DAFTAR HADIR SISWA      ");
            Console.WriteLine("================================");

            //Input jumlah siswa
            Console.Write("Masukkan jumlah siswa: ");
            int jumlahSiswa = Convert.ToInt32(Console.ReadLine());

            //Inisialisasi array sesuai jumlah
            namaSiswa = new string[jumlahSiswa];
            keteranganKehadiran = new char[jumlahSiswa];
            //Input nama siswa 
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.Write($"Masukkan nama siswa ke-{i + 1}: ");
                namaSiswa[i] = Console.ReadLine();
            }
            // Memanggil method untuk proses input data
            InputDataKehadiran();
            Console.Clear();
            Console.WriteLine("\n================================");
            Console.WriteLine("   REKAP KEHADIRAN SISWA     ");
            Console.WriteLine("================================");

            // Memanggil method untuk menampilkan hasil rekap
            TampilkanRekap();
        }
        // Method untuk mengelola input data kehadiran
        static void InputDataKehadiran()
        {
            // Perulangan 'for' untuk mengiterasi  siswa  
            for (int i = 0; i < namaSiswa.Length; i++)
            {
                Console.WriteLine($"\nInput kehadiran untuk siswa: {namaSiswa[i]}");
                Console.WriteLine("Pilih keterangan:");
                Console.WriteLine("1. Hadir");
                Console.WriteLine("2. Izin");
                Console.WriteLine("3. Sakit");
                Console.WriteLine("4. Alfa");
                Console.Write("Masukkan pilihan (1-4): ");

                // Input dari user (Input/Output)
                string inputPilihan = Console.ReadLine();
                // Konversi string ke integer (Variabel & Tipe Data)
                int pilihan = Convert.ToInt32(inputPilihan);

                // Percabangan 'switch' untuk menentukan status
                switch (pilihan)
                {
                    case 1:
                        keteranganKehadiran[i] = 'H'; // Hadir
                          break;
                    case 2:
                        keteranganKehadiran[i] = 'I'; // Izin
                        break;
                    case 3:
                        keteranganKehadiran[i] = 'S'; // Sakit
                        break;
                    case 4:
                        keteranganKehadiran[i] = 'A'; // Alfa
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Dianggap Alfa.");
                        keteranganKehadiran[i] = 'A';
                        break;
                }
            }
        }
        // Method untuk menampilkan rekapitulasi kehadiran
        static void TampilkanRekap()
        {
            Console.WriteLine("| No | Nama Siswa | Keterangan |");
            Console.WriteLine("--------------------------------");

            // Perulangan 'for' untuk menampilkan data
            for (int i = 0; i < namaSiswa.Length; i++)
            {
                // Penggunaan operator '+' untuk menggabungkan string (Operator)
                Console.WriteLine($"| {i + 1}  | {namaSiswa[i].PadRight(10)} | {keteranganKehadiran[i].ToString().PadRight(6)}     |");
            }
            Console.WriteLine("--------------------------------");
        }
    }
}