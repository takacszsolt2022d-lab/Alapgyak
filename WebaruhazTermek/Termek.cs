using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazTermek
{
    public class Termek
    {
        private int egysegar;
        private int keszlet;

        public string Nev { get; set; }


        public int Egysegar
        {
            get { return egysegar; }
            set
            {
                if (value < 1)
                {
                    egysegar = 1;
                }
                else
                {
                    egysegar = value;
                }
            }
        }

        public int Keszlet
        {
            get { return keszlet; }
            set
            {
                if (value < 0)
                {
                    keszlet = 0;
                }
                else
                {
                    keszlet = value;
                }
            }
        }
    }
}
