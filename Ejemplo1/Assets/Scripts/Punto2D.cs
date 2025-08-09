using UnityEngine;
using System;

namespace packagePunto2D
{
    [Serializable]
    public class Punto2D 
    {
        public double c_X;
        public double c_Y;

        public Punto2D()
        {
        }

        public Punto2D(double c_X, double c_Y)
        {
            this.c_X = c_X;
            this.c_Y = c_Y;
        }

        public double C_X { get => c_X; set => c_X = value; }
        public double C_Y { get => c_Y; set => c_Y = value; }
    }
}