using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EventManagement
{
    public partial class costumerdetails : Form
    {
        int panelWidth;
        bool Hidden;

        public costumerdetails()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
            Hidden = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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





     



      

      

        private void button3_Click(object sender, EventArgs e)
        {
            //staff2.Visible = false;
            //book1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //staff2.Visible = false;
            //book1.Visible = false;
        }

        private void CenterDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //staff2.Visible = false;
            book2.Visible = false;
            book2.Dock = DockStyle.Fill;
            venue3.Visible = false;
            payment1.Visible = false;
            catering1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }



        private void button13_Click(object sender, EventArgs e)
        {
            //staff2.Visible = true;
            // book1.Visible = false;
        }

        private void book1_Load(object sender, EventArgs e)
        {

        }

        

      

        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gmail.com/");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             book2.Visible = true;
            book2.Dock = DockStyle.Fill;
            venue3.Visible = false;
            payment1.Visible = false;
            catering1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           venue3.Visible = true;
           venue3.Dock = DockStyle.Fill;
            book2.Visible = false;
            payment1.Visible = false;
            catering1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            catering1.Visible = true;
            catering1.Dock = DockStyle.Fill;
            book2.Visible = false;
            venue3.Visible = false;
            payment1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sound_Syestem1.Visible = true;
            sound_Syestem1.Dock = DockStyle.Fill;
            catering1.Visible = false;
            book2.Visible = false;
            venue3.Visible = false;
            payment1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            catering1.Visible = false;
            book2.Visible = false;
            venue3.Visible = false;
            payment1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            main1 m = new main1();
            this.Hide();
            m.Show();
        }

        private void book1_Load_1(object sender, EventArgs e)
        {

        }

        private void book1_Load_2(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            payment1.Visible = true;
            payment1.Dock = DockStyle.Fill;
            venue3.Visible = false;
            book2.Visible = false;
            catering1.Visible = false;
            sound_Syestem1.Visible = false;
        }

        private void book2_Load(object sender, EventArgs e)
        {

        }

        private void catering2_Load(object sender, EventArgs e)
        {

        }

        private void catering1_Load(object sender, EventArgs e)
        {

        }

        private void sound_Syestem1_Load(object sender, EventArgs e)
        {

        }

        private void payment1_Load(object sender, EventArgs e)
        {

        }

        private void venue2_Load(object sender, EventArgs e)
        {

        }

        private void catering1_Load_1(object sender, EventArgs e)
        {

        }

        private void venue3_Load(object sender, EventArgs e)
        {

        }

        private void venue1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void venue2_Load_1(object sender, EventArgs e)
        {

        }

        private void catering1_Load_2(object sender, EventArgs e)
        {

        }

        private void venue3_Load_1(object sender, EventArgs e)
        {

        }

        private void venue1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
        

        
    