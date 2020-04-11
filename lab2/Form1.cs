using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public void InitMatrix()
        {
            gridA.RowCount = Convert.ToInt32(tbMatrixARowsCount.Text);
            gridA.ColumnCount = Convert.ToInt32(tbMatrixAColsCount.Text);

            gridB.RowCount = Convert.ToInt32(tbMatrixBRowsCount.Text);
            gridB.ColumnCount = Convert.ToInt32(tbMatrixBColsCount.Text);
            //gridB.RowCount = gridA.RowCount;
            //gridB.ColumnCount = gridA.ColumnCount;

            gridAddRes.RowCount = gridA.RowCount;
            gridAddRes.ColumnCount = gridA.ColumnCount;

            gridMultRes.RowCount = gridA.RowCount;
            gridMultRes.ColumnCount = gridB.ColumnCount;

            
        }
        public void FillMatrix()
        {
            //string pathToCsv = @"D:\Programs\vs17programs\ResMatrix.csv";
            Matrix<int> m1 = new Matrix<int>(gridA.RowCount, gridA.ColumnCount);
            Matrix<int> m2 = new Matrix<int>(gridB.RowCount, gridB.ColumnCount);

            Random rnd = new Random();
            
            for (int i = 0; i < gridA.RowCount; i++)
            {
                for (int j = 0; j < gridA.ColumnCount; j++)
                {
                    m1.arr[i, j] = rnd.Next(1, 50);
                    gridA.Rows[i].Cells[j].Value = m1.arr[i, j];
                    
                }
            }
           
            for (int i = 0; i < gridB.RowCount; i++)
            {
                for (int j = 0; j < gridB.ColumnCount; j++)
                {
                    m2.arr[i, j] = rnd.Next(1, 50);
                    gridB.Rows[i].Cells[j].Value = m2.arr[i, j];
                    
                }
            }

            //for (int i = 0; i < gridMultRes.RowCount; i++) // csv
            //{
            //    for (int j = 0; j < gridMultRes.ColumnCount; j++)
            //    {
            //        using (StreamWriter sw = new StreamWriter(pathToCsv, false, Encoding.Default))
            //        {
            //            sw.WriteLine(m4.arr[i, j]);
            //        }
            //    }
            //}
        }

        public void AddMatrix()
        {
            Matrix<int> m1 = new Matrix<int>(gridA.RowCount, gridA.ColumnCount);
            Matrix<int> m2 = new Matrix<int>(gridB.RowCount, gridB.ColumnCount);

            for (int i = 0; i < gridA.RowCount; i++)
            {
                for (int j = 0; j < gridA.ColumnCount; j++)
                {
                    m1.arr[i, j] = Convert.ToInt32(gridA.Rows[i].Cells[j].Value);
                }
            }
            
            for (int i = 0; i < gridB.RowCount; i++)
            {
                for (int j = 0; j < gridB.ColumnCount; j++)
                {
                    m2.arr[i, j] = Convert.ToInt32(gridB.Rows[i].Cells[j].Value);
                }
            }

            gridAddRes.Visible = true;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Matrix<int> m3 = new Matrix<int>(gridA.RowCount, gridA.ColumnCount);
            m3 = m1 + m2;

            for (int i = 0; i < gridAddRes.RowCount; i++)
            {
                for (int j = 0; j < gridAddRes.ColumnCount; j++)
                {                   
                    gridAddRes.Rows[i].Cells[j].Value = m3.arr[i, j];
                }
            }

            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            lblTimeText.Visible = true;
            lblTimeAdd.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts1.Hours, ts1.Minutes, ts1.Seconds,
            ts1.Milliseconds / 10);

        }

        public void MultMatrix()
        {
            Matrix<double> m1 = new Matrix<double>(gridA.RowCount, gridA.ColumnCount);
            Matrix<double> m2 = new Matrix<double>(gridB.RowCount, gridB.ColumnCount);

            for (int i = 0; i < gridA.RowCount; i++)
            {
                for (int j = 0; j < gridA.ColumnCount; j++)
                {
                    m1.arr[i, j] = Convert.ToDouble(gridA.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 0; i < gridB.RowCount; i++)
            {
                for (int j = 0; j < gridB.ColumnCount; j++)
                {
                    m2.arr[i, j] = Convert.ToDouble(gridB.Rows[i].Cells[j].Value);
                }
            }

            Stopwatch stopWatch = new Stopwatch();
            gridMultRes.Visible = true;
            stopWatch.Start();

            Matrix<double> m4 = new Matrix<double>(gridA.RowCount, gridB.ColumnCount);
            m4 = m1 * m2;

            for (int i = 0; i < gridA.RowCount; i++)
            {
                for (int j = 0; j < gridB.ColumnCount; j++)
                {
                    gridMultRes.Rows[i].Cells[j].Value = m4.arr[i, j];
                }
            }

            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;
            lblTimeText2.Visible = true;
            lblTimeMult.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts2.Hours, ts2.Minutes, ts2.Seconds,
            ts2.Milliseconds / 10);
        }
        private void btnShowMatrice_Click(object sender, EventArgs e)
        {
            InitMatrix();
            FillMatrix();          
        }       

        private void btnMultMatrix_Click(object sender, EventArgs e)
        {
            MultMatrix();
        }

        private void btnAddMatrix_Click(object sender, EventArgs e)
        {
            AddMatrix();
        }
    }
}
