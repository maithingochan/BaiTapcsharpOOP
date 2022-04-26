using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTBac2
{
    class GiaiB2
    {

        private double a;
        private double b;
        private double c;

        public GiaiB2()
        {

        }

        public GiaiB2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public string GiaiPT()
        {
            string kq = "";
            double x1, x2;

            if (a == 0 && b == 0 && c == 0)
                kq = "phuong trinh vo so nghiem";
            else
                if (a == 0 && b == 0)
                kq = "phuong trinh vo nghiem";
            else
                 if (a == 0)
                kq = "nhiem bac nhat x = " + (-c / b);
            else
            {
                double denta;
                denta = b * b - 4 * a * c;
                if (denta < 0)
                    kq = "phuong trinh vo nghiem";
                else
                    if (denta == 0)
                    kq = "nghiem kep x =" + (-b / (2 * a));
                else
                {
                    kq = "hai nghiem phan biet x1=" + (-b - Math.Sqrt(denta) / (2 * a)) + "; x2 =" + (-b + Math.Sqrt(denta) / (2 * a));
                }
            }
            return kq;
        }
    }
}

