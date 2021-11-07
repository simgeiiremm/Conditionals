using System;

namespace Demos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.başla
            //2.kullanıcının adı sorulur
            //3.kullanıcıdan adının girilmesi istenir
            //4.kullanıcının yaşı sorulur
            //5.kullanıcıdan yaş girilmesi istenir
            //6.kullanıcının eğitim durumu sorulur
            //7.kullanıcının eğitim durumu girilmesi istenir
            //8.kullanıcının sağlık durumu sorulur
            //9.kullanıcının sağlık durumu girilmesi istenir
            //10.eğer yaşı 18 veya dah büyükse(yas >= 18) ve eğitim durumu lise ve üstü ise ve sağlık durumu renk körü değilse
            //10.1 kullanıcıya adı ile birlikte ehliyet alabileceği belirtilir
            //10.2 10.madde değilse
            //10.3 kullanıcıya adı ile birlikte ehliyet alamayacağı belirtilir
            //11.bitiş

            Console.Write("Kullanıcının adını giriniz:");
            string ad = Console.ReadLine();
            Console.Write("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eğitim durumu (ilkokul: i, ortaokul: o, lise: l, üniversite: ü) :");
            string egitim = Console.ReadLine();
            Console.Write("Renk körü müsün? (evet: e, hayır: h)");
            string renkKoruMu = Console.ReadLine();

            if (yas >= 18 && (egitim == "l" || egitim == "ü" ) && renkKoruMu == "h")
            {
                Console.WriteLine("Sayın" + ad + ", ehliyet alabilirsiniz.");
            }
            else // yas < 18 || (egitim != "l" && egitim != "ü" ) || renkKoruMu != "h")
            {
                Console.WriteLine("Sayın" + ad + ",  ehliyet alamazsınız.");
            }
            //if (yas >= 18)
            //{
            //    if (egitim == "l" || egitim == "ü")
            //    {
            //        if(renkKoruMu == "h")
            //        {
            //            Console.WriteLine("Sayın" + ad + ", ehliyet alabilirsiniz.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sayın" + ad + " Renk körlüğünden dolayı ehliyet alamazsınız.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayın" + ad + ",İlkokul veya ortaokul mezunu olduğunuz için ehliyet alamazsınız.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayın" + ad + ", Yaşınızdan dolayı ehliyet alamazsınız.");
            //}
            //Console.ReadLine();





        }
    }
}
