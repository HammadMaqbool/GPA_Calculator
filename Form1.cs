using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        double _GPA;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About Obj = new About();
            Obj.Show();
        }

        private void Subject_Click(object sender, EventArgs e)
        {

        }
        private double GPA_Method(double Marks_Input)
        {

            if (Marks_Input >= 75 && Marks_Input <77.25)
            {
                _GPA = 2.0;
            }
            else if (Marks_Input >= 77.25 && Marks_Input < 79.5)
            {
                _GPA = 2.1;
            }
            else if (Marks_Input >= 79.5 && Marks_Input < 81.75)
            {
                _GPA = 2.2;
            }
            else if (Marks_Input >= 81.75 && Marks_Input < 84)
            {
                _GPA = 2.3;
            }
            else if (Marks_Input >= 84 && Marks_Input < 86.25)
            {
                _GPA = 2.4;
            }
            else if (Marks_Input >= 86.25 && Marks_Input < 88.5)
            {
                _GPA = 2.5;
            }
            else if (Marks_Input >= 88.5 && Marks_Input <90.75)
            {
                _GPA = 2.6;
            } 
            else if (Marks_Input >= 90.75 && Marks_Input <93)
            {
                _GPA = 2.7;
            }
            else if (Marks_Input >= 93 && Marks_Input < 95.25)
            {
                _GPA = 2.8;
            }
            else if (Marks_Input >= 95.25 && Marks_Input < 97.5)
            {
                _GPA = 2.9;
            }
            else if (Marks_Input >= 97.5 && Marks_Input <99.75)
            {
                _GPA = 3.0;
            }
            else if (Marks_Input >= 99.75 && Marks_Input < 102)
            {
                _GPA = 3.1;
            }
            else if (Marks_Input >= 102 && Marks_Input < 104.25)
            {
                _GPA = 3.2;
            }
            else if (Marks_Input >= 104.25 && Marks_Input < 106.5)
            {
                _GPA = 3.3;
            }
            else if (Marks_Input >= 106.5 && Marks_Input < 108.75)
            {
                _GPA = 3.4;
            }
            else if (Marks_Input >= 108.75 && Marks_Input < 108.75)
            {
                _GPA = 3.5;
            }
            else if (Marks_Input >= 108.75 && Marks_Input < 111)
            {
                _GPA = 3.6;
            }
            else if (Marks_Input >= 111 && Marks_Input < 113.25)
            {
                _GPA = 3.7;
            }
            else if (Marks_Input >= 113.25 && Marks_Input <115.5)
            {
                _GPA = 3.8;
            }
            else if (Marks_Input >= 115.5 && Marks_Input < 117.75)
            {
                _GPA = 3.9;
            }
            else if (Marks_Input >= 117.75 && Marks_Input < 120)
            {
                _GPA = 4.0;
            }
            else if (Marks_Input >= 120)
            {
                _GPA = 4.0;
            }
            return _GPA;
        }

        private void Sub_Calculate_Click(object sender, EventArgs e)
        {

           double temp = GPA_Method(Convert.ToDouble(Sub_Number.Text));
           Sub_GPA.Text = Convert.ToString(temp);
            
        }
        private void Semester_GPA()
        {
            try
            {
                double f1, f2, f3, f4, f5, f6;
                double temp11, temp2, temp3, temp4, temp5, temp6;
                double crdt1, crdt2, crdt3, crdt4, crdt5, crdt6;

                temp11 = Convert.ToDouble(sub1_mark.Text);
                temp2 = Convert.ToDouble(sub2_mark.Text);
                temp3 = Convert.ToDouble(sub3_mark.Text);
                temp4 = Convert.ToDouble(sub4_mark.Text);
                temp5 = Convert.ToDouble(sub5_mark.Text);
                temp6 = Convert.ToDouble(sub6_mark.Text);

                crdt1 = Convert.ToDouble(crdt_hrz1.Text);
                crdt2 = Convert.ToDouble(crdt_hrz2.Text);
                crdt3 = Convert.ToDouble(crdt_hrz3.Text);
                crdt4 = Convert.ToDouble(crdt_hrz4.Text);
                crdt5 = Convert.ToDouble(crdt_hrz5.Text);
                crdt6 = Convert.ToDouble(crdt_hrz6.Text);

                f1 = temp11 * crdt1;
                f2 = temp2 * crdt2;
                f3 = temp3 * crdt3;
                f4 = temp4 * crdt4;
                f5 = temp5 * crdt5;
                f6 = temp6 * crdt6;

                double Total_SubjectGPA = f1 + f2 + f3 + f4 + f5 + f6;
                double TotalCreadit_hrz = crdt1 + crdt2 + crdt3 + crdt4 + crdt5 + crdt6;
                double Final_Result = Total_SubjectGPA / TotalCreadit_hrz;

                finalGPA.Text = Convert.ToString(Final_Result);
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid Data or No Data Enter!");
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Semester_GPA();
        }

        private void Semestr_Click(object sender, EventArgs e)
        {

        }
    }
}
