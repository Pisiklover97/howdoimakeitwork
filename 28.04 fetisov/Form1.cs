using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._04_fetisov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] arr = new int[100, 100];



        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    arr[i, j] = rnd.Next(-50, 50);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < m; j++)
                    if (arr[i, j] < min)
                        min = arr[i, j];
                listBox1.Items.Add(min.ToString() + " Строки " + i.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum = sum+ arr[i, i];
            textBox3.Text = sum.ToString();
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
