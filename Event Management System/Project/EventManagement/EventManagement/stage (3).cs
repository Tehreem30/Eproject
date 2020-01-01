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
    public partial class stage : UserControl
    {
        payment pa = new payment();
        public stage()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                school.Hide();
                birthday.Hide();
                concerts.Hide();
                wedding.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                school.Hide();
                birthday.Show();
                concerts.Hide();
                wedding.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                school.Hide();
                birthday.Hide();
                concerts.Show();
                wedding.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                school.Show();
                birthday.Hide();
                concerts.Hide();
                wedding.Hide();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void school_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
