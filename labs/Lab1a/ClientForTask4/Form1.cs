using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForTask4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            if (int.TryParse(textBox1.Text, out int x) && int.TryParse(textBox2.Text, out int y))
            {
                try
                {
                    int sum = await GetSum(x, y);
                    label3.Text = $"Сумма: {sum}";
                }
                catch (Exception ex)
                {
                    label3.Text = $"Ошибка: {ex.Message}";
                }
            }
            else
            {
                label3.Text = "введите корректные числа.";
            }
        }

        private async Task<int> GetSum(int x, int y)
        {
            int sum;

            string url = $"https://localhost:7185/add?ParmX={x}&ParmY={y}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(url, null);
                response.EnsureSuccessStatusCode();

                string responseText = await response.Content.ReadAsStringAsync();
                sum = int.Parse(responseText);
            }

            return sum;
        }
    }
}
