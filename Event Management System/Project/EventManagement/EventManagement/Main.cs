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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void customerdetails1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //book1.Visible = true;
            //staff1.Visible = false;
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Payment b = new Payment();
            b.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //book1.Visible = false;
            //staff1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //staff1.Visible = true;
            //book1.Visible = false;

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.gmail.com/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //book1.Visible = true;
            //staff1.Visible = false;
        }

        private void serivce1_Load(object sender, EventArgs e)
        {

        }

        private void circularbutton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            //book1.Visible = false;
            //staff1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //book1.Visible = false;
            //staff1.Visible = false;
        }
        }
    }

