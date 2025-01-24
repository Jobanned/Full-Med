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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            Visible = false;

            string bed, wake, hours, sleep;
            string feeling = " ";

            sleep = textBox1.Text;
            bed = textBox2.Text;
            wake = textBox3.Text;
            hours = textBox4.Text;

            if (radioButton6.Checked)
            { feeling = radioButton6.Text; }
            else if (radioButton5.Checked)
            { feeling = radioButton5.Text; }
            else if (radioButton1.Checked)
            { feeling = radioButton1.Text; }

            string result = $"Quality of sleep: {sleep}, Bedtime: {bed}, Wake Time: {wake}, Hours of sleep: {hours}, Feeling: {feeling}";

            SharedData.Results.Add(result);
        }
    }
}
