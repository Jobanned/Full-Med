using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_act
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Visible = false;

            string illness = " ", med = " ", preg = " ", nursing = " ", allergies = " ";

            if (checkBox1.Checked)
            { illness = checkBox1.Text; }
            else if (checkBox2.Checked)
            { illness = checkBox2.Text; }
            else if (checkBox4.Checked)
            { illness = checkBox4.Text; }
            else if (checkBox3.Checked)
            { illness = checkBox3.Text; }

            if (checkBox8.Checked)
            { med = checkBox8.Text; }
            else if (checkBox7.Checked)
            { med = checkBox7.Text; }
            else if (checkBox9.Checked)
            { med = checkBox9.Text; }
            else if (checkBox6.Checked)
            { med = checkBox6.Text; }
            else if (checkBox5.Checked)
            { med = checkBox5.Text; }
            else if (checkBox10.Checked)
            { med = checkBox10.Text; }

            if (radioButton1.Checked)
            { preg = radioButton1.Text; }
            else if (radioButton2.Checked)
            { preg = radioButton2.Text; }

            if (radioButton3.Checked)
            { nursing = radioButton3.Text; }
            else if (radioButton4.Checked)
            { nursing = radioButton4.Text; }

            if (radioButton7.Checked)
            { allergies = radioButton7.Text; }
            else if (radioButton8.Checked)
            { allergies = radioButton8.Text; }

            string result = $"Illness: {illness}, Medications: {med}, Pregnancy(Female): {preg}, Nursing(Female): {nursing}, Allergies: {allergies}";
            SharedData.Results.Add(result);
        }
    }
}
