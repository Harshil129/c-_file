using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        myDatabaseDataContext dc;//declare at top
        List<Employee> Emps;//declare list
        int rno = 0;//declaring a variable row no to access index
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //establish a connection using datacontext class
            dc = new myDatabaseDataContext();
            Emps = dc.Employees.ToList();//data in table is transferred into list
            ShowData();
        }
        private void ShowData()
        {
            textBox2.Text = Emps[rno].Eno.ToString();
            textBox3.Text = Emps[rno].Ename;//already a string
            textBox4.Text = Emps[rno].Job;
            textBox5.Text = Emps[rno].Salary.ToString();
            textBox6.Text = Emps[rno].Dname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {

                rno -= 1;
                ShowData();
            }
            else
                MessageBox.Show("First Record of the table");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (rno < Emps.Count - 1)
            {
                rno += 1;
                ShowData();
            }
            else
                MessageBox.Show("Last Record of the table");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
