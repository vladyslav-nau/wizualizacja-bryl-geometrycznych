using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projekt3_BryłyGeometryczneNaumenko51447
{
    abstract class Bryła : IComparable<Bryła>
    {
        public static PorównaniaTyp typPorównania = PorównaniaTyp.P_WYSOKOŚĆ;
        public static bool kierunekObrotu = false; // true: w prawo, false: w lewo
                                                   // deklaracje dla potrzeb pokazu Brył
        public enum PorównaniaTyp
        {
            P_WYSOKOŚĆ,
            P_OBIĘTOŚĆ,
            P_PPOWIERZCHNI
        }
        public int CompareTo(Bryła drugaBryła)
        {
            if (typPorównania == PorównaniaTyp.P_WYSOKOŚĆ)
            {
                if (this.wysokośćBryły > drugaBryła.wysokośćBryły) return 1;
                else if (this.wysokośćBryły < drugaBryła.wysokośćBryły) return -1;
                else return 0;
            }
            else if (typPorównania == PorównaniaTyp.P_OBIĘTOŚĆ)
            {
                if (this.objętośćBryły > drugaBryła.objętośćBryły) return 1;
                else if (this.objętośćBryły < drugaBryła.objętośćBryły) return -1;
                else return 0;
            }
            else if (typPorównania == PorównaniaTyp.P_PPOWIERZCHNI)
            {
                if (this.powierzchniaBryły > drugaBryła.powierzchniaBryły) return 1;
                else if (this.powierzchniaBryły < drugaBryła.powierzchniaBryły) return -1;
                else return 0;
            }
            return 0;
        }

        public const float kątProsty = 90.0f;
        // deklaracja typu wyliczeniowego
        public enum TypBryły { GB_WALEC, GB_STOŻEK, GB_KULA };
        protected int xSufit, ySufit;
        protected int xPodstawy, yPodstawy;
        protected int wysokośćBryły;
        protected float kątPochylenia;

        // deklaracje wspólnych atrybutów graficznych bruł geometrycznych 
        protected int grubośćLinii;
        protected Color kolorLinii;
        protected DashStyle styłLinii;

        // deklaracje atrybutów niezbędnych dla implementacji funkcjonalności projektowanego programu
        public TypBryły rodzajBryły; // dla identyfikacji bryły
        protected float powierzchniaBryły;
        protected float objętośćBryły;

        // deklaracja konstruktora
        public Bryła(Color kolorLinii, DashStyle styłLinii, int grubośćLinii)
        {
            this.kolorLinii = kolorLinii;
            this.styłLinii = styłLinii;
            this.grubośćLinii = grubośćLinii;
            this.kątPochylenia = 90.0F;
        }

        // deklaracja metod abstrakcyjnych
        protected abstract void Obliczenie();
        protected abstract void Narysować(Graphics powierzchniaGraficzna, Pen pen);
        public abstract void Wykreśl(Graphics rysownica);
        public abstract void Wymaż(Control kontrolka, Graphics rysownica);
        public abstract void ObróćIWykreśl(Control kontrolka, Graphics rysownica, float kątObrotu);
        public abstract void Przesuń(Control kontrolka, Graphics powierzchniaGraficzna, int X, int Y);

        // deklaracje publiczne
        public void UstalAtrybutyGraficzne(Color kolorLinii, DashStyle styłLinii, int grubośćLinii)
        {
            this.kolorLinii = kolorLinii;
            this.styłLinii = styłLinii;
            this.grubośćLinii = grubośćLinii;
        }
        public void ZmieńKolorLinii(Color kolorLinii)
        {
            this.kolorLinii = kolorLinii;
        }
        public Color PobierzKolorLinii()
        {
            return this.kolorLinii;
        }
    }
    class BryłyObrotowe : Bryła
    {
        protected int promieńBryły;
        // deklaracja konstruktora klasy BryłyObrotowe
        public BryłyObrotowe(int r, Color kolorLinii, DashStyle styłLinii, int grubośćLinii) : base(kolorLinii, styłLinii, grubośćLinii)
        {
            this.promieńBryły = r;
        }
        // napisanie metod abstakcyjnych zadeklarowanych w klasie Bryły
        protected override void Obliczenie()
        {

        }
        protected override void Narysować(Graphics powierzchniaGraficzna, Pen pióro)
        {

        }
        public override void Wykreśl(Graphics powierzchniaGraficzna)
        {

        }
        public override void Wymaż(Control kontrolka, Graphics powierzchniaGraficzna)
        {

        }
        public override void ObróćIWykreśl(Control kontrolka, Graphics powierzchniaGraficzna, float kątObrotu)
        {

        }
        public override void Przesuń(Control kontrolka, Graphics powierzchniaGraficzna, int x, int y)
        {

        }

    }// koniec deklaracji klasy BryłyObrotowe
     // deklaracja klas potomnych BryłyObrotowe
    class Walec : BryłyObrotowe
    {
        Point[] wielokątPodstawy, wielokątSufitu;
        int stopieńWielokątaPodstawy;
        float ośDuża, ośMała;
        float kątMiędzyWierzchołkami;
        float kątPołożenia;
        int wektorPrzesunięciaWierzchołkaWalec;

        public Walec(int r, int wysokość, int stopieńWielokątaPodstawy, int x, int y, float kątPochyleniaWalec,
            Color kolorLinii, DashStyle styłLinii, int grubośćLinii) : base(r, kolorLinii, styłLinii, grubośćLinii)
        {
            Pen Pióro = new Pen(this.kolorLinii, this.grubośćLinii);
            Pióro.DashStyle = this.styłLinii;

            this.rodzajBryły = TypBryły.GB_WALEC;
            this.wysokośćBryły = wysokość;
            this.kątPochylenia = kątPochyleniaWalec;
            this.stopieńWielokątaPodstawy = stopieńWielokątaPodstawy;
            this.ośDuża = this.promieńBryły * 2;
            this.ośMała = this.promieńBryły / 2;

            if (kątPochyleniaWalec < kątProsty)
            {
                float KątBeta = kątProsty - kątPochyleniaWalec;
                wektorPrzesunięciaWierzchołkaWalec = (int)(wysokość * (float)(Math.Tan(KątBeta *
                   (Math.PI / 180F))));
                xSufit = x + wektorPrzesunięciaWierzchołkaWalec;
            }
            else if (kątPochyleniaWalec > kątProsty)
            {
                float KątBeta = kątPochyleniaWalec - kątProsty;
                wektorPrzesunięciaWierzchołkaWalec = (int)(wysokość * (float)(Math.Tan(KątBeta *
                   (Math.PI / 180F))));
                xSufit = x - wektorPrzesunięciaWierzchołkaWalec;
            }
            else this.xSufit = x;
            this.ySufit = y - wysokość;
            this.xPodstawy = x;
            this.yPodstawy = y;
            this.kątMiędzyWierzchołkami = 360 / stopieńWielokątaPodstawy;
            this.kątPołożenia = 0F;


            this.wielokątSufitu = new Point[stopieńWielokątaPodstawy + 1];
            this.wielokątPodstawy = new Point[stopieńWielokątaPodstawy + 1];
            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                wielokątSufitu[i] = new Point();
                wielokątSufitu[i].X = (int)(this.xSufit + ośDuża / 2 *
                   Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątSufitu[i].Y = (int)(this.ySufit + ośMała / 2 *
                   Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątPodstawy[i] = new Point();
                wielokątPodstawy[i].X = (int)(this.xPodstawy + ośDuża / 2 *
                   Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątPodstawy[i].Y = (int)(this.yPodstawy + ośMała / 2 *
                   Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
            }

            this.objętośćBryły = (float)(Math.PI * Math.Pow(this.promieńBryły, 2) * this.wysokośćBryły);
            this.powierzchniaBryły = (float)((2 * Math.PI * Math.Pow(this.promieńBryły, 2)) +
                (2 * Math.PI * this.promieńBryły * this.wysokośćBryły));
        }
        protected override void Obliczenie()
        {
            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                wielokątSufitu[i].X = (int)(this.xSufit + ośDuża / 2 *
                   Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątSufitu[i].Y = (int)(this.ySufit + ośMała / 2 *
                   Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątPodstawy[i] = new Point();
                wielokątPodstawy[i].X = (int)(this.xPodstawy + ośDuża / 2 *
                   Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
                wielokątPodstawy[i].Y = (int)(this.yPodstawy + ośMała / 2 *
                   Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180F));
            }
        }
        protected override void Narysować(Graphics powierzchniaGraficzna, Pen pióro)
        {
            pióro.DashStyle = this.styłLinii;

            powierzchniaGraficzna.DrawEllipse(pióro, this.xPodstawy - this.ośDuża / 2,
               this.yPodstawy - this.ośMała / 2, this.ośDuża, this.ośMała);
            powierzchniaGraficzna.DrawEllipse(pióro, this.xSufit - this.ośDuża / 2,
               this.ySufit - this.ośMała / 2, this.ośDuża, this.ośMała);

            powierzchniaGraficzna.DrawLine(pióro, this.xPodstawy - this.ośDuża / 2,
             this.yPodstawy, this.xSufit - this.ośDuża / 2, this.ySufit);
            powierzchniaGraficzna.DrawLine(pióro, this.xPodstawy + this.ośDuża / 2,
             this.yPodstawy, this.xSufit + this.ośDuża / 2, this.ySufit);

            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                powierzchniaGraficzna.DrawLine(pióro, wielokątPodstawy[i], wielokątSufitu[i]);
            }
        }

        public override void Wykreśl(Graphics powierzchniaGraficzna)
        {
            Pen pióro = new Pen(this.kolorLinii, this.grubośćLinii);
            {
                Narysować(powierzchniaGraficzna, pióro);
            }

        }
        public override void Wymaż(Control kontrolka, Graphics powierzchniaGraficzna)
        {
            using (Pen pióro = new Pen(kontrolka.BackColor, this.grubośćLinii))
            {
                Narysować(powierzchniaGraficzna, pióro);
            }
        }
        public override void ObróćIWykreśl(Control kontrolka, Graphics powierzchniaGraficzna, float kątObrotu)
        {
            Wymaż(kontrolka, powierzchniaGraficzna);

            if (!kierunekObrotu)
                this.kątPołożenia += kątObrotu;
            else this.kątPołożenia -= kątObrotu;


            Obliczenie();

            Wykreśl(powierzchniaGraficzna);
        }
        public override void Przesuń(Control kontrolka, Graphics powierzchniaGraficzna, int x, int y)
        {
            Wymaż(kontrolka, powierzchniaGraficzna);

            int Dx = xPodstawy < x ? x - xPodstawy : -(xPodstawy - x);
            int Dy = yPodstawy < y ? y - yPodstawy : -(yPodstawy - y);
            this.xPodstawy = xPodstawy + Dx;
            this.yPodstawy = yPodstawy + Dy;
            this.xSufit = xSufit + Dx;
            this.ySufit = ySufit + Dy;

            Obliczenie();

            Wykreśl(powierzchniaGraficzna);
        }
    }
    class Stożek : BryłyObrotowe
    {
        // deklaracja opisujące bryłę Stożek
        int stopieńWielokątaPodstawy;
        float ośDuża, ośMała;
        float kątMiędzyWierzchołkami;
        float kątPołożenia;
        Point[] wielokątPodłogi;
        int wektorPrzesunięciaWierzchołkaStożka;
        // deklaracja konstruktora klasy Stożek
        public Stożek(int r, int wysokośćStożka, int stopieńWielokątaPodstawy,
            int x, int y, float kątPochyleniaStożka, Color kolorLinii, DashStyle styłLinii, int grubośćLinii) :
            base(r, kolorLinii, styłLinii, grubośćLinii)
        {
            this.rodzajBryły = TypBryły.GB_STOŻEK;
            this.wysokośćBryły = wysokośćStożka;
            this.kątPochylenia = kątPochyleniaStożka;
            this.stopieńWielokątaPodstawy = stopieńWielokątaPodstawy;
            this.ośDuża = this.promieńBryły * 2;
            this.ośMała = this.promieńBryły / 2;

            // wyznaczenie współrzendnej XsS wierzchółka Stożka
            if (kątPochyleniaStożka < kątProsty)
            {
                float KątBeta = kątProsty - kątPochyleniaStożka;
                wektorPrzesunięciaWierzchołkaStożka =
               (int)(wysokośćStożka * (float)(Math.Tan(KątBeta * (Math.PI / 180F))));
                xSufit = x + wektorPrzesunięciaWierzchołkaStożka;
            }
            else if (kątPochyleniaStożka > kątProsty)
            {
                float KątBeta = kątPochyleniaStożka - kątProsty;
                wektorPrzesunięciaWierzchołkaStożka = (int)(wysokośćStożka * (float)(Math.Tan(KątBeta * (Math.PI / 180f))));
                xSufit = x - wektorPrzesunięciaWierzchołkaStożka;
            }
            else xSufit = x;

            this.ySufit = y - wysokośćStożka;
            this.xPodstawy = x;
            this.yPodstawy = y;

            this.kątMiędzyWierzchołkami = 360 / stopieńWielokątaPodstawy;
            this.kątPołożenia = 0f;
            this.wielokątPodłogi = new Point[stopieńWielokątaPodstawy + 1];

            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                wielokątPodłogi[i] = new Point();
                wielokątPodłogi[i].X = (int)(this.xPodstawy + ośDuża / 2 *
                   Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180f));
                wielokątPodłogi[i].Y = (int)(this.yPodstawy + ośMała / 2 *
                   Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180f));
            }

            this.objętośćBryły = (float)(Math.PI * Math.Pow(this.promieńBryły, 2) * this.wysokośćBryły) / 3;
            this.powierzchniaBryły = (float)(Math.PI * this.promieńBryły * (this.promieńBryły + Math.Sqrt(this.wysokośćBryły * this.wysokośćBryły + this.promieńBryły * this.promieńBryły)));
        }
        protected override void Obliczenie()
        {
            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                wielokątPodłogi[i].X = (int)(this.xPodstawy + ośDuża / 2 * Math.Cos(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180f));
                wielokątPodłogi[i].Y = (int)(this.yPodstawy + ośMała / 2 * Math.Sin(Math.PI * (kątPołożenia + i * kątMiędzyWierzchołkami) / 180f));
            }
        }
        protected override void Narysować(Graphics powierzchniaGraficzna, Pen pióro)
        {
            pióro.DashStyle = this.styłLinii;

            powierzchniaGraficzna.DrawEllipse(pióro, this.xPodstawy - this.ośDuża / 2, this.yPodstawy - this.ośMała / 2, this.ośDuża, this.ośMała);

            powierzchniaGraficzna.DrawLine(pióro, this.xPodstawy - this.ośDuża / 2, this.yPodstawy,
               this.xSufit, this.ySufit);
            powierzchniaGraficzna.DrawLine(pióro, this.xPodstawy + this.ośDuża / 2, this.yPodstawy,
               this.xSufit, this.ySufit);

            for (int i = 0; i <= stopieńWielokątaPodstawy; i++)
            {
                powierzchniaGraficzna.DrawLine(pióro, wielokątPodłogi[i], new Point(this.xSufit, this.ySufit));
            }
            pióro.Dispose();
        }
        public override void Wykreśl(Graphics powierzchniaGraficzna)
        {
            Pen pióro = new Pen(this.kolorLinii, this.grubośćLinii);
            Narysować(powierzchniaGraficzna, pióro);
        }
        public override void Wymaż(Control kontrolka, Graphics powierzchniaGraficzna)
        {
            Pen pióro = new Pen(kontrolka.BackColor, this.grubośćLinii);
            Narysować(powierzchniaGraficzna, pióro);
        }
        public override void ObróćIWykreśl(Control kontrolka, Graphics powierzchniaGraficzna, float kątObrotu)
        {
            Wymaż(kontrolka, powierzchniaGraficzna);

            if (!kierunekObrotu)
                this.kątPołożenia += kątObrotu;
            else
                this.kątPołożenia -= kątObrotu;

            Obliczenie();

            Wykreśl(powierzchniaGraficzna);
        }
        public override void Przesuń(Control kontrolka, Graphics powierzchniaGraficzna, int X, int Y)
        {
            Wymaż(kontrolka, powierzchniaGraficzna);

            int dX = xPodstawy < X ? X - xPodstawy : -(xPodstawy - X);
            int dY = yPodstawy < Y ? Y - yPodstawy : -(yPodstawy - Y);

            this.xPodstawy = xPodstawy + dX;
            this.yPodstawy = yPodstawy + dY;
            this.xSufit = xSufit + dX;
            this.ySufit = ySufit + dY;

            Obliczenie();

            Wykreśl(powierzchniaGraficzna);
        }
    }
}
