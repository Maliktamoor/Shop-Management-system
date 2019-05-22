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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext(" Data Source=ACCER-PC;Initial Catalog=Shop;Integrated Security=True");
        bool enter = false;
        private void button1_Click(object sender, EventArgs e)
        {
             Table<login> s1 = dc.GetTable<login>();
            var query = from k in s1 where k._answer == (textBox1.Text) select k;
           
            foreach (login l in query)
            {
                enter = true;
            }
              
                if(enter)
                {
                    dc.SubmitChanges();
                    MessageBox.Show("Your Answer is true","Successfull",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                    this.Hide();
                    Form6 a = new Form6();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Your Answer is Wrong!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }
    }
}
