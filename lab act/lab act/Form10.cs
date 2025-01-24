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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            Visible = false;

            string current, goal, height, losing;
            string plan = " ";
            
            current = textBox5.Text;
            goal = textBox4.Text;
            height = textBox1.Text;
            losing = textBox3.Text;

            if(radioButton6.Checked)
            { plan = radioButton6.Text; }
            else if (radioButton4.Checked)
            { plan = radioButton4.Text; }

            string result = $"Current Weight: {current}, Goal Weight: {goal}, Height: {height}, " +
                   $"Weight Loss Target: {losing}, Most difficult part of losing weight in the past: {plan}";

            SharedData.Results.Add(result);
        }
    }
}
