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
        }

        static public void Hesapla(float t)
        {
            if (Gemiler.Say() < 20)
                Gemiler.Ekle(1);

            Gemiler.Hesapla(t, o);
            Patlamalar.Hesapla(t);
        }

        static public void Ciz()
        {
            Resim.Ciz(bgResim, 0, 0, 800, 600);

            Gemiler.Ciz();
            Patlamalar.Ciz();
            o.Ciz();

            Resim.YaziYaz(Patlamalar.Say().ToString(), 0, 0, 50);
        }

        static public void FareKontrol()
        {
            o.FareKontrol();
        }


    }
}
