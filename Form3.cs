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
    public partial class Form3 : Form
    {
        myDatabaseDataContext dc;
        bool flag = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dc = new myDatabaseDataContext();
            //var tab = from E in dc.Emps select E;
            //dataGridView1.DataSource = tab;
            //straighwaya bind to grid view
            dataGridView1.DataSource = from E in dc.Emps select E;
            var tab = from E in dc.Emps select new { E.Job };
            comboBox1.DataSource = tab.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;//no selection
            flag = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == true)
            dataGridView1.DataSource = from E in dc.Emps where E.Job == comboBox1.Text select E;
        }
    }
}
