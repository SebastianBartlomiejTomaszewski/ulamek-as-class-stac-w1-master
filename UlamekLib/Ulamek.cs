﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamekLib
{
    public class Ulamek
    {
        private readonly long licznik = 0;
        private readonly long mianownik = 1;

        public long Licznik => licznik;
        public long Mianownik => mianownik;

        public Ulamek(long licznik, long mianownik )
        {
            if (mianownik == 0)  throw new DivideByZeroException("mianownik nie może być 0");
            if (licznik == 0) mianownik = 1;




            if (mianownik<0)
            {
                licznik = licznik * (-1);
                mianownik=mianownik * (-1);
            }

            var d = nwd(licznik, mianownik);

            licznik = licznik / d;
            mianownik = mianownik / d;

            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ulamek() : this(0 ,1) { }

        public Ulamek( long liczba ) : this(liczba, 1) { }

        public Ulamek( string napis )
        {
            //to do
            throw new NotImplementedException();
        }

        public Ulamek( double x)
        {
            //to do
            throw new NotImplementedException();
        }

        public override string ToString() //=> $"{licznik}/{mianownik}";
        {
            return $"{licznik}/{mianownik}";
        }


        
        private long nwd(long a, long b)
        {
            long tmp;
            while (b != 0)
            {
                tmp = a % b;
                a = b;
                b = tmp;
            }
            return Math.Abs(a);
        }



    }
}
