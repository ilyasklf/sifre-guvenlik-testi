using System;
using System.Linq;

namespace Ödev2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int puan = 0;    // güçlü mü güçsüz mü diye baktığımız puan değeri
            bool boslukcontrol = true;   // boşluk var mı diye kontrol edilir.
            char[] karakterler;
            Console.Write("Lütfen Şifrenizi Giriniz..:");
            string girilensifre = Console.ReadLine();
            karakterler = girilensifre.ToArray();       // girilen şifreyi karakterler dizisine aktarılır
            
            
            Console.WriteLine();


            
            int sayac1 = Test.bykhrf(girilensifre);
            int sayac2 = Test.kckhrf(girilensifre);
            int sayac3 = Test.sayi(girilensifre);
            int sayac4 = Test.symbol(girilensifre);
            Console.WriteLine();

            Test.sayma(girilensifre);
            Console.WriteLine();

            for (int i = 0; i < girilensifre.Length; i++)       // dizinin tamamında boşluk var mı diye bakıyor
            {
                if (karakterler[i] == ' ')
                {
                    boslukcontrol = false;
                }

            }
            

            if (boslukcontrol == false)                      
            {
                Console.WriteLine("Şifreniz Boşluk içerdiği için geçersizdir. Lütfen Boşluk Kullanmayınız.");
            }
            else
            {
                if (sayac1 == 0 || sayac2 == 0 || sayac3 == 0 || sayac4 == 0)           // sayı sembol büyük harf ve küçük harf 0 olmasın diye if else kullanılıyor
                {
                    Console.Write("Bu Şifrede Sayı Sembol Büyük Harf Küçük Harften Birisi Eksik Olduğundan Kabul Edilemez...");
                }
                else
                {
                    if (girilensifre.Length < 9)                                       // şifre 9 dan büyük olması isteniyor
                    {
                        Console.WriteLine("Bu Şifre Gerekli Uzunlukta Olmadığı İçin Şifre Geçersizdir..");
                    }
                    else
                    {
                        if (girilensifre.Length == 9)
                        {
                            puan = 10;
                        }

                      
                        if (sayac1 == 1)
                        {
                            puan += 10;
                        }
                        else
                        {
                            puan += 20;

                        }
                     


                        if (sayac2 == 1)
                        {
                            puan += 10;
                        }
                        else
                        {
                            puan += 20;
                        }

                        

                        if (sayac3 == 1)
                        {
                            puan += 10;
                        }
                        else
                        {
                            puan += 20;
                        }

                       

                        if (sayac4 == 1)
                        {
                            puan += 10;
                        }
                        else if (sayac4 == 2)
                        {
                            puan += 20;
                        }
                        else if (sayac4 >= 3)
                        {
                            puan += 30;
                        }
                       

                        if (puan < 70)
                        {
                            Console.WriteLine("Şifre Kabul Edilemez...");
                        }
                        else if (puan < 90 && puan >= 70)
                        {
                            Console.WriteLine("Şifre Kabul Edilir...");
                        }
                        else if (puan >= 90 && puan <= 100)
                        {
                            Console.WriteLine("Şifreniz Kabul Edildi. Şifreniz:GÜÇLÜ");
                        }
                        else
                        {
                           
                        }



                        Console.WriteLine("Puanınız:"+ puan);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
