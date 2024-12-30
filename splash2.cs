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
    public partial class splash2 : Form
    {
        public splash2()
        {
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void splash2_Load(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();

        }
    }
}
