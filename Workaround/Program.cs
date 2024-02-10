using Business.Concrete;
using Entities.Concrete;

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

            int sonuc = Topla(6, 58);

            //Diziler/Arrays

            string ogrenci1 = "Yusuf";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yusuf";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Yusuf Ata";
            person1.LastName = "Cemrek";
            person1.DateOfBirthYear = 1998;
            person1.NationIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Engin";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "Istanbul 1", "Izmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> myList = new List<string> { "Elma", "Armut", "Uzum" };
            myList.Add(item: "Karpuz");
            foreach (var meyveler in myList)
            {  
                Console.WriteLine(meyveler); 
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


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
