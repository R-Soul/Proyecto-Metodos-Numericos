using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liga_Negra
{
   
    public class MMatrix
    {

        private double[,] data;
        public MMatrix(double[,] data)
        {
            this.data = data;
        }

        public MMatrix(int rows, int columns)
        {
            this.data = new double[rows, columns];
        }

        public double[,] Matrix
        {
            get
            {
                return data;
            }
        }

        public int[,] MatrixInteger
        {
            get
            {
                int[,] matrixInteger = new int[data.GetUpperBound(0) + 1, data.GetUpperBound(1) + 1];
                for (int i = 0; i <= data.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= data.GetUpperBound(1); j++)
                    {
                        matrixInteger[i, j] = (int) Math.Ceiling(data[i, j]);
                    }
                }
                return matrixInteger;
            }
        }

    }
}
