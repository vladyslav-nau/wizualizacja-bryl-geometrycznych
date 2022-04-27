using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projekt3_BryłyGeometryczneNaumenko51447
{
    class Formularz
    {
        public TypOperacji operacja;
        private List<List<Control>> controls;
        private GłównyFormularz gł;
        public enum TypOperacji : int
        {
            O_STARTOWANIE = 0,
            O_ISTNIEJE_BRYŁA,
            O_SLAJDER_MANUAL,
            O_SLAJDER_AUTO
        }

        public Formularz(GłównyFormularz głównyFormularz)
        {
            gł = głównyFormularz;
            operacja = TypOperacji.O_STARTOWANIE;

            int ilość = Enum.GetNames(typeof(TypOperacji)).Length;

            controls = new List<List<Control>>();

            for (int i = 0; i < ilość; i++)
            {
                controls.Add(new List<Control>());
            }
        }

        public void ZmienićOperacje(TypOperacji oper)
        {
            operacja = oper;

            ZmienaOperacji();
        }

        private void ZmienaOperacji()
        {
            foreach (Control element in gł.Controls)
            {
                element.Enabled = false;
            }

            foreach (Control element in controls[(int)operacja])
            {
                element.Enabled = true;
            }
        }

        public void DodaćElement(TypOperacji oper, Control contl)
        {
            int index = (int)oper;
            controls[index].Add(contl);
        }

        public void DodaćCiągElementów(TypOperacji oper, List<Control> conts)
        {
            int index = (int)oper;
            controls[index].AddRange(conts);
        }


    }
}
