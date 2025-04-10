using System;
using System.Collections.Generic;
using SFMLResim;

namespace SA2025
{
    class Patlama
    {
        static List<int> resimler;
        float x, y, r, animNo;

        static Patlama()
        {
            resimler = new List<int>();
            for (int i = 0; i <= 15; i++)
                resimler.Add(Resim.Ekle("Res\\Patlama\\" + i + ".png"));
        }

        public Patlama(float x, float y, float r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            animNo = 0;
        }

        public void Hesapla(float t)
        {
            animNo += 20 * Resim.FrameTime;
        }

        public void Ciz()
        {
            if ((int)animNo < 16)
                Resim.Ciz(resimler[(int)animNo], x - r, y - r, 2 * r, 2 * r);
        }

        public bool Bitti()
        {
            return ((int)animNo > 15);
        }

    }
}
