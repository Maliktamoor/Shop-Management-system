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

namespace ShopManagement
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataContext dc=new DataContext("Data Source=DESKTOP-21TJ386\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Table<supplier> s1= dc.GetTable<supplier>();
            supplier s= new supplier();
            s._ID= Convert.ToInt32(textBox1.Text);
            s._name= textBox2.Text;
            s._age = Convert.ToInt32(textBox3.Text);
            s._address = textBox4.Text;
            s._contact = textBox5.Text;
            s1.InsertOnSubmit(s);
            dc.SubmitChanges();
            MessageBox.Show("Data Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View c = new View();
            c.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
