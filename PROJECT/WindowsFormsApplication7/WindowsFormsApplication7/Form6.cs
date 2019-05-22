using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
        DataContext dc = new DataContext(" Data Source=ACCER-PC;Initial Catalog=Shop;Integrated Security=True");
        bool enter = true;
        private void button1_Click(object sender, EventArgs e)
        {
            Table<login> s1 = dc.GetTable<login>();
            var query = from k in s1 where k._username == textBox1.Text select k;
            foreach (login l in query)
            {
                l._password = Convert.ToInt32(textBox2.Text);
                if (textBox2.Text == textBox3.Text)
                {
                    dc.SubmitChanges();

                }
                else
                {
                    MessageBox.Show("Password not same", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
               // enter = true;
            }

            //if (enter)
            //{

            //    var sm = from k in s1 where k._username == textBox1.Text select k;
            //    foreach (login l in sm)
            //    {
            //        l._password = Convert.ToInt32(textBox2.Text);
            //    }
            //    if (textBox2.Text == textBox3.Text)
            //    {
            //        dc.SubmitChanges();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Password not same", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    }
            //}


            //else
            //{
            //    MessageBox.Show("Your Username is Wrong!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
            

        }
    }
}
