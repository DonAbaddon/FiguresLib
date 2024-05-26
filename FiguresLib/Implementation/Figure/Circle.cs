using FiguresLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib.Implementation.Figure
{
    public class Circle : IFigure
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Radius cann't be nagative");
                }
                _radius = value;
            }
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
