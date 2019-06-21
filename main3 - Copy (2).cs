using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.Classes;
using System.Data.Linq;

namespace management
{
    public partial class main3 : Form
    {
        public main3()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-4F5AJD6;Initial Catalog=UMS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Table<shop> s1 = dc.GetTable<shop>();
            shop s = new shop();
            s._ID = Convert.ToInt32(textBox1.Text);
            s._NAME = textBox2.Text;
            s._Price = Convert.ToInt32(textBox3.Text);
            s._Quenty = Convert.ToInt32(textBox4.Text);
            s._Date = Convert.ToDateTime(dateTimePicker1.Text);
            s1.InsertOnSubmit(s);
            dc.SubmitChanges();
            MessageBox.Show("Data added");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
