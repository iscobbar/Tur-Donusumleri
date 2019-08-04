using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Bilinçsiz Tür DÖnüşümü
            // Küçük TÜr Büyük TÜre Sorunsuz Otomatik olarak dönüşür.

            byte sayi1 = 234;
            int sayi2;

            // sayi1'in değerini sayi2'ye ata.
            sayi2 = sayi1;

            // float değeri double'a otomatik dönüştü.
            float sayi3 = 45.5F;
            double sayi4 = sayi3;

            // short değeri int'e otomatik dönüştü.
            short sayi5 = 345;
            int sayi6 = sayi5;


            // Kasıtlı Tür DÖnüşümü.

            // parantez içerisinde hedef tip belirtilir.

            // Casting
            int sayi7 = 257;
            byte sayi8 = (byte)sayi7;
            // Console.WriteLine(sayi8);

            double sayi9 = double.MaxValue;
            //string s = sayi9.ToString();
            float sayi10 = (float)sayi9;
            //Console.WriteLine(sayi9);



            // Ondalıklı kısım kayboldu.
            float sayi11 = 4.5F;
            int sayi12 = (int)sayi11;
            //Console.WriteLine(sayi12);







            //Convert Sınıfı ile Tür DÖnüşümü.

            double sayi13 = 456.5;
            string yazi1 = Convert.ToString(sayi13);





            // .GetType() değişkenin tipini getirir. CTS
            // Console.WriteLine(yazi1.GetType());

            string yazi2 = "5.5";
            double sayi14 = 0.0;

            try
            {
                sayi14 = Convert.ToDouble(yazi2);
            }
            catch (Exception)
            {
                Console.WriteLine("Çevirmede hata var.");
            }
            finally
            {
                Console.WriteLine("Try-Catch Bloğu Tamamlandı.");
            }

            Console.WriteLine(sayi14);
            Console.WriteLine(sayi14.GetType());





            // Karakterin ASCII tablosundaki sayı değerini yazdırır.
            char karakter1 = 'A';
            int sayi15 = Convert.ToInt32(karakter1);
            Console.WriteLine(sayi15);



            Console.Write("Adınızı Giriniz: ");
            string alınanMetin = Console.ReadLine();

            int yas = Convert.ToInt32(alınanMetin);


            Console.WriteLine("Kullanıcının Adı: " + alınanMetin);


            int sayi = 256;
            byte byteSayi;

            checked
            {
                //byteSayi = (byte)sayi;
                unchecked
                {
                    byteSayi = (byte)sayi;
                }
            }

            Console.WriteLine(byteSayi);




            // Boxing
            int kucukTur = 55;
            string masa = "Masa";
            object buyukTur = kucukTur; //Bilinçsiz tür dönüşümü

            buyukTur = (object)kucukTur; // Bilinçli tür döşümü



            // Unboxing

            int kucukTur2 = (int)buyukTur;

            float fSayi1 = 45.99F;
            object oSayi = fSayi1;
            float fSayi2 = (float)oSayi;
            Console.WriteLine(fSayi2);

            short sayi123 = 987;
            string str123 = sayi123.ToString();
            string str123 = "987";
            Console.WriteLine(str123);

            //string -> int dönşümü yapıldı.

            int str66 = Convert.ToInt32(str123);
            int str66 = int.Parse(str123);

            double dSayi = 56.5D;
            string strSayi = dSayi.ToString();

            // yada-->> string strSayi = Convert.ToString(dSayi);



            /* Klavyeden girilen 2 Sayının Toplamını EKrana Yazdıran Program.*/
            Console.Write("1. Sayıyı Giriniz: ");
            string s11Str = Console.ReadLine();
            Console.Write("2. Sayıyı Giriniz: ");
            string s22Str = Console.ReadLine();

            // Tür Dönüşümleri.
            int s1 = int.Parse(s11Str);
            int s2 = Convert.ToInt32(s22Str);

            Console.WriteLine("Girilen Sayıların Toplamı: " + (s1 + s2));

            // Klavyeden girilen 4 sayının ortalamasını
            // bulan programı yazınız.

            string s1Str, s2Str, s3Str, s4Str;
            int s1, s2, s3, s4, toplam;
            float ortalama;

            Console.Write("1. Sayıyı Giriniz: ");
            s1Str = Console.ReadLine();
            s1 = Convert.ToInt32(s1Str);

            Console.Write("2. Sayıyı Giriniz: ");
            s2Str = Console.ReadLine();
            s2 = Convert.ToInt32(s2Str);

            Console.Write("3. Sayıyı Giriniz: ");
            s3Str = Console.ReadLine();
            s3 = Convert.ToInt32(s3Str);

            Console.Write("4. Sayıyı Giriniz: ");
            s4Str = Console.ReadLine();
            s4 = Convert.ToInt32(s4Str);

            toplam = s1 + s2 + s3 + s4;
            ortalama = (float)toplam / 4;
            Console.WriteLine("Girilen Sayıların Toplamı: " + toplam + ", Ortalaması: " + ortalama);
            Console.WriteLine("Girilen Sayıların Toplamı: {0}, Ortalaması: {1}", toplam, ortalama);
            Console.WriteLine($"Girilen Sayıların Toplamı: {toplam}, Ortalaması: {ortalama}");




            Console.Read();

        }
    }
}