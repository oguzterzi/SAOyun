using System;
using SFMLResim;

namespace SA2025
{
    static class Program
    {
        static void Main()
        {
            Resim.Yeni(800, 600, "Sistem Analizi 04");
            Resim.SetFPSLimit(60);

            Oyun.YeniOyun();

            while (Resim.Acik())
            {
                Resim.Baslat();

                Oyun.Hesapla(Resim.FrameTime);
                Oyun.FareKontrol();

                Oyun.Ciz();



                if (Resim.KlavyeBasili(Resim.Klavye.Escape))
                    Resim.Kapat();

                Resim.Bitir();
            }

        }
    }
}
