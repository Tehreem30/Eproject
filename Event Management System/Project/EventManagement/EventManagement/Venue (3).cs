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
    public partial class Venue : UserControl
    {
        Catering ca = new Catering();
        public static int money = 0;
        
        public Venue()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            money += 75000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            money += 11000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Venue_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                school.Hide();
                birthday.Hide();
                concerts.Hide();
                wedding.Show();
                wedding.Dock = DockStyle.Fill;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                school.Hide();
                birthday.Show();
                birthday.Dock = DockStyle.Fill;
                concerts.Hide();
                wedding.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                school.Hide();
                birthday.Hide();
                concerts.Show();
                concerts.Dock = DockStyle.Fill;
                wedding.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                school.Show();
                school.Dock = DockStyle.Fill;
                birthday.Hide();
                concerts.Hide();
                wedding.Hide();
            }


        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Venue.money += 50000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            money += 60000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            money += 40000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            money += 70000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            money += 100000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            money += 90000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           Venue.money += 100000;
            this.Hide();
            this.Parent.Controls.Add(ca.wedding);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //money += 10000;
            //this.Hide();
            //this.Parent.Controls.Add(ca);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            money += 500000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            money += 100000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            money += 700000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }
        

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //money += 10000;
            //this.Hide();
            //this.Parent.Controls.Add(ca);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //money += 10000;
            //this.Hide();
            //this.Parent.Controls.Add(ca);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //money += 10000;
            //this.Hide();
            //this.Parent.Controls.Add(ca);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            money += 85000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            money += 90000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            money += 95000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            money += 97000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            money += 95500;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
