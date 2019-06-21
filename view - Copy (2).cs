
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
using management.Classes;
namespace management
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }
        DataContext dc = new DataContext("Data Source=DESKTOP-4F5AJD6;Initial Catalog=UMS;Integrated Security=True");
        private void view_Load(object sender, EventArgs e)
        {
            Table<shop> s1=dc.GetTable<shop>();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(int));
             dt.Columns.Add("ProductQuenty", typeof(int));
            dt.Columns.Add("ProductDate", typeof(DateTime));
            var qurey = from k in s1
                        select k;
            foreach (var s in qurey)
            {
                dt.Rows.Add(s._ID, s._NAME, s._Price,s._Quenty,s._Date);
            }
            dataGridView2.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Table<shop> s1 = dc.GetTable<shop>();
      
            var cell = dataGridView2.SelectedCells[0];
            var rowindex = dataGridView2.Rows[cell.RowIndex];
            int id = Convert.ToInt32(rowindex.Cells[0].Value);

            var qurey = from k in s1
                        where k._ID == id
                        select k;
            foreach (var s in qurey)
            {
                s1.DeleteOnSubmit(s);
            }
            dc.SubmitChanges();
            MessageBox.Show("Data Deleted");
            
        }
        private void view_Load_1(object sender, EventArgs e)
        {
        
        
          
    }
   
        private void button2_Click(object sender, EventArgs e)
        {
        
            Table<shop> s1= dc.GetTable<shop>();
            
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(int));
            dt.Columns.Add("ProductQuenty", typeof(int));
            dt.Columns.Add("ProductDate", typeof(DateTime));
            var qurey = from k in s1
                        where k._NAME == textBox2.Text
                        select k;
            foreach (shop s in qurey)
            {
                dt.Rows.Add(s._ID, s._NAME, s._Price,s._Quenty,s._Date);
            }
            dataGridView2.DataSource = dt;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }           


        private void button3_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32 (dataGridView2.SelectedRows[0].Cells[0].Value);
            update a = new update();
            a.datashow(id);
            a.Show();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
 

    }
}
