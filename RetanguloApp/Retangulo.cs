using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloApp
{
    class Retangulo
    {
        private double b, h;
        public void SetBase(double b)
        {
            if (b > 0) this.b = b;
        }
        public void SetAltura(double h)
        {
            if (h > 0) this.h = h;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }

    }
}
