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
    public partial class Sound_Syestem : UserControl
    {
        stage st = new stage();
        public Sound_Syestem()
        {
            InitializeComponent();
        }

        private void Sound_Syestem_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Singer.Hide();

                panel2.Show();
                panel2.Dock = DockStyle.Fill;
            }

            else if (comboBox1.SelectedIndex == 1)
            {

                Singer.Show();
                Singer.Dock = DockStyle.Fill;
                panel2.Hide();

            }
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(st);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(st);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Singer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DJ_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
