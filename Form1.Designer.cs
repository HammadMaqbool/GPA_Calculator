namespace GPA_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UMSIT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Subject = new System.Windows.Forms.TabPage();
            this.Semestr = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Sub_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sub_Calculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Sub_GPA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sub1_mark = new System.Windows.Forms.TextBox();
            this.crdt_hrz1 = new System.Windows.Forms.TextBox();
            this.crdt_hrz2 = new System.Windows.Forms.TextBox();
            this.sub2_mark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.crdt_hrz3 = new System.Windows.Forms.TextBox();
            this.sub3_mark = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.crdt_hrz4 = new System.Windows.Forms.TextBox();
            this.sub4_mark = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.crdt_hrz5 = new System.Windows.Forms.TextBox();
            this.sub5_mark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.crdt_hrz6 = new System.Windows.Forms.TextBox();
            this.sub6_mark = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.finalGPA = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Subject.SuspendLayout();
            this.Semestr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kotli Azad Kashmir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject, Semesster GPA and CGPA Calculator";
            // 
            // UMSIT
            // 
            this.UMSIT.AutoSize = true;
            this.UMSIT.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UMSIT.Location = new System.Drawing.Point(133, 15);
            this.UMSIT.Name = "UMSIT";
            this.UMSIT.Size = new System.Drawing.Size(531, 24);
            this.UMSIT.TabIndex = 5;
            this.UMSIT.Text = "University of Management Sciences and Information Technology";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(589, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Subject);
            this.tabControl1.Controls.Add(this.Semestr);
            this.tabControl1.Location = new System.Drawing.Point(5, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 246);
            this.tabControl1.TabIndex = 10;
            // 
            // Subject
            // 
            this.Subject.BackColor = System.Drawing.Color.Silver;
            this.Subject.Controls.Add(this.Sub_GPA);
            this.Subject.Controls.Add(this.label5);
            this.Subject.Controls.Add(this.Sub_Calculate);
            this.Subject.Controls.Add(this.label4);
            this.Subject.Controls.Add(this.Sub_Number);
            this.Subject.Controls.Add(this.label3);
            this.Subject.Location = new System.Drawing.Point(4, 22);
            this.Subject.Name = "Subject";
            this.Subject.Padding = new System.Windows.Forms.Padding(3);
            this.Subject.Size = new System.Drawing.Size(644, 220);
            this.Subject.TabIndex = 0;
            this.Subject.Text = "Subject GPA Calculator";
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            // 
            // Semestr
            // 
            this.Semestr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Semestr.Controls.Add(this.finalGPA);
            this.Semestr.Controls.Add(this.label18);
            this.Semestr.Controls.Add(this.button3);
            this.Semestr.Controls.Add(this.crdt_hrz6);
            this.Semestr.Controls.Add(this.sub6_mark);
            this.Semestr.Controls.Add(this.label16);
            this.Semestr.Controls.Add(this.label17);
            this.Semestr.Controls.Add(this.crdt_hrz5);
            this.Semestr.Controls.Add(this.sub5_mark);
            this.Semestr.Controls.Add(this.label14);
            this.Semestr.Controls.Add(this.label15);
            this.Semestr.Controls.Add(this.crdt_hrz4);
            this.Semestr.Controls.Add(this.sub4_mark);
            this.Semestr.Controls.Add(this.label12);
            this.Semestr.Controls.Add(this.label13);
            this.Semestr.Controls.Add(this.crdt_hrz3);
            this.Semestr.Controls.Add(this.sub3_mark);
            this.Semestr.Controls.Add(this.label10);
            this.Semestr.Controls.Add(this.label11);
            this.Semestr.Controls.Add(this.crdt_hrz2);
            this.Semestr.Controls.Add(this.sub2_mark);
            this.Semestr.Controls.Add(this.label8);
            this.Semestr.Controls.Add(this.label9);
            this.Semestr.Controls.Add(this.crdt_hrz1);
            this.Semestr.Controls.Add(this.sub1_mark);
            this.Semestr.Controls.Add(this.label7);
            this.Semestr.Controls.Add(this.label6);
            this.Semestr.Location = new System.Drawing.Point(4, 22);
            this.Semestr.Name = "Semestr";
            this.Semestr.Padding = new System.Windows.Forms.Padding(3);
            this.Semestr.Size = new System.Drawing.Size(644, 220);
            this.Semestr.TabIndex = 1;
            this.Semestr.Text = "Semesster GPA Calculator";
            this.Semestr.Click += new System.EventHandler(this.Semestr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Your Subject Marks to Calculate GPA";
            // 
            // Sub_Number
            // 
            this.Sub_Number.Location = new System.Drawing.Point(284, 57);
            this.Sub_Number.Name = "Sub_Number";
            this.Sub_Number.Size = new System.Drawing.Size(198, 20);
            this.Sub_Number.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject Marks :";
            // 
            // Sub_Calculate
            // 
            this.Sub_Calculate.Location = new System.Drawing.Point(284, 99);
            this.Sub_Calculate.Name = "Sub_Calculate";
            this.Sub_Calculate.Size = new System.Drawing.Size(90, 27);
            this.Sub_Calculate.TabIndex = 11;
            this.Sub_Calculate.Text = "Calculate";
            this.Sub_Calculate.UseVisualStyleBackColor = true;
            this.Sub_Calculate.Click += new System.EventHandler(this.Sub_Calculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your Subject GPA is :";
            // 
            // Sub_GPA
            // 
            this.Sub_GPA.AutoSize = true;
            this.Sub_GPA.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub_GPA.Location = new System.Drawing.Point(384, 141);
            this.Sub_GPA.Name = "Sub_GPA";
            this.Sub_GPA.Size = new System.Drawing.Size(35, 24);
            this.Sub_GPA.TabIndex = 13;
            this.Sub_GPA.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subject 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Creadit Hour 1";
            // 
            // sub1_mark
            // 
            this.sub1_mark.Location = new System.Drawing.Point(71, 13);
            this.sub1_mark.Name = "sub1_mark";
            this.sub1_mark.Size = new System.Drawing.Size(104, 20);
            this.sub1_mark.TabIndex = 10;
            // 
            // crdt_hrz1
            // 
            this.crdt_hrz1.Location = new System.Drawing.Point(293, 12);
            this.crdt_hrz1.Name = "crdt_hrz1";
            this.crdt_hrz1.Size = new System.Drawing.Size(101, 20);
            this.crdt_hrz1.TabIndex = 11;
            // 
            // crdt_hrz2
            // 
            this.crdt_hrz2.Location = new System.Drawing.Point(293, 40);
            this.crdt_hrz2.Name = "crdt_hrz2";
            this.crdt_hrz2.Size = new System.Drawing.Size(101, 20);
            this.crdt_hrz2.TabIndex = 15;
            // 
            // sub2_mark
            // 
            this.sub2_mark.Location = new System.Drawing.Point(71, 41);
            this.sub2_mark.Name = "sub2_mark";
            this.sub2_mark.Size = new System.Drawing.Size(104, 20);
            this.sub2_mark.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Creadit Hour 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Subject 2";
            // 
            // crdt_hrz3
            // 
            this.crdt_hrz3.Location = new System.Drawing.Point(293, 68);
            this.crdt_hrz3.Name = "crdt_hrz3";
            this.crdt_hrz3.Size = new System.Drawing.Size(101, 20);
            this.crdt_hrz3.TabIndex = 19;
            // 
            // sub3_mark
            // 
            this.sub3_mark.Location = new System.Drawing.Point(71, 69);
            this.sub3_mark.Name = "sub3_mark";
            this.sub3_mark.Size = new System.Drawing.Size(104, 20);
            this.sub3_mark.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Creadit Hour 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Subject 3";
            // 
            // crdt_hrz4
            // 
            this.crdt_hrz4.Location = new System.Drawing.Point(294, 97);
            this.crdt_hrz4.Name = "crdt_hrz4";
            this.crdt_hrz4.Size = new System.Drawing.Size(100, 20);
            this.crdt_hrz4.TabIndex = 23;
            // 
            // sub4_mark
            // 
            this.sub4_mark.Location = new System.Drawing.Point(71, 97);
            this.sub4_mark.Name = "sub4_mark";
            this.sub4_mark.Size = new System.Drawing.Size(104, 20);
            this.sub4_mark.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(199, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Creadit Hour 4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Subject 4";
            // 
            // crdt_hrz5
            // 
            this.crdt_hrz5.Location = new System.Drawing.Point(293, 124);
            this.crdt_hrz5.Name = "crdt_hrz5";
            this.crdt_hrz5.Size = new System.Drawing.Size(101, 20);
            this.crdt_hrz5.TabIndex = 27;
            // 
            // sub5_mark
            // 
            this.sub5_mark.Location = new System.Drawing.Point(71, 125);
            this.sub5_mark.Name = "sub5_mark";
            this.sub5_mark.Size = new System.Drawing.Size(104, 20);
            this.sub5_mark.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(198, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Creadit Hour 5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Subject 5";
            // 
            // crdt_hrz6
            // 
            this.crdt_hrz6.Location = new System.Drawing.Point(294, 153);
            this.crdt_hrz6.Name = "crdt_hrz6";
            this.crdt_hrz6.Size = new System.Drawing.Size(100, 20);
            this.crdt_hrz6.TabIndex = 31;
            // 
            // sub6_mark
            // 
            this.sub6_mark.Location = new System.Drawing.Point(71, 153);
            this.sub6_mark.Name = "sub6_mark";
            this.sub6_mark.Size = new System.Drawing.Size(104, 20);
            this.sub6_mark.TabIndex = 30;
            this.sub6_mark.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(199, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Creadit Hour 6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Subject 6";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(430, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 26);
            this.label18.TabIndex = 32;
            this.label18.Text = "Your Semesster GPA is";
            // 
            // finalGPA
            // 
            this.finalGPA.AutoSize = true;
            this.finalGPA.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalGPA.Location = new System.Drawing.Point(484, 69);
            this.finalGPA.Name = "finalGPA";
            this.finalGPA.Size = new System.Drawing.Size(62, 41);
            this.finalGPA.TabIndex = 33;
            this.finalGPA.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(472, 124);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(186, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Note:- For 150 Marking Scheme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(666, 402);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UMSIT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Subject.ResumeLayout(false);
            this.Subject.PerformLayout();
            this.Semestr.ResumeLayout(false);
            this.Semestr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UMSIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Subject;
        private System.Windows.Forms.TabPage Semestr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sub_GPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sub_Calculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sub_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox crdt_hrz6;
        private System.Windows.Forms.TextBox sub6_mark;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox crdt_hrz5;
        private System.Windows.Forms.TextBox sub5_mark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox crdt_hrz4;
        private System.Windows.Forms.TextBox sub4_mark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox crdt_hrz3;
        private System.Windows.Forms.TextBox sub3_mark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox crdt_hrz2;
        private System.Windows.Forms.TextBox sub2_mark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox crdt_hrz1;
        private System.Windows.Forms.TextBox sub1_mark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label finalGPA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
    }
}

