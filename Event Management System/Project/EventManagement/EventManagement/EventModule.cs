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
    public partial class EventManagmentModule : Form
    {
        int panelWidth;
        bool Hidden;
        public EventManagmentModule()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EventManagmentModule_Load(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addsound1.Visible = false;
            addS_D1.Visible = false;
            addcatering1.Visible = false;
            previouosEvents1.Visible = false;
        }

        private void Ac_Click(object sender, EventArgs e)
        {
            
        }

        private void As_Click(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addsound1.Dock = DockStyle.Fill;
            addsound1.Visible = true;
          
            addcatering1.Visible = false;
        }

        private void Asd_Click(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
           
            addsound1.Visible = false;
           
            addcatering1.Visible = false;

            addS_D1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main1 m = new main1();
            this.Hide();
            m.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addvenue1.Visible = true;
            addvenue1.Dock = DockStyle.Fill;
            addsound1.Visible = false;
            addS_D1.Visible = false;
            previouosEvents1.Visible = false;
            addcatering1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addsound1.Dock = DockStyle.Fill;
            addsound1.Visible = true;
            addS_D1.Visible = false;
            previouosEvents1.Visible = false;
            addcatering1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addcatering1.Dock = DockStyle.Fill;
            addsound1.Visible = false;
            previouosEvents1.Visible = false;
            addS_D1.Visible = false;
            addcatering1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addsound1.Visible = false;
            addcatering1.Visible = false;
            previouosEvents1.Visible = false;
            addS_D1.Visible = true;
            addS_D1.Dock = DockStyle.Fill;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            main1 x = new main1();
            x.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CenterDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addvenue1.Visible = false;
            addsound1.Visible = false;
            addcatering1.Visible = false;
            addS_D1.Visible = false;
            previouosEvents1.Visible = true;
            previouosEvents1.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            main1 x = new main1();
            x.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            main1 x = new main1();
            x.Show();
            this.Hide();
        }
    }
}
