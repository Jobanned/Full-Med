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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_act
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            Visible = false;

            string first, last, perday, snack;
            string often = " ";

            first = textBox5.Text;
            last = textBox1.Text;
            perday = textBox4.Text;
            snack = textBox3.Text;

            if (radioButton6.Checked)
            { often = radioButton6.Text; }
            else if (radioButton5.Checked)
            { often = radioButton5.Text; }
            else if (radioButton4.Checked)
            { often = radioButton4.Text; }
            else if (radioButton2.Checked)
            { often = radioButton2.Text; }
            else if (radioButton1.Checked)
            { often = radioButton1.Text; }
            else if (radioButton3.Checked)
            { often = radioButton3.Text; }

            string result = $"First Meal: {first}, Last Meal: {last}, Meals Per Day: {perday}, Snack Preference: {snack}, Eating Frequency: {often}";

            SharedData.Results.Add(result);
        }
    }
}
