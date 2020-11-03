﻿namespace Ex1
{
    class Complex
    {
        private double im;
        double re;


        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {        
            im = _im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im * re + x2.re * im;
            x3.re = x2.re * re - x2.im * im;
            return x3;
        }

        public Complex Devide(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = (x2.re * im - x2.im * re) / (x2.re * x2.re + x2.im * x2.im);
            x3.re = (x2.re * re + x2.im * im) / (x2.re * x2.re + x2.im * x2.im);
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
