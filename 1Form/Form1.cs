using System;
using System.Windows.Forms;

namespace _1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findRadius(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && Сheck(textBox1.Text))
            {
                textBox2.Text = Convert.ToString(GetRadius
                    (Convert.ToDouble(textBox1.Text)));
            }
        }
        private bool Сheck(String s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!char.IsDigit(arr[i]) && arr[i] == '-' && arr[i] != ',')
                {
                    return false;
                }
            }
            return true;
        }
        private double GetRadius(double a)
        {
            return (a * Math.Sqrt(3)) / 3;
        }

        private void CheckTriangle(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && Сheck(textBox3.Text) &&
                textBox4.Text != "" && Сheck(textBox4.Text) &&
                textBox5.Text != "" && Сheck(textBox5.Text))
            {
                textBox6.Text = Check(Convert.ToDouble(textBox3.Text),
                    Convert.ToDouble(textBox4.Text),
                    Convert.ToDouble(textBox5.Text));
            }
        }
        private String Check(double a, double b, double c)
        {
            if (a * a + b * b == c * c) return "Треугольник прямоугольный";
            return "Треугольник не прямоугольный";
        }
    }
}
