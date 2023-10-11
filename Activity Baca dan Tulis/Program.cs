using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Baca_dan_Tulis
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel untuk menyimpan kalimat
            string nim, nama, kelas;

            //deklarasi variabel untuk memberi nama file
            string namaFile;

            try
            {
                //menuliskan nama file
                Console.Write("Nama File : ");

                //membaca nama file dan disimpan di variabel namaFile
                namaFile = Console.ReadLine();

                //deklarasi string untuk menyimpan path di drive C pada folder mydocument
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive C
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"{namaFile}.txt"));

                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data di drive D
                //StreamWriter sw = new StreamWriter("D:\\" + namaFile + ".txt");

                //Menuliskan NIM
                Console.Write("NIM= ");

                //membaca input dari user dan disimpan pada variabel nim
                nim = Console.ReadLine();

                //Menuliskan nama
                Console.Write("Nama= ");

                //membaca input dari user dan disimpan pada variabel nama
                nama = Console.ReadLine();

                //Menuliskan kelas
                Console.Write("Kelas= ");

                //membaca input dari user dan disimpan pada variabel kelas
                kelas = Console.ReadLine();

                //Tulis nim tersebut kedalam file
                sw.WriteLine($"Nomor Induk Mahasiswa = {nim}");

                //Tulis nama tersebut kedalam file
                sw.WriteLine($"Nama Mahasiswa        = {nama}");

                //Tulis kelas tersebut kedalam file
                sw.WriteLine($"Kelas                 = {kelas}");

                //Tutup file nya
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
