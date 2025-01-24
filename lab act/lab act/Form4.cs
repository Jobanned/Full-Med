using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab_act
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Visible = false;

            string height, weight, bmi, value;
            string smoke = " ", exercise = " ", sleep = " ";

            height = textBox5.Text;
            weight = textBox1.Text;
            bmi = textBox2.Text;
            value = textBox3.Text;

            if (radioButton5.Checked)
            { smoke = radioButton5.Text; }
            else if (radioButton2.Checked)
            { smoke = radioButton2.Text; }
            else if (radioButton3.Checked)
            { smoke = radioButton3.Text; }
            else if (radioButton1.Checked)
            { smoke = radioButton1.Text; }

            if (radioButton10.Checked)
            { exercise = radioButton10.Text; }
            else if (radioButton8.Checked)
            { exercise = radioButton8.Text; }
            else if (radioButton9.Checked)
            { exercise = radioButton9.Text; }
            else if (radioButton7.Checked)
            { exercise = radioButton7.Text; }

            if (radioButton14.Checked)
            { sleep = radioButton14.Text; }
            else if (radioButton12.Checked)
            { sleep = radioButton12.Text; }
            else if (radioButton15.Checked)
            { sleep = radioButton15.Text; }
            else if (radioButton13.Checked)
            { sleep = radioButton13.Text; }
            else if (radioButton11.Checked)
            { sleep = radioButton11.Text; }

            string result = $"Height: {height}, Weight: {weight}, BMI: {bmi}, BMI Value you want to maintain: {value}, " +
                $"Smoking Status: {smoke}, Exercise Habits: {exercise}, Sleep Habits: {sleep}";

            SharedData.Results.Add(result);
        }

    }
}
