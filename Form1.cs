using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Grade = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get grades
            Int32 comp1030 = Convert.ToInt32(txtCOMP1030.Text);
            Int32 comp1002 = Convert.ToInt32(txtCOMP1002.Text);
            Int32 comp1051 = Convert.ToInt32(txtCOMP1051.Text);
            Int32 comp1053 = Convert.ToInt32(txtCOMP1053.Text);
            Int32 comm1016 = Convert.ToInt32(txtCOMM1016.Text);
            Int32 gned1005 = Convert.ToInt32(txtGNED1005.Text);

            // determine letter grades
            lblCOMP1030.Text = SetGrade(comp1030);
            lblCOMP1002.Text = SetGrade(comp1002);
            lblCOMP1051.Text = SetGrade(comp1051);
            lblCOMP1053.Text = SetGrade(comp1053); 
            lblCOMM1016.Text = SetGrade(comm1016);
            lblGNED1005.Text = SetGrade(gned1005);


            // calc & display average
            Int32 avg = comp1030 + comp1002 + comp1051 + comp1053 + comm1016 + gned1005 / 6;
            lblAverage.Text = avg.ToString();
            lblOverallGrade.Text = SetGrade(avg);
        }

        private string SetGrade(Int32 grade)
        {
            String letter = "F";
            
            if (grade > 80)
            {
                letter = "A";
            }
            else if (grade > 69)
            {
                letter = "B";
            }
            else if (grade > 59)
            {
                letter = "C";
            }
            else if (grade > 49)
            {
                letter = "D";
            }

            return letter;
        }
    }
}
