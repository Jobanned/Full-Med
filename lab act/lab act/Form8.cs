using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_act
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            Visible = false;

            string otherstress;
            string stresslevel = " ";

            otherstress = textBox2.Text;

            if (radioButton20.Checked)
            { stresslevel = radioButton20.Text; }
            else if (radioButton19.Checked)
            { stresslevel = radioButton19.Text; }
            else if (radioButton18.Checked)
            { stresslevel = radioButton18.Text; }
            else if (radioButton17.Checked)
            { stresslevel = radioButton17.Text; }
            else if (radioButton16.Checked)
            { stresslevel = radioButton16.Text; }

            string result = $"Other Sources of Stress: {otherstress}, Overall Stress Level: {stresslevel}";
            SharedData.Results.Add(result);
        }
    }
}
