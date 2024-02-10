namespace Workaround
{

    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler/Arrays

            string ogrenci1 = "Yusuf";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yusuf";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";


            Console.ReadLine();
        }


        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Yusuf Ata";
            string soyad = "Çemrek";
            int dogumYili = 1998;
            long tcNo = 12345678901;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public int Ad { get; set; }
        public int Soyad { get; set;}
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
