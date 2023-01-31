using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Distancia
    {
        public double X1;
        public double X2;
        public double Y1;
        public double Y2;
        public double Distancia_;

        public Distancia(double X1, double X2, double Y1, double Y2, double Distancia_)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.Y1 = Y1;
            this.Y2 = Y2;
            this.Distancia_ = Distancia_;
        }
    public double Calculardistancia(double X1, double X2, double Y1, double Y2)
        {
            this.Distancia_ = Math.Sqrt((Math.Pow(X2 - X1, 2)) + (Math.Pow(Y2 - Y1, 2)));
            return Distancia_;
        }
    }
}
