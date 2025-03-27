using System;
using SFMLResim;

namespace SA2025
{
    static class Oyun
    {
        static private int bgResim;

        static private Oyuncu o;

        static Oyun()
        {
            bgResim = Resim.Ekle("Res\\bg.png");
            o = new Oyuncu(25);
        }

        static public void YeniOyun()
        {
            o = new Oyuncu(25);

            Gemiler.Ekle(20);
        }

        static public void Hesapla(float t)
        {
            Gemiler.Hesapla(t);
        }

        static public void Ciz()
        {
            Resim.Ciz(bgResim, 0, 0, 800, 600);

            Gemiler.Ciz();

            o.Ciz();
        }

        static public void FareKontrol()
        {
            o.FareKontrol();
        }


    }
}
