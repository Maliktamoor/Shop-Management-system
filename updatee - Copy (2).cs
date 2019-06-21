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
using management.Classes;
namespace management
{
    public partial class updatee : Form
    {
        public updatee()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-4F5AJD6;Initial Catalog=UMS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Table<employerec> s1 = dc.GetTable<employerec>();

                var qurey = from k in s1
                            where k._id== Convert.ToInt32(textBox1.Text)
                            select k;
                foreach (var s in qurey)
                {

                    s._name = textBox2.Text;
                    s._address = textBox3.Text;
                    s._phone = textBox4.Text;
                    s._gender = textBox5.Text;
                    s._salary = Convert.ToInt32(textBox6.Text);
                    s._department = textBox7.Text;
                    s._age = textBox8.Text;
                    s._CNIC = textBox9.Text;
                }
                dc.SubmitChanges();
                MessageBox.Show("Data Update successfully", "Successfully", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }
      
        public void datashow(int id)
        {
            Table<employerec> s1 = dc.GetTable<employerec>();
            var qurey = from k in s1
                        where k._id == id
                        select k;
                 
            foreach(employerec s in qurey)
            {
                textBox1.Text = Convert.ToString(s._id);
                textBox2.Text = s._name;
                textBox3.Text = s._address;
                textBox4.Text = s._phone;
                textBox5.Text = s._gender;
                textBox6.Text = Convert.ToString(s._salary);
                textBox7.Text = s._department;
                textBox8.Text = Convert.ToString(s._age);
                textBox9.Text = s._CNIC;
             }

        }
        private void updatee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
