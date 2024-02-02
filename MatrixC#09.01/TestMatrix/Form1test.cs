using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using MatrixC_09._01; // Используйте ваше пространство имен

namespace UnitTest1.cs
{
    [TestClass]
    public class Form1Tests
    {
        private Form1 form;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
            textBox1 = (TextBox)form.Controls["textBox1"];
            textBox2 = (TextBox)form.Controls["textBox2"];
            dataGridView1 = (DataGridView)form.Controls["dataGridView1"];
            dataGridView2 = (DataGridView)form.Controls["dataGridView2"];
            dataGridView3 = (DataGridView)form.Controls["dataGridView3"];
        }

        private void FillDataGridView(DataGridView dgv, int[,] values)
        {
            int rows = values.GetLength(0);
            int cols = values.GetLength(1);
            dgv.RowCount = rows;
            dgv.ColumnCount = cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dgv.Rows[i].Cells[j].Value = values[i, j];
                }
            }
        }

        private void CheckDataGridViewValues(DataGridView dgv, int[,] expectedValues)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    Assert.AreEqual(expectedValues[i, j], dgv.Rows[i].Cells[j].Value);
                }
            }
        }

        [TestMethod]
        public void TestButton3Click_PerformsMatrixSubtraction()
        {
            textBox1.Text = "3";
            textBox2.Text = "3";
            form.button1_Click_1(null, EventArgs.Empty);
            form.button2_Click(null, EventArgs.Empty);

            int[,] matrixAValues = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int[,] matrixBValues = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };
            FillDataGridView(dataGridView1, matrixAValues);
            FillDataGridView(dataGridView2, matrixBValues);

            form.button3_Click(null, EventArgs.Empty);

            int[,] expectedSubtractionResult = { { 5, 15, 25 }, { 35, 45, 55 }, { 65, 75, 85 } };
            CheckDataGridViewValues(dataGridView3, expectedSubtractionResult);
        }

        [TestMethod]
        public void TestButton4Click_PerformsMatrixAddition()
        {
            // Имитация ввода и проверка сложения матриц
            textBox1.Text = "3";
            textBox2.Text = "3";
            form.button1_Click_1(null, EventArgs.Empty);
            form.button2_Click(null, EventArgs.Empty);

            int[,] matrixAValues = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixBValues = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            FillDataGridView(dataGridView1, matrixAValues);
            FillDataGridView(dataGridView2, matrixBValues);

            form.button4_Click(null, EventArgs.Empty);

            int[,] expectedValues = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            CheckDataGridViewValues(dataGridView3, expectedValues);
        }

        [TestMethod]
        public void TestButton5Click_PerformsMatrixMultiplication()
        {
            // Имитация ввода и проверка умножения матриц
            textBox1.Text = "3";
            textBox2.Text = "3";
            form.button1_Click_1(null, EventArgs.Empty);
            form.button2_Click(null, EventArgs.Empty);

            int[,] matrixAValues = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrixBValues = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            FillDataGridView(dataGridView1, matrixAValues);
            FillDataGridView(dataGridView2, matrixBValues);

            form.button5_Click(null, EventArgs.Empty);


            // Предполагаемый результат умножения матриц
            int[,] expectedMultiplicationResult = { { 30, 24, 18 }, { 84, 69, 54 }, { 138, 114, 90 } };
            CheckDataGridViewValues(dataGridView3, expectedMultiplicationResult);
        }
    }
}
