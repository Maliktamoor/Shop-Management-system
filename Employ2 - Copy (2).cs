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
    public partial class Employ2 : Form
    {
        public Employ2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employ1 s =new employ1();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewe s = new viewe();
            s.Show();
        }
    }
}
