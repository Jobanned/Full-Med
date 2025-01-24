namespace lab_act
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label6 = new Label();
            radioButton1 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(45, 215);
            label12.Name = "label12";
            label12.Size = new Size(448, 28);
            label12.TabIndex = 39;
            label12.Text = "On average, how many hours of sleep do you get?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(497, 112);
            label11.Name = "label11";
            label11.Size = new Size(306, 28);
            label11.TabIndex = 37;
            label11.Text = "In general, when do you wake up?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(40, 112);
            label10.Name = "label10";
            label10.Size = new Size(350, 28);
            label10.TabIndex = 35;
            label10.Text = "In general,  at what time do go to bed?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label9.Location = new Point(40, 43);
            label9.Name = "label9";
            label9.Size = new Size(95, 41);
            label9.TabIndex = 33;
            label9.Text = "Sleep";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(202, 78);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(52, 24);
            radioButton5.TabIndex = 42;
            radioButton5.TabStop = true;
            radioButton5.Text = "NO";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(202, 27);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(54, 24);
            radioButton6.TabIndex = 41;
            radioButton6.TabStop = true;
            radioButton6.Text = "YES";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 332);
            label6.Name = "label6";
            label6.Size = new Size(285, 28);
            label6.TabIndex = 40;
            label6.Text = "Do you wake up feeling rested?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(479, 27);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 43;
            radioButton1.TabStop = true;
            radioButton1.Text = "OTHER";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 504);
            label1.Name = "label1";
            label1.Size = new Size(295, 28);
            label1.TabIndex = 44;
            label1.Text = "How is the quality of your sleep?";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(45, 536);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(822, 190);
            textBox1.TabIndex = 45;
            // 
            // button1
            // 
            button1.Location = new Point(721, 795);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 46;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(45, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 125);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(45, 144);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 43);
            textBox2.TabIndex = 128;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(502, 144);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 43);
            textBox3.TabIndex = 129;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(45, 247);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(457, 43);
            textBox4.TabIndex = 130;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 867);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEDICAL SURVEY";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label6;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}