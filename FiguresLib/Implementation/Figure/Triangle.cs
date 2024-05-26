using FiguresLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib.Implementation.Figure
{
    public class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Triangle side cann't be nagative");
                }
                _sideA = value;
            }
        }

        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Triangle side cann't be nagative");
                }
                _sideB = value;
            }
        }

        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Triangle side cann't be nagative");
                }
                _sideC = value;
            }
        }

        public Triangle(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }

        public double Square()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public bool IsRight()
        {
            double precision = 0.000001;
            return Math.Abs(Math.Pow(SideA, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideC, 2))) < precision ||
                Math.Abs(Math.Pow(SideB, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideC, 2))) < precision ||
                Math.Abs(Math.Pow(SideC, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) < precision;
        }
    }
}
