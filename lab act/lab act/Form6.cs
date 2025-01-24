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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Visible = false;

            string water, coffee, alcohol, exercise, kind;

            water = textBox5.Text;
            coffee = textBox6.Text;
            alcohol = textBox1.Text;
            exercise = textBox2.Text;
            kind = textBox4.Text;

            string result = $"Water Intake: {water}, Coffee Intake: {coffee}, Alcohol Consumption: {alcohol}, " +
                $"Exercise Frequency: {exercise}, Type of Exercise: {kind}";

            SharedData.Results.Add(result);
        }
    }
}
