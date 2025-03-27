using System;
using System.Collections.Generic;

namespace SA2025
{
    static class Gemiler
    {
        static List<Gemi> gemiler;

        static Gemiler()
        {
            gemiler = new List<Gemi>();
        }

        static public void Ekle(int n = 1)
        {
            for (int i=0; i<n; i++)
                gemiler.Add( new Gemi() );
        }

        static public void Hesapla(float t)
        {
            foreach (Gemi g in gemiler)
                g.Hesapla(t);
        }

        static public void Ciz()
        {
            foreach (Gemi g in gemiler)
                g.Ciz();
        }

    }
}
