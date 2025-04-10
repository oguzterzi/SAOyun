using System;
using System.Collections.Generic;

namespace SA2025
{
    class Patlamalar
    {
        static List<Patlama> patlamalar;

        static Patlamalar()
        {
            patlamalar = new List<Patlama>();
        }

        static public void Ekle(float x, float y, float r)
        {
            patlamalar.Add( new Patlama(x, y, r) );
        }

        static public void Hesapla(float t)
        {
            foreach (Patlama p in patlamalar)
                p.Hesapla(t);

            for (int i = patlamalar.Count - 1; i >= 0; i--)
                if (patlamalar[i].Bitti() == true)
                    patlamalar.RemoveAt(i);
        }

        static public void Ciz()
        {
            foreach (Patlama p in patlamalar)
                p.Ciz();
        }

        static public int Say()
        {
            return patlamalar.Count;
        }


    }
}
