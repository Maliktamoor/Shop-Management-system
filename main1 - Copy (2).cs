using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class main1 : Form
    {
        public main1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main2 s = new main2();
            s.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employ2 s = new Employ2();
            s.Show();

        }

        private void main1_Load(object sender, EventArgs e)
        {

        }
    }
}
