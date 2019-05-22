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
    public partial class Form2 : Form
    {
        public Form2()
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
            var query = from k in s1 where k._password == Convert.ToInt32(textBox1.Text) select k;
           
            foreach(login l in query)
            {
                l._password = Convert.ToInt32(textBox2.Text);
                if(textBox2.Text==textBox3.Text)
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Password changed Successfully","Successfull",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form4 a = new Form4();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Password Not same!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
