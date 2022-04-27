using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projekt3_BryłyGeometryczneNaumenko51447
{
    class Rysownica
    {
        public Graphics m_rysunek { get; }
        public PictureBox m_obrazek { get; }
        public Rysownica(PictureBox obrazek)
        {
            m_obrazek = obrazek;
            m_obrazek.Image = new Bitmap(obrazek.Size.Width, obrazek.Size.Height);

            m_rysunek = Graphics.FromImage(m_obrazek.Image);
        }

        public void Clear()
        {
            m_rysunek.Clear(m_obrazek.BackColor);
        }

        public void Refresh()
        {
            m_obrazek.Refresh();
        }
    }
}
