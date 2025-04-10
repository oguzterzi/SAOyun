using System;
using SFMLResim;

namespace SA2025
{
    class Oyuncu
    {
        private static int resim;
        public float x { get; private set; }
        public float y { get; private set; }
        public float r { get; private set; }

        static Oyuncu()
        {
            resim = Resim.Ekle("Res\\oyuncu.png");
        }

        public Oyuncu(float a)
        {
            x = 400;
            y = 300;
            r = a;
        }

        public void Hesapla(float t)
        {
        }

        public void Ciz()
        {
            Resim.Ciz(resim, x - r, y - r, 2 * r, 2 * r);
        }

        private void Git(float a, float b)
        {
            if (a < r)
                a = r;
            if (a > 800 - r)
                a = 800 - r;
            x = a;

            y = b < r ? r : (b > 600 - r ? 600 - r : b);
        }

        public void FareKontrol()
        {
            Git(Resim.FarePos.X, Resim.FarePos.Y);
        }

    }
}
