using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_3_Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSetDimensions_Click(object sender, EventArgs e)
        {
            int rows1, rows2, columns1, columns2;
            bool check1 = int.TryParse(RowsA.Text, out rows1);
            bool check2 = int.TryParse(ColumnsA.Text, out columns1);
            bool check3 = int.TryParse(RowsB.Text, out rows2);
            bool check4 = int.TryParse(ColumnsB.Text, out columns2);
            if (check1 && check2 && check3 && check4)
            {
                MatrixA.RowCount = rows1;
                MatrixA.ColumnCount = columns1;
                MatrixB.RowCount = rows2;
                MatrixB.ColumnCount = columns2;
            }

        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            for (int i = 0; i < MatrixA.RowCount; i++)
            {
                for (int j = 0; j < MatrixA.ColumnCount; j++)
                {
                    MatrixA.Rows[i].Cells[j].Value = Convert.ToDouble(rnd.Next(-10, 100));
                }
            }
            for (int i = 0; i < MatrixB.RowCount; i++)
            {
                for (int j = 0; j < MatrixB.ColumnCount; j++)
                {
                    MatrixB.Rows[i].Cells[j].Value = Convert.ToDouble(rnd.Next(-10, 100));
                }

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < MatrixA.RowCount; i++)
                {
                    for (int j = 0; j < MatrixA.ColumnCount; j++)
                    {
                        if (Convert.ToDouble(MatrixA.Rows[i].Cells[j].Value) < 0)
                        {
                            throw new Exception("Первая матрица содержит отрицательное значение!");
                        }
                    }
                }
                for (int i = 0; i < MatrixB.RowCount; i++)
                {
                    for (int j = 0; j < MatrixB.ColumnCount; j++)
                    {
                        if (Convert.ToDouble(MatrixB.Rows[i].Cells[j].Value) < 0)
                        {
                            throw new Exception("Вторая матрица содержит отрицательное значение!");
                        }
                    }
                }
                if (MatrixA.ColumnCount == MatrixB.RowCount)
                {
                    MatrixC.RowCount = MatrixA.RowCount;
                    MatrixC.ColumnCount = MatrixB.ColumnCount;
                    for (int i = 0; i < MatrixA.RowCount; i++)
                    {
                        for (int j = 0; j < MatrixB.ColumnCount; j++)
                        {
                            double element = 0;
                            for (int k = 0; k < MatrixA.ColumnCount; k++)
                            {
                                element +=
                                Convert.ToDouble(MatrixA.Rows[i].Cells[k].Value) *
                                    Convert.ToDouble(MatrixB.Rows[k].Cells[j].Value);
                            }
                            MatrixC.Rows[i].Cells[j].Value = element;
                        }
                    }
                }
                else
                {
                    throw new Exception("Количество столбцов в 1 матрице должно быть равно количеству строк во 2 матрице!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MatrixA.Rows.Clear();
            MatrixA.Columns.Clear();
            MatrixB.Rows.Clear();
            MatrixB.Columns.Clear();
            MatrixC.Columns.Clear();
        }

    }
}
