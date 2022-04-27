using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D; // dodanie nowej przestrzeni nazw
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Projekt3_BryłyGeometryczneNaumenko51447
{
    public partial class GłównyFormularz : Form
    {
        const int Margines = 20;

        //public static BryłyGeometryczne UchwytFormularza = new BryłyGeometryczne();
        Formularz formularz;
        Rysownica rysownica, małaRysownica;

        List<Bryła> listaBrył = new List<Bryła>();
        int IndeksBrył;

        public GłównyFormularz()
        {
            InitializeComponent();

            // lokalizacja i zwymiarowanie formularza
            this.Left = Margines;
            this.Top = Margines;
            this.StartPosition = FormStartPosition.Manual;

            // ustalenie obramowania formularza i ukrucie przycisków jego maksymalizacji i minimalizacji
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // ustawienie na formularzu pasków jego przewijania
            this.AutoScroll = true;
            TimerObrotów.Enabled = true;

            formularz = new Formularz(this);

            rysownica = new Rysownica(PbRysownica);
            małaRysownica = new Rysownica(pictureBox1);
        }

        private void GłównyFormularz_Load(object sender, EventArgs e)
        {
            formularz.DodaćCiągElementów(
                Formularz.TypOperacji.O_STARTOWANIE,
                new List<Control> { panelkaBryła }); // elementy formularza, kiedy pracujemy z bryłą
            formularz.DodaćCiągElementów(
                Formularz.TypOperacji.O_ISTNIEJE_BRYŁA,
                new List<Control> { panelkaBryła, panelkaSlajdy, panelkaUsuń, PrzyciskWłączSlajder, PrzyciskPobraćObrazek, PrzyciszKierunekObrotu }); // elementy formularza, kiedy pracujemy z slajderem
            formularz.DodaćCiągElementów(
                Formularz.TypOperacji.O_SLAJDER_MANUAL,
                new List<Control> { BtnNastępny, TbNumerBryły, BtnPoprzedni, BtnWyłączSlajderPokazuBryłGeometrycznych });
            formularz.DodaćCiągElementów(
                Formularz.TypOperacji.O_SLAJDER_AUTO,
                new List<Control> { BtnWyłączSlajderPokazuBryłGeometrycznych });


            formularz.ZmienićOperacje(Formularz.TypOperacji.O_STARTOWANIE);
        }

        private void CzasObrotów_Tick(object sender, EventArgs e)
        {
            foreach (Bryła bryła in listaBrył)
            {
                bryła.ObróćIWykreśl(rysownica.m_obrazek, rysownica.m_rysunek, 5f);
            }
            rysownica.Refresh();
        }

        private void Przycisk_DodajNowąBryłę_Click(object sender, EventArgs e)
        {
            if (CbWybierzBryłęGeometryczną.SelectedIndex < 0)
            {
                ErrorProvider.SetError(CbWybierzBryłęGeometryczną, "BŁĄD! musisz wybrać geometryczną bryłę");
                return;
            }
            else ErrorProvider.Dispose();

            string RodzajBryły;
            int PromieńBryły;
            int WysokośćBryły;
            int StopieńWielokątaBryły;
            float KątPochyleniaBryły;
            int WspółrzędnaXpodłogiBryły;
            int WspółrzędnaYpodłogiBryły;

            Color KolorLinii;
            DashStyle StylLinii;
            int GrubośćLinii;

            Random GenerujLiczbęLosową = new Random();

            KolorLinii = Color.Gray;
            StylLinii = WybórStylu(0);
            GrubośćLinii = 2;

            RodzajBryły = CbWybierzBryłęGeometryczną.Text;
            PromieńBryły = TbUstałPromieńBryły.Value;
            WysokośćBryły = TbUstałWysokośćBryły.Value;
            StopieńWielokątaBryły = (int)NudStopieńWielokątaPodstałyBryły.Value;
            KątPochyleniaBryły = (float)TbKątNachyfeniaBryłyGeometrycznej.Value;

            WspółrzędnaXpodłogiBryły = GenerujLiczbęLosową.Next(PromieńBryły, rysownica.m_obrazek.Width);
            WspółrzędnaYpodłogiBryły = GenerujLiczbęLosową.Next(WysokośćBryły, rysownica.m_obrazek.Height);

            switch (RodzajBryły)
            {
                case "Walec":
                    Walec Walec = new Walec(
                        PromieńBryły,
                        WysokośćBryły,
                        StopieńWielokątaBryły,
                        WspółrzędnaXpodłogiBryły,
                        WspółrzędnaYpodłogiBryły,
                        KątPochyleniaBryły,
                        KolorLinii,
                        StylLinii,
                        GrubośćLinii);
                    listaBrył.Add(Walec);
                    break;
                case "Stożek":
                    Stożek Stożek = new Stożek(
                        PromieńBryły,
                        WysokośćBryły,
                        StopieńWielokątaBryły,
                        WspółrzędnaXpodłogiBryły,
                        WspółrzędnaYpodłogiBryły,
                        KątPochyleniaBryły,
                        KolorLinii,
                        StylLinii,
                        GrubośćLinii);
                    listaBrył.Add(Stożek);
                    break;
                default:
                    MessageBox.Show("BŁĄD! nierozpoznana bryła geometryczna!");
                    return;
            }

            listaBrył[listaBrył.Count - 1].Wykreśl(rysownica.m_rysunek);

            // onowienie obrazka
            rysownica.Refresh();

            formularz.ZmienićOperacje(Formularz.TypOperacji.O_ISTNIEJE_BRYŁA);
        }

        private void Przycisk_UstawNoweAtrybutyGraficzne_Click(object sender, EventArgs e)
        {
            if (listaBrył.Count <= 0) return;

            Color kolorLinii;
            DashStyle styłLinii;
            int grubośćLinii;

            rysownica.Clear();

            Random generujLosowąLiczbę = new Random();
            foreach (Bryła bryła in listaBrył)
            {
                kolorLinii = Color.FromArgb(generujLosowąLiczbę.Next(25, 255),
                                            generujLosowąLiczbę.Next(25, 255),
                                            generujLosowąLiczbę.Next(25, 255));
                styłLinii = WybórStylu(generujLosowąLiczbę.Next(6));
                grubośćLinii = generujLosowąLiczbę.Next(3, 6);

                bryła.UstalAtrybutyGraficzne(kolorLinii, styłLinii, grubośćLinii);
            }
            rysownica.Refresh();
        }

        DashStyle WybórStylu(int n)
        {
            switch (n)
            {
                case 1: return DashStyle.DashDot;
                case 2: return DashStyle.DashDotDot;
                case 3: return DashStyle.Dot;
                case 4: return DashStyle.Solid;
                default: return DashStyle.Dash;
            }
        }

        private void Przycisk_WulosujNowePołożenie_Click(object sender, EventArgs e)
        {
            if (listaBrył.Count <= 0) return;

            int Xmax = rysownica.m_obrazek.Width;
            int Ymax = rysownica.m_obrazek.Height;

            Random GenerujLiczbęLosową = new Random();

            rysownica.Clear();

            for (int i = 0; i < listaBrył.Count; i++)
            {
                int WspółrzędnaXpodłogiBryły = GenerujLiczbęLosową.Next(0, Xmax);
                int WspółrzędnaYpodłogiBryły = GenerujLiczbęLosową.Next(0, Ymax);

                listaBrył[i].Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, WspółrzędnaXpodłogiBryły, WspółrzędnaYpodłogiBryły);
            }
            rysownica.Refresh();
        }

        private void Przycisk_WłączSlajder_Click(object sender, EventArgs e)
        {
            if (listaBrył.Count > 1)
            {
                TimerObrotów.Enabled = false;

                GbKryteriaPokazuBryłGeometrycznych.Enabled = false;

                if (RbWysokość.Checked)
                {
                    Bryła.typPorównania = Bryła.PorównaniaTyp.P_WYSOKOŚĆ;
                }
                else if (RbObiętość.Checked)
                {
                    Bryła.typPorównania = Bryła.PorównaniaTyp.P_OBIĘTOŚĆ;
                }
                else if (RbPolePowierzchni.Checked)
                {
                    Bryła.typPorównania = Bryła.PorównaniaTyp.P_PPOWIERZCHNI;
                }
                else
                {
                    Bryła.typPorównania = Bryła.PorównaniaTyp.P_WYSOKOŚĆ;
                }

                listaBrył.Sort();

                for (int i = 0; i < listaBrył.Count; i++)
                {
                    listaBrył[i].Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, PbRysownica.Width / 2, PbRysownica.Height / 2);
                }

                foreach (Bryła bryła in listaBrył)
                {
                    bryła.Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, rysownica.m_obrazek.Width / 2, rysownica.m_obrazek.Height / 2);
                }
                rysownica.Clear();
                rysownica.Refresh();

                if (RbZegarowy.Checked)
                {
                    TimerSlajdera.Tag = 0;
                    TimerSlajdera.Enabled = true;

                    formularz.ZmienićOperacje(Formularz.TypOperacji.O_SLAJDER_AUTO);
                }
                else
                {
                    TbNumerBryły.Text = "0";
                    int NumerBryły = 0;
                    if (string.IsNullOrEmpty(TbNumerBryły.Text))
                        TbNumerBryły.Text = "0";
                    else if (!int.TryParse(TbNumerBryły.Text, out NumerBryły))
                    {
                        ErrorProvider.SetError(TbNumerBryły, "BŁĄD! wystąpił niedozwolony znak w podanym numerze brył");
                        return;
                    }
                    else ErrorProvider.Dispose();

                    formularz.ZmienićOperacje(Formularz.TypOperacji.O_SLAJDER_MANUAL);
                }
            }
            else
            {
                ErrorProvider.SetError(PrzyciskWłączSlajder, "BŁĄD! musi być co najmniej 2 figury");
                return;
            }
        }

        private void Przycisk_WyłączSlajderPokazuBryłGeometrycznych_Click(object sender, EventArgs e)
        {
            TimerObrotów.Enabled = true;
            TimerSlajdera.Enabled = false;

            rysownica.Refresh();

            formularz.ZmienićOperacje(Formularz.TypOperacji.O_ISTNIEJE_BRYŁA);
        }

        private void Przycisk_UsuńOstatnioDodanąBryłę_Click(object sender, EventArgs e)
        {
            usuńBryły(listaBrył.Count - 1); // bryła o ostannim indeksie, czyli ostatnia w liscie
        }

        private void BtnUsuńWybranąBryłę_Click(object sender, EventArgs e)
        {
            int index = (int)NudNumerUsuwanejBryły.Value;
            usuńBryły(index); // bryła o indeksie wybranym indeksie
        }

        private void BtnUsuńPierwsząDodanąBryłę_Click(object sender, EventArgs e)
        {
            usuńBryły(0); // bryła o indeksie 0, czyli pierwsza
        }


        private void TimerSlajdera_Tick(object sender, EventArgs e)
        {
            rysownica.Clear();

            int Xmax = rysownica.m_obrazek.Width - Margines;
            int Ymax = rysownica.m_obrazek.Height - Margines;

            TbNumerBryły.Text = TimerSlajdera.Tag.ToString();

            listaBrył[(int)TimerSlajdera.Tag].Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, Xmax / 2, Ymax / 2);

            rysownica.Refresh();

            TimerSlajdera.Tag = (int.Parse(TimerSlajdera.Tag.ToString()) + 1) % listaBrył.Count;
        }

        private void BtnNastępny_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbNumerBryły.Text))
                TbNumerBryły.Text = "0";
            else if (!int.TryParse(TbNumerBryły.Text, out IndeksBrył))
            {
                ErrorProvider.SetError(TbNumerBryły, "ERROR: wystąpił niedozwolony znak w podanym numerze brył");
                return;
            }
            else ErrorProvider.Dispose();

            IndeksBrył = int.Parse(TbNumerBryły.Text);

            listaBrył[IndeksBrył].Wymaż(rysownica.m_obrazek, rysownica.m_rysunek);

            if (IndeksBrył < (listaBrył.Count - 1))
                IndeksBrył++;
            else
                IndeksBrył = 0;

            int Xmax = rysownica.m_obrazek.Width;
            int Ymax = rysownica.m_obrazek.Height;

            listaBrył[IndeksBrył].Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, Xmax / 2, Ymax / 2);

            TbNumerBryły.Text = IndeksBrył.ToString();

            rysownica.Refresh();
        }

        private void BtnPoprzedni_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TbNumerBryły.Text))
                TbNumerBryły.Text = "0";
            else if (!int.TryParse(TbNumerBryły.Text, out IndeksBrył))
            {
                ErrorProvider.SetError(TbNumerBryły, "ERROR: wystąpił niedozwolony znak w podanym numerze brył");
                return;
            }
            else ErrorProvider.Dispose();

            IndeksBrył = int.Parse(TbNumerBryły.Text);

            listaBrył[IndeksBrył].Wymaż(rysownica.m_obrazek, rysownica.m_rysunek);

            if (IndeksBrył > 0)
                IndeksBrył--;
            else
                IndeksBrył = listaBrył.Count - 1;

            int Xmax = rysownica.m_obrazek.Width;
            int Ymax = rysownica.m_obrazek.Height;

            listaBrył[IndeksBrył].Przesuń(rysownica.m_obrazek, rysownica.m_rysunek, Xmax / 2, Ymax / 2);

            TbNumerBryły.Text = IndeksBrył.ToString();

            rysownica.Refresh();
        }

        private void Przycisk_KierunekObrotu_Click(object sender, EventArgs e)
        {
            Bryła.kierunekObrotu = !Bryła.kierunekObrotu;
        }

        private void Przycisk_PobraćObrazek_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (save.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(save.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                rysownica.m_obrazek.Image.Save(save.FileName, format);
            }
        }

        private void CbWybierzBryłęGeometryczną_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbWybierzBryłęGeometryczną.SelectedItem.ToString())
            {
                case "Stożek":
                    małaRysownica.m_obrazek.Image = Properties.Resources.stozek;
                    break;
                case "Walec":
                    małaRysownica.m_obrazek.Image = Properties.Resources.walec;
                    break;
                default:
                    return;
            }
        }
        void usuńBryły(int index)
        {
            if ((listaBrył.Count > 0) && (listaBrył.Count > index))
            {
                listaBrył[index].Wymaż(rysownica.m_obrazek, rysownica.m_rysunek);
                listaBrył.Remove(listaBrył[index]);

                if (listaBrył.Count == 0)
                {
                    formularz.ZmienićOperacje(Formularz.TypOperacji.O_STARTOWANIE);
                }
            }
            else
            {
                MessageBox.Show("BŁĄD! Albo liczba jest duża, albo w ogóle nie istnieje brył na rysownice!");
            }
            rysownica.Refresh();
        }
    }
}