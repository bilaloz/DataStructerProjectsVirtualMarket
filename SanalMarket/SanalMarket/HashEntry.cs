﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMarket
{
    public class HashEntry
    {
        private string anahtar;


        private object deger;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public string Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        public HashEntry(string anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
        }


    }
}
