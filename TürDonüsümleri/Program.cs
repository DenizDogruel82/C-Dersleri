using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürDonüsümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("1.Sayiyi Giriniz: ");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            // Console.Write("2.Sayiyi Giriniz: ");
            // int sayi1=Convert.ToInt32(Console.ReadLine());
            // int toplam = sayi1 + sayi;
            // Console.WriteLine($"Toplam:{toplam}");
            //double sinav1,sinav2,sinav3,ort;
            // Console.Write("1.Sınav Giriniz: ");
            // sinav1=Convert.ToDouble(Console.ReadLine());
            // Console.Write("2.sınav Giriniz: ");
            // sinav2= Convert.ToDouble(Console.ReadLine());
            // Console.Write("3.Sınav Giriniz: ");
            // sinav3 = Convert.ToDouble(Console.ReadLine());
            // ort = (sinav1 + sinav2 + sinav3) / 3;
            // Console.WriteLine($"Ortalama:{ort}");
            Console.Write("Ürün adi Giriniz: ");
            string ürünadi=Console.ReadLine();
            Console.Write("Ürün fiyatı Giriniz: ");
            double urunfiyati = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ürün aciklama Giriniz: ");
            string urunaciklama = Console.ReadLine();
            Console.Write("Stok adet: ");
            int adet=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("******* Urun bilgileri *******");
            Console.WriteLine($"Urun adi:{ürünadi}");
            Console.WriteLine($"Urun aciklamasi:{urunaciklama}");
            Console.WriteLine($"Urun fiyat:{urunfiyati}");
            Console.WriteLine($"Urun adeti:{adet}");




            Console.Read();

        }
    }
}
