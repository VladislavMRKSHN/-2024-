using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixC_09._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Columns[j].Width = 60;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox2.Text, out n);
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Columns[j].Width = 60;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    int n;
                    int.TryParse(textBox2.Text, out n);
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] - b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Вычитать матрицы можно только одинаковой размерности.", "Ошибка!");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    int n;
                    int.TryParse(textBox2.Text, out n);
                    dataGridView3.RowCount = n;
                    dataGridView3.ColumnCount = n;
                    int[,] a = new int[n, n];
                    int[,] b = new int[n, n];
                    int[,] c = new int[n, n];
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            a[i, j] = Convert.ToInt32(dataGridView1[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            b[i, j] = Convert.ToInt32(dataGridView2[i, j].Value);
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                        {
                            c[i, j] = a[i, j] + b[i, j];
                            dataGridView3[i, j].Value = c[i, j];
                        }
                }
                else
                    MessageBox.Show("Складывать матрицы можно только одинаковой размерности.", "Ошибка!");
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                int n, v;
                int.TryParse(textBox2.Text, out n);
                dataGridView3.RowCount = n;
                dataGridView3.ColumnCount = n;
                int[,] a = new int[n, n];
                int[,] b = new int[n, n];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        a[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        b[j, i] = Convert.ToInt32(dataGridView2[i, j].Value);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        v = 0;
                        for (int r = 0; r < n; r++)
                            v += a[i, r] * b[r, j];
                        dataGridView3[i, j].Value = v;

                    }
                }
            }

            else
                MessageBox.Show("Умножать матрицы можно только одинаковой размерности.", "Ошибка!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}