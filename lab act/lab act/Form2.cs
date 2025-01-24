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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Visible = false;

            string month, day, year, age, gender;
            string contact = ", ";

            if (checkBox1.Checked)
            { contact = checkBox1.Text; }
            else if (checkBox2.Checked)
            { contact = checkBox2.Text; }
            else if (checkBox4.Checked)
            { contact = checkBox4.Text; }
            else if (checkBox3.Checked)
            { contact = checkBox3.Text; }

            age = textBox3.Text;
            year = textBox1.Text;
            month = listBox1.GetItemText(listBox1.SelectedItem);
            day = listBox2.GetItemText(listBox2.SelectedItem);
            gender = listBox3.GetItemText(listBox3.SelectedItem);

            string result = $"Age: {age}, Birthdate: {month} {day}, {year}, Gender: {gender}, Contact Method: {contact}";
            SharedData.Results.Add(result);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month;
            month = listBox1.GetItemText(listBox1.SelectedItem);
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string day;
            day = listBox2.GetItemText(listBox2.SelectedItem);
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gender;
            gender = listBox3.GetItemText(listBox3.SelectedItem);
        }
    }
}
