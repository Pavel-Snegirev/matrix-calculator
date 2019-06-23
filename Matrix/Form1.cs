using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //обработчик события на изменение значения компонета
        private void numCountRows_ValueChanged(object sender, EventArgs e)
        {
            matrixOne.RowCount = (int)numCountRows.Value;
        }

        //обработчик обработчик события на изменение значения компонета
        private void numCountCollum_ValueChanged(object sender, EventArgs e)
        {
            matrixOne.ColumnCount = (int)numCountCollum.Value;
        }

        //обработчик обработчик события на изменение значения компонета
        private void numRowsCountM2_ValueChanged(object sender, EventArgs e)
        {
            matrixTwo.RowCount = (int)numRowsCountM2.Value;
        }

        //обработчик обработчик события на изменение значения компонета
        private void numCollCountM2_ValueChanged(object sender, EventArgs e)
        {
            matrixTwo.ColumnCount = (int)numCollCountM2.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrixOne.RowCount = 2;
            matrixOne.ColumnCount = 2;
            matrixTwo.RowCount = 2;
            matrixTwo.ColumnCount = 2;
        }

        //обработчик события
        private void matrixOne_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        //если нажата кнопка проверяем введены ли цифры
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',')))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }

        //заполняем матрицу 1 случайными числами
        private void button1_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixOne);
        }

        //очищаем матрицу 1
        private void button3_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixOne);
        }

        /// <summary>
        /// Заполняет грид случайными числами в диапазоне от 1 до 4
        /// </summary>
        /// <param name="dg"></param>
        private void randomMatrix(DataGridView dg)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            //кешируем количество строк и столбцов грида
            int collCount = dg.ColumnCount;
            int rowCount = dg.RowCount;
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    dg.Rows[j].Cells[i].Value = rand.Next(1, 4);
                }
        }

        /// <summary>
        /// Очищает матрицу
        /// </summary>
        /// <param name="dg"></param>
        private void clearMatrix(DataGridView dg)
        {
            //кешируем количество строк и столбцов грида
            int collCount = dg.ColumnCount;
            int rowCount = dg.RowCount;
            //зануляем все ячейки таблицы
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    dg.Rows[j].Cells[i].Value = 0;
                }
        }

        //заполняем случайными цифрами матрицу 2
        private void button6_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixTwo);
        }

        //кнопка очистки второй матрицы
        private void button4_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixTwo);
        }

        //кнопка сложения матриц
        private void bPlus_Click(object sender, EventArgs e)
        {
            if (summMatrix(matrixOne, matrixTwo) == null) return;
            Result f = new Result(summMatrix(matrixOne, matrixTwo), "сложения");
            f.ShowDialog();
        }

        /// <summary>
        /// Сложение матриц
        /// </summary>
        /// <param name="matr1"></param>
        /// <param name="matr2"></param>
        /// <returns></returns>
        private DataGridView summMatrix(DataGridView matr1, DataGridView matr2)
        {
            //осуществляем проверку
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц для сложения должна быть одинаковой!");
                return null;
            }




            //осуществляем сложение матриц
            int collCount = matr1.ColumnCount;
            int rowCount = matr1.RowCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = rowCount;
            dg.ColumnCount = collCount;
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                    dg.Rows[j].Cells[i].Value = Convert.ToDouble(matr1.Rows[j].Cells[i].Value) + Convert.ToDouble(matr2.Rows[j].Cells[i].Value);
            return dg;
        }

        /// <summary>
        /// Умножение матриц
        /// </summary>
        /// <param name="matr1"></param>
        /// <param name="matr2"></param>
        /// <returns></returns>
        private DataGridView multMatrix(DataGridView matr1, DataGridView matr2)
        {
            //осуществляем проверку
            if (matr1.ColumnCount != matr2.RowCount)
            {
                MessageBox.Show("Количество столбцов первой матрицы должнобыть равно количеству строк второй матрицы");
                return null;
            }

            //осуществляем умножение матриц
            int collCount = matr2.ColumnCount;
            int rowCount = matr1.RowCount;
            int rCount = matr1.ColumnCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = rowCount;
            dg.ColumnCount = collCount;
            for (int j = 0; j < collCount; j++)
                for (int i = 0; i < rowCount; i++)
                {
                    double temp = 0;
                    for (int r = 0; r < rCount; r++)
                        temp += Convert.ToDouble(matr1.Rows[j].Cells[r].Value) * Convert.ToDouble(matr2.Rows[r].Cells[i].Value);
                    dg.Rows[j].Cells[i].Value = temp;
                }
            return dg;
        }

        //кнопка умножения
        private void bMul_Click(object sender, EventArgs e)
        {
            if (multMatrix(matrixOne, matrixTwo) == null) return;//проверка выполняется ли умножение
            Result f = new Result(multMatrix(matrixOne, matrixTwo), "умножения");//передаем в конструктор новой формы грид и заголовок
            f.ShowDialog();
        }

        //кнопка нахождения определителя
        private void button2_Click(object sender, EventArgs e)
        {
            int collCount = matrixOne.ColumnCount;
            int rowCount = matrixOne.RowCount;
            //проверка на квадратность
            if (collCount != rowCount)
            {
                MessageBox.Show("Определитель можно находить только для квадратных матриц!");
                return;
            }
            //переносим данные из грида в массив
            double[,] matr = new double[collCount, rowCount];
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                    matr[i, j] = Convert.ToDouble(matrixOne.Rows[j].Cells[i].Value);
            //считаем функцией определитель и выводим 
            MessageBox.Show("Определитель равен: " + matrixDeterminant(matr, collCount).ToString());
        }

        /// <summary>
        /// Вычисляет минор для текущей матрицы
        /// </summary>
        /// <param name="matrix">Матрица для которой находится минор</param>
        /// <param name="m">размерность матрицы</param>
        /// <param name="i">Индекс столбца элемента по которому идет разложение</param>
        /// <param name="j">Инжекс строки элемента по которой идёт разложение</param>
        /// <returns>Минор матрицы</returns>
        private double[,] getMinor(double[,] matrix, int m, int i, int j)
        {
            int di = 0;
            double[,] b = new double[m, m];
            for (int ki = 0; ki < m - 1; ki++)
            {
                if (ki == i) di = 1;
                int dj = 0;
                for (int kj = 0; kj < m - 1; kj++)
                {
                    if (kj == j) dj = 1;
                    b[ki, kj] = matrix[ki + di, kj + dj];
                }
            }
            return b;
        }

        /// <summary>
        /// Рекурсивно вычисляет определитель для матрицы
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="n">Размерность матрицы</param>
        /// <returns>Опредилитель матрицы</returns>
        private double matrixDeterminant(double[,] matrix, int n)
        {
            double[,] b = new double[n, n];
            double d = 0, k = 1;
            if (n < 1) return 0;//если размерность матрицы = 0
            if (n == 1) d = matrix[0, 0]; //если размерность матрицы равна 1
            else if (n == 2) //если равна 2 используем стандартную формулу
            {
                d = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            }
            else //n>2 иначе рекурсивно делаем разложение по первой строке
                for (int i = 0; i < n; i++)
                {
                    b = getMinor(matrix, n, i, 0);//получаем минор для итого элемента первой строки
                    d += k * matrix[i, 0] * matrixDeterminant(b, n - 1);//вызываем рекурсивно функцию
                    k = -k;
                }
            return d;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (subMatrix(matrixOne, matrixTwo) == null) return;
            Result f = new Result(subMatrix(matrixOne, matrixTwo), "вычитания");
            f.ShowDialog();
        }
        /// <summary>
        /// вычитание
        /// </summary>
        /// <param name="matr1"></param>
        /// <param name="matr2"></param>
        /// <returns></returns>
        private DataGridView subMatrix(DataGridView matr1, DataGridView matr2)
        {
            //осуществляем проверку
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц для сложения должна быть одинаковой!");
                return null;
            }




            //осуществляем вычитание матриц
            int collCount = matr1.ColumnCount;
            int rowCount = matr1.RowCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = rowCount;
            dg.ColumnCount = collCount;
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                    dg.Rows[j].Cells[i].Value = Convert.ToDouble(matr1.Rows[j].Cells[i].Value) - Convert.ToDouble(matr2.Rows[j].Cells[i].Value);
            return dg;
        }

       
    }
    }


