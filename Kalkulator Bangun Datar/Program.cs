using System;

namespace Activity_8
{

    public class Persegi
    {
        //deklarasi variabel global
        public double sisi;
        //Membuat method berupa prosedur untuk input variabel yang diketahui
        public void sisiP()
        {
            Console.Write("Masukkan Panjang Sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk luas dan keliling
        public double LuasP(double sisi)
        {
            return sisi * sisi;
        }
        public double KelilingP()
        {
            return 4 * sisi;
        }
        //Membuat method berupa prosedur untuk menampilkan data luas dan keliling
        public void tampilP()
        {
            Console.WriteLine("Luas Persegi adalah = " + this.LuasP(sisi));
            Console.WriteLine("Keliling Persegi adalah = " + this.KelilingP());
            Console.ReadKey();
        }
    }


    public class PersegiPanjang
    {
        //deklarasi variabel global
        public double panjang, lebar;
        //membuat method berupa fungsi untuk menghitung luas dan keliling
        public void sisiPP()
        {
            Console.Write("Masukkan Panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung luas 
        public double LuasPP(double p, double l)
        {
            return p * l;
        }
        public double KelilingPP()
        {
            return 2 * (panjang + lebar);
        }
        //Membuat method berupa prosedur untuk menampilkan data luas dan keliling
        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi Panjang adalah = " + this.LuasPP(panjang, lebar));
            Console.WriteLine("Keliling Persegi Panjang adalah = " + this.KelilingPP());
            Console.ReadKey();
        }
    }

    public class Segitiga
    {
        public double alas, tinggi, sisi1, sisi2, sisi3;
        public void sisis3()
        {
            Console.Write("Masukkan alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Panjang Sisi1 = ");
            sisi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Panjang Sisi2 = ");
            sisi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Panjang Sisi3 = ");
            sisi3 = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }
        public double KelilingS3()
        {
            return sisi1 + sisi2 + sisi3;
        }
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.WriteLine("Keliling Segitiga = " + this.KelilingS3());
            Console.ReadKey();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============KALKULATOR PENGHITUNG KELILING DAN LUAS BANGUN DATAR===============");
            Console.WriteLine();
            //Membuat instance untuk class Persegi, class PersegiPanjang, dan class Segitiga
            Persegi p = new Persegi();
            PersegiPanjang pp = new PersegiPanjang();
            Segitiga S3 = new Segitiga();

            //deklarasi variable untuk ekpresi Switch
            int pilih;
            //membuat tampilan menu 
            Console.WriteLine("MENU");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (pilih)
            {
                case 1:
                    p.sisiP();
                    p.KelilingP();
                    p.tampilP();
                    break;
                case 2:
                    pp.sisiPP();
                    pp.KelilingPP();
                    pp.tampilPP();
                    break;
                case 3:
                    S3.sisis3();
                    S3.KelilingS3();
                    S3.tampilS3();
                    break;
            }

        }
    }
}