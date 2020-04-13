using System;

namespace lab2
{
    public class Matrix<T>
    {
        public T[,] arr;
        public int[,] inta;
        Random rnd = new Random();
        public int Rows { get; set; }
        public int Cols { get; set; }
        public Matrix(int x, int y)
        {
            Rows = x;
            Cols = y;
            arr = new T[x, y];
            Del(FillMatrix);
        }

        public T this[int i, int j]
        {
            get
            { return arr[i, j]; }
            set
            { arr[i, j] = value; }
        }

        public void Del(Action<int, int> func)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    func(i, j);
                }
            }
        }

        public void FillMatrix(int i, int j)
        {
            arr[i, j] = default(T);
        }
        //public void FillMatrixInt(int i, int j)
        //{
        //    Matrix<int> a = new Matrix<int>(Rows, Cols);
        //    a.arr[i, j] = rnd.Next(1, 50);
        //    inta[i, j] = a.arr[i, j];
        //}

        public static Matrix<T> operator + (Matrix<T> A, Matrix<T> B)
        {
            Matrix <T> result = new Matrix<T>(A.Rows, A.Cols);
            for(int i = 0; i < result.Rows; i++)
            {   for(int j = 0; j < result.Cols; j++)
                {
                    dynamic dynA = A[i, j];
                    dynamic dynB = B[i, j];
                    result[i, j] = dynA + dynB; 
                    
                }
            }
            return result;
        }

        public static Matrix<T> operator * (Matrix<T> A, Matrix<T> B)
        {
            Matrix<T> result = new Matrix<T>(A.Rows, B.Cols);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    for (int k = 0; k < A.Cols; k++)
                    {
                        dynamic dynA = A[i, k];
                        dynamic dynB = B[k, j];
                        //dynamic dynRes = ;
                        result[i, j] += dynA * dynB;
                    }
                }
            }
            return result;
        }       

    }
    
}
