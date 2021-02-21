using System;
using System.Collections.Generic;
using System.Text;

namespace KampMetodlar
{
    class SepetManager
    {
        //naming convetion
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) //ENCAPSULATION =PARAMETREYİ BİR CLASSLA GÖNDERMEK İŞLEMİ direk ürünü göndermek gerekir bu şekilde her seferinde tekrar veri girmek ve eğer yeni bir parametre
            //eklenmesi gerekirse fonksiyonun kullanıldığı her yerde tekrar parametre değerleri eklemek gerekir.
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
