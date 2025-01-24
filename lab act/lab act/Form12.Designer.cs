namespace lab_act
{
    partial class Form12
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
            label6 = new Label();
            label2 = new Label();
            button1 = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(343, 228);
            label6.Name = "label6";
            label6.Size = new Size(203, 41);
            label6.TabIndex = 69;
            label6.Text = "THANK YOU!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 283);
            label2.Name = "label2";
            label2.Size = new Size(247, 28);
            label2.TabIndex = 70;
            label2.Text = "We will contact you shortly";
            // 
            // button1
            // 
            button1.Location = new Point(290, 411);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 71;
            button1.Text = "Show Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(458, 411);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(162, 51);
            Exit.TabIndex = 72;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 617);
            Controls.Add(Exit);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEDICAL SURVEY";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private Button button1;
        private Button Exit;
    }
}