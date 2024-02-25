using System.Security.Cryptography.Xml;

namespace DZ_26_02_2014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LB1.Items.Insert(0, "Лабораторная Безиков");
            LB1.Items.Insert(1, $"X =");
            LB1.Items.Insert(2, $"Y =");
            LB1.Items.Insert(3, $"Z =");
            LB1.Items.Insert(4, $"Результат w =");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TB1.Text);
            double y = Convert.ToDouble(TB2.Text);
            double z = Convert.ToDouble(TB3.Text);
            double w = Math.Abs(Math.Cos(x) - Math.Cos(y));
            w = Math.Pow(w, 1 + 2 * Math.Pow(Math.Sin(y), 2));
            w = w * (1 + z + Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);
            LB1.Items.Clear();
            LB1.Items.Insert(0, "Лабораторная Безиков");
            LB1.Items.Insert(1, $"X = {x}");
            LB1.Items.Insert(2, $"Y = {y}");
            LB1.Items.Insert(3, $"Z = {z}");
            LB1.Items.Insert(4, $"Результат w = {w}");
        }
    }
}