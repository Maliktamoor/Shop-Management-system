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

namespace ShopManagement
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-21TJ386\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True");
        public void datashow(int id)
        {
            Table<supplier> s1 = dc.GetTable<supplier>();

            var query = from k in s1
                        where k._ID == id
                        select k;
            foreach (supplier s in query)
            {
                textBox1.Text = s._ID.ToString();
                textBox2.Text = s._name;
                textBox3.Text = s._age.ToString();
                textBox4.Text = s._address;
                textBox5.Text = s._contact;

            }
             
        }
        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<supplier> s1 = dc.GetTable<supplier>();

            var query = from k in s1
                        where k._ID == Convert.ToInt32(textBox1.Text)
                        select k;
            foreach (supplier s in query)
            {
              // s._ID = Convert.ToInt32(textBox1.Text);
                s._name = textBox2.Text ;
                s._age = Convert.ToInt32(textBox3.Text);
                 s._address= textBox4.Text ;
                s._contact= textBox5.Text ;

            }
            dc.SubmitChanges();
        }
    }
}
