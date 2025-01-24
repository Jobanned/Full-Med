namespace lab_act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;

            string firstname, lastname, date, email, number, address1, address2, city, province, postal;
            firstname = textBox1.Text;
            lastname = textBox11.Text;
            date = textBox2.Text;
            email = textBox3.Text;
            number = textBox4.Text;
            address1 = textBox5.Text;
            address2 = textBox6.Text;
            city = textBox7.Text;
            province = textBox8.Text;
            postal = textBox9.Text;

            string result = $"Date: {date}, Name: {firstname} {lastname},  Email: {email}, " +
                            $"Phone: {number}, Address: {address1}/ {address2}, {city}, {province}, {postal}";

            SharedData.Results.Add(result);
        }

    }
}
