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
    
    
    public partial class Catering : UserControl
    {
        Sound_Syestem so = new Sound_Syestem();
        public Catering()
        {
            InitializeComponent();
        }

        

        private void Catering_Load(object sender, EventArgs e)
        {
            
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
