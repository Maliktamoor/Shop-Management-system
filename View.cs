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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataContext dc = new DataContext("Data Source=DESKTOP-21TJ386\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True");
        private void View_Load(object sender, EventArgs e)
        {

            Table<supplier> s1 = dc.GetTable<supplier>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Sup_ID", typeof(int));
            dt.Columns.Add("Sup_Name",typeof(string));
            dt.Columns.Add("Sup_Age",typeof(int));
            dt.Columns.Add("Sup_Address",typeof(string));
            dt.Columns.Add("Sup_Contact",typeof(string));

            var query = from k in s1
                        select k;
            foreach(supplier s in query)
            {
                dt.Rows.Add(s._ID, s._name,s._age,s._address,s._contact);
            }
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table<supplier> s1 = dc.GetTable<supplier>();
            var cell = dataGridView1.SelectedCells[0];
            var rowindex = dataGridView1.Rows[cell.RowIndex];
            int id = Convert.ToInt32(rowindex.Cells[0].Value);
            var query = from k in s1
                        where k._ID==id
                        select k;
            foreach (supplier s in query)
            {
                s1.DeleteOnSubmit(s);
            }
            dc.SubmitChanges();
            MessageBox.Show("Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table<supplier> s1 = dc.GetTable<supplier>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Sup_ID", typeof(int));
            dt.Columns.Add("Sup_Name", typeof(string));
            dt.Columns.Add("Sup_Age", typeof(int));
            dt.Columns.Add("Sup_Address", typeof(string));
            dt.Columns.Add("Sup_Contact", typeof(string));

            var query = from k in s1
                        where k._ID== Convert.ToInt32 (textBox1.Text)
                        select k;
            foreach (supplier s in query)
            {
                dt.Rows.Add(s._ID, s._name, s._age, s._address, s._contact);
            }
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            Edit ed = new Edit();
            ed.datashow(id);
            ed.Show();

        }
    }
}
