using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turf
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void s_Load(object sender, EventArgs e)
        {
            splash2 obj = new splash2();
            obj.Show();
            this.Hide();
        }
    }
}
