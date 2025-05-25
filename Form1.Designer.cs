namespace Makgopa_Leonard_PRG262_ST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(211, 29);
            label1.Name = "label1";
            label1.Size = new Size(340, 38);
            label1.TabIndex = 0;
            label1.Text = "Netcare Hospital Akasia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(217, 20);
            label2.TabIndex = 1;
            label2.Text = "Register/Update Patient Details";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 156);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "PatientID:";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 189);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 4;
            label5.Text = "Patient Surname:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 186);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(113, 222);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 6;
            label7.Text = "Phone:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 334);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 7;
            label8.Text = "Delete Patient:";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 156);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 8;
            label4.Text = "Patient Name:";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 9;
            textBox1.Text = "PatientID";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(503, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 27);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(503, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 27);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(172, 222);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 27);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(503, 222);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 14;
            button1.Text = "Register Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(172, 274);
            button2.Name = "button2";
            button2.Size = new Size(191, 29);
            button2.TabIndex = 15;
            button2.Text = "Update Details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(415, 274);
            button3.Name = "button3";
            button3.Size = new Size(191, 29);
            button3.TabIndex = 16;
            button3.Text = "Search Patient";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(113, 373);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(351, 27);
            textBox6.TabIndex = 17;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(503, 373);
            button4.Name = "button4";
            button4.Size = new Size(191, 29);
            button4.TabIndex = 18;
            button4.Text = "Delete Patient";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(315, 451);
            button5.Name = "button5";
            button5.Size = new Size(195, 29);
            button5.TabIndex = 19;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 492);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Netcare Hospital Akasia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // labels
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        // textboxes
        private TextBox PatientID;
        private TextBox FirstName;
        private TextBox LastName;
        private TextBox Diagnosis;
        private TextBox DoctorName;
        private TextBox NotesOrDate;

        // buttons
        private Button Add
        private Button Clear;
        private Button Save;
        private Button Load;
        private Button Search;
    }
}