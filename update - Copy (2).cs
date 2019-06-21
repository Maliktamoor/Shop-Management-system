using management.Classes;
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

namespace management
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-4F5AJD6;Initial Catalog=UMS;Integrated Security=True");
        public void datashow(int id)
        {
            Table<shop> s1 = dc.GetTable<shop>();

            var qurey = from k in s1
                        where k._ID == id
                        select k;
            foreach (var s in qurey)
            {
                textBox1.Text = Convert.ToString(s._ID);
                textBox2.Text = s._NAME;
                textBox3.Text = Convert.ToString(s._Price);
                textBox4.Text = Convert.ToString(s._Quenty);
                dateTimePicker1.Text = Convert.ToString(s._Date);
            }
            


        }
        private void update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Table<shop> s1 = dc.GetTable<shop>();

                var qurey = from k in s1
                            where k._ID ==Convert.ToInt32(textBox1.Text)
                            select k;
                foreach (var s in qurey)
                {
                    
                     s._NAME= textBox2.Text;
                     s._Price=Convert.ToInt32 ( textBox3.Text);
                    s._Quenty =Convert.ToInt32( textBox4.Text );
                     s._Date=Convert.ToDateTime( dateTimePicker1.Text);
                }
                dc.SubmitChanges();
                MessageBox.Show("Data Update successfully","Successfully",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
