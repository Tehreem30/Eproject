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
    public partial class ServiceProvider : Form
    {
        int panelWidth;
        bool Hidden;

        public ServiceProvider()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cd_Click(object sender, EventArgs e)
        {
            
        }

        private void ServiceProvider_Load(object sender, EventArgs e)
        {
            cateringDetails1.Visible = false;
            veneuDetails1.Visible = false;
            soundSysDetails1.Visible = false;
            stageDecorationDetails1.Visible = false;
        }

        private void Vd_Click(object sender, EventArgs e)
        {
            cateringDetails1.Visible = false;
            veneuDetails1.Dock = DockStyle.Fill;
            veneuDetails1.Visible = true;
            soundSysDetails1.Visible = false;
            stageDecorationDetails1.Visible = false;
        }

        private void sd_Click(object sender, EventArgs e)
        {
           
        }

        private void sdd_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main1 m = new main1();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cateringDetails1.Visible = true;
            cateringDetails1.Dock = DockStyle.Fill;
            veneuDetails1.Visible = false;
            soundSysDetails1.Visible = false;
            stageDecorationDetails1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cateringDetails1.Visible = false;
            veneuDetails1.Dock = DockStyle.Fill;
            veneuDetails1.Visible = true;
            soundSysDetails1.Visible = false;
            stageDecorationDetails1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cateringDetails1.Visible = false;
            soundSysDetails1.Dock = DockStyle.Fill;
            veneuDetails1.Visible = false;
            soundSysDetails1.Visible = true;
            stageDecorationDetails1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cateringDetails1.Visible = false;
            stageDecorationDetails1.Dock = DockStyle.Fill;
            veneuDetails1.Visible = false;
            soundSysDetails1.Visible = false;
            stageDecorationDetails1.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
