using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weigth = double.Parse(textBox2.Text);
            double heigth = double.Parse(textBox1.Text);  
            double bmi = (weigth / (heigth*heigth)) * 10000;

            if (bmi > 40.0) 
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Obesity class |||";
            }

            if(bmi >= 35 && bmi <= 40)
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Obesity class ||";
            }

            if(bmi >= 30 && bmi < 35)
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Obesity class |";
            }

            if(bmi >= 25 && bmi < 30)
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Overweigth.";
            }

            if (bmi >= 18.5 && bmi < 25)
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Normal weigth.";
            }

            if (bmi < 18.5)
            {
                label5.Text = $"{textBox3.Text.ToUpper()} your BMI is {String.Format("{0:0.00}", bmi)}\nYou are Underweigth.";
            }      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            label5.Text = "................";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
