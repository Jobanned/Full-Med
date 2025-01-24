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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            Visible = false;

            string likes, work, enjoy;
            string level = " ";

            likes = textBox4.Text;
            work = textBox5.Text;
            enjoy = textBox2.Text;

            if (radioButton1.Checked)
            { level = radioButton1.Text; }
            else if (radioButton2.Checked)
            { level = radioButton2.Text; }
            else if (radioButton3.Checked)
            { level = radioButton3.Text; }
            else if (radioButton4.Checked)
            { level = radioButton4.Text; }
            else if (radioButton5.Checked)
            { level = radioButton5.Text; }
            else if (radioButton6.Checked)
            { level = radioButton6.Text; }
            else if (radioButton7.Checked)
            { level = radioButton7.Text; }
            else if (radioButton8.Checked)
            { level = radioButton8.Text; }
            else if (radioButton9.Checked)
            { level = radioButton9.Text; }
            else if (radioButton10.Checked)
            { level = radioButton10.Text; }

            string result = $"Things you like but unable to do: {likes}, Daily Energy Level: {level}, Your Work: {work}, Enjoyment: {enjoy}";

            // Add to shared results
            SharedData.Results.Add(result);
        }

    }
}
