using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }
        DataContext dc = new DataContext(" Data Source=ACCER-PC;Initial Catalog=Shop;Integrated Security=True");
        bool enter = false;
        private void button1_Click(object sender, EventArgs e)
        {
             Table<login> s1 = dc.GetTable<login>();
            var query = from k in s1 where k._password == Convert.ToInt32(textBox2.Text) && k._username==textBox1.Text select k;
            foreach (login l in query)
            {
                enter = true;
            }
            if (enter)
            {
                this.Hide();
              Form4 a = new Form4();
                a.Show();
            }
            else
            {
                MessageBox.Show("Enter Right username or password","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
           
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default._username = textBox1.Text;
                Properties.Settings.Default._password = (textBox2.Text);
                Properties.Settings.Default._rem = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default._username = "";
                Properties.Settings.Default._password = "";
                Properties.Settings.Default._rem = "No";
                Properties.Settings.Default.Save();

            }
            if(Properties.Settings.Default._rem=="yes")
            {
                textBox1.Text = Properties.Settings.Default._username;
                textBox2.Text = Properties.Settings.Default._password;
                checkBox1.Checked = true;


            }
            else
            {
                textBox1.Text = Properties.Settings.Default._username;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }
    }
}
