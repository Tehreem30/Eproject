using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class serivce : UserControl
    {
        public serivce()
        {
            InitializeComponent();
        }

        private void serivce_Load(object sender, EventArgs e)
        {

        }

        private void circularbutton8_Click(object sender, EventArgs e)
        {
            Sound ss = new Sound();
            ss.Show();
        }

        private void circularbutton7_Click(object sender, EventArgs e)
        {
            Light ll = new Light();
            ll.Show();
        }

        private void circularbutton6_Click(object sender, EventArgs e)
        {
            Food ff = new Food();
            ff.Show();
        }

        private void circularbutton5_Click(object sender, EventArgs e)
        {
            Decoration dd = new Decoration();
            dd.Show();
        }

       

       
    }
}
