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
    public partial class employ1 : Form
    {
        public employ1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-4F5AJD6;Initial Catalog=UMS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Table<employerec> s1 = dc.GetTable<employerec>();
            employerec emp = new employerec();
            employerec add = new employerec();
            add._id = Convert.ToInt32(textBox1.Text);
            add._name = textBox2.Text;
            add._address = textBox3.Text;
            add._phone = textBox4.Text;
            add._gender = textBox5.Text;
            add._salary = Convert.ToInt32(textBox6.Text);
            add._department = textBox7.Text;
            add._age = textBox8.Text;
            add._CNIC = textBox9.Text;
            s1.InsertOnSubmit(add);
            dc.SubmitChanges();
            MessageBox.Show("Data Added", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
