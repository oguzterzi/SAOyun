using System;
using System.Collections.Generic;
using SFMLResim;

namespace SA2025
{
    class Gemi
    {
        static List<int> resimler;
        int tip;
        float x, y, r, a, vx, vy;

        static Random rnd = new Random();

        static Gemi()
        {
            resimler = new List<int>();
            for (int i = 0; i <= 9; i++)
                resimler.Add( Resim.Ekle("Res\\Gemi\\" + i + ".png") );
        }

        public Gemi()
        {
            tip = rnd.Next(0, 10);
            x = rnd.Next(1, 800);
            y = rnd.Next(-300, -50);
            r = rnd.Next(20, 50);
            a = 0;
            vx = rnd.Next(-100, 100);
            vy = rnd.Next(50, 150);
        }

        public void Hesapla(float t)
        {
            a += 90 * t;

            x += vx * t;
            if (x < 0)
                vx *= -1;
            if (x > 800)
                vx *= -1;

            y += vy * t;
            if (y > 700)
                y = rnd.Next(-300, -50);
        }

        public void Ciz()
        {
            if (tip == 0)
                Resim.Ciz(resimler[tip], x - r, y - r, 2 * r, 2 * r, a);
            else
                Resim.Ciz(resimler[tip], x - r, y - r, 2 * r, 2 * r);
        }

    }
}
