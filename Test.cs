using System;

namespace Ödev2
{
    public static class Test
    {

        public static int sayac = 0;     // şifre toplam sayısı 
        public static int sayac1 = 0;    // büyük harf için
        public static int sayac2 = 0;    // küçük harf için
        public static int sayac3 = 0;    // sayı için
        public static int sayac4 = 0;    // sembol için

        public static int bykhrf(string karakterler)          // şifredeki büyük harfleri bulmak için kullanılan fonksiyon
        {
            foreach (char karakter in karakterler)           // dizinin tamamını okusun diye foreach döngüsü kullanılır 
            {
                if (char.IsUpper(karakter))                  //  büyük harf var mı diye kontrol ediliyor.
                {
                    sayac++;
                    sayac1++;
                }
            }
            return sayac1;
        }


        public static int kckhrf(string karakterler)          // şifredeki küçük harfleri bulmak için kullanılan fonksiyon
        {
            foreach (char karakter in karakterler)           // dizinin tamamını okusun diye foreach döngüsü kullanılır
            {
                if (char.IsLower(karakter))                 //  küçük harf var mı diye kontrol ediliyor.
                {
                    sayac++;
                    sayac2++;
                }
            }
            return sayac2;
        }


        public static int sayi(string karakterler)            // şifredeki sayıları bulmak için kullanılan fonksiyon
        {
            foreach (char karakter in karakterler)            // dizinin tamamını okusun diye foreach döngüsü kullanılır
            {
                if (char.IsNumber(karakter))                 //  sayı var mı diye kontrol ediliyor.
                {
                    sayac++;
                    sayac3++;
                }
            }
            return sayac3;
        }


        public static int symbol(string karakterler)            // şifredeki sembolleri bulmak için kullanılan fonksiyon
        {
            foreach (char karakter in karakterler)              // dizinin tamamını okusun diye foreach döngüsü kullanılır
            {
                if (!(char.IsLetterOrDigit(karakter)))                    //  sembol var mı diye kontrol ediliyor. Sayı ve Harf değilse Semboldür tanımı yapılır.
                {
                    sayac++;
                    sayac4++;
                }
            }
            return sayac4;
        }


        public static void sayma(string karakterler)           // sayaç değişkenlerimizi ekrana bastırmak için yazılan fonksiyon
        {
            Console.WriteLine("Şifredeki Toplam Adet:" + sayac);
            Console.WriteLine("Büyük Harf Adedi:" + sayac1);
            Console.WriteLine("Küçük Harf Adedi:" + sayac2);
            Console.WriteLine("Sayı Adedi:" + sayac3);
            Console.WriteLine("Sembol Adedi:" + sayac4);
        }
    }
}
