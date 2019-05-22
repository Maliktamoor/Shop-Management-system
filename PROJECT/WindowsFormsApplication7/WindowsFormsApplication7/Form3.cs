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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        DataContext dc = new DataContext(" Data Source=ACCER-PC;Initial Catalog=Shop;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Table<login> s1 = dc.GetTable<login>();
            login l = new login();
            l._username = textBox1.Text;
            l._password = Convert.ToInt32(textBox2.Text);
            l._answer = textBox4.Text;
            s1.InsertOnSubmit(l);
            dc.SubmitChanges();
            if(textBox2.Text==textBox3.Text)
            {
                MessageBox.Show("Account Created successfully","successfull",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Password not same!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
