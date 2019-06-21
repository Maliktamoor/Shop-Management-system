using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using management.Classes;
using System.Data.Linq;

namespace management
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main3 s = new main3();
            s.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view s = new view();
            s.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
      

        }
    }
}
