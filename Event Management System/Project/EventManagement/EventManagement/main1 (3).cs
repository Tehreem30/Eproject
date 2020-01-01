using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class main1 : Form
    {
        public main1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            costumerdetails costumer = new costumerdetails();
            this.Hide();
            costumer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EventManagmentModule events = new EventManagmentModule();
            this.Hide();
            events.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceProvider service = new ServiceProvider();
            this.Hide();
            service.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin ad = new admin();
            this.Hide();
            ad.Show();
        }
    }
}
