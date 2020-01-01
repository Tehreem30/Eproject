using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class Venue : UserControl
    {
        Catering ca = new Catering();
       
        public static int money = 0;
        public static string venue;
        
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
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=1", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox2.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //2nd image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=2", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox15.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=3", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox10.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=1", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox13.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=5", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox8.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=6", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox6.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=7", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox11.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=8", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox12.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=9", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox18.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=10", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox9.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=11", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox16.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=12", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox2.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=13", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox21.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=14", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox19.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=15", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox17.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from avenue where venueid=16", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox22.Image = new Bitmap(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
            //

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Venue.money += 50000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel4.Show();
            ca.panel4.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            money += 60000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel4.Show();
            ca.panel4.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();


        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            money += 40000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel4.Show();
            ca.panel4.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            money += 70000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel4.Show();
            ca.panel4.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
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
            money += 100000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel4.Hide();
            ca.panel2.Hide();
            ca.panel1.Show();
            ca.panel1.Dock = DockStyle.Fill;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel4.Hide();
            ca.panel2.Hide();
            ca.panel1.Show();
            ca.panel1.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            money += 500000;
            this.Hide();
            this.Parent.Controls.Add(ca);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            money += 200000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel4.Hide();
            ca.panel2.Hide();
            ca.panel1.Show();
            ca.panel1.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            money += 150000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel5.Hide();
            ca.panel4.Hide();
            ca.panel2.Hide();
            ca.panel1.Show();
            ca.panel1.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }
        

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel5.Show();
            ca.panel5.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel5.Show();
            ca.panel5.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel5.Show();
            ca.panel5.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            money += 10000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel2.Hide();
            ca.panel5.Show();
            ca.panel5.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
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
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            money += 95000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            money += 97000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            money += 95500;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
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

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            label24.Anchor = AnchorStyles.None;
            panel3.Dock = DockStyle.Top;
        }

        private void packegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            school.Hide();
           birthday.Hide();
           concerts.Hide();
            wedding.Show();
            wedding.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            school.Hide();
            birthday.Show();
            concerts.Hide();
            wedding.Hide();
            birthday.Dock = DockStyle.Fill;


        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

            school.Show();
            birthday.Hide();
            concerts.Hide();
            wedding.Hide();
            school.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {

            school.Hide();
            birthday.Hide();
            concerts.Show();
            wedding.Hide();
            concerts.Dock = DockStyle.Fill;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            money += 200000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {

            money += 300000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            money += 350000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            money += 250000;
            this.Hide();
            this.Parent.Controls.Add(ca);
            ca.panel4.Hide();
            ca.panel1.Hide();
            ca.panel5.Hide();
            ca.panel2.Show();
            ca.panel2.Dock = DockStyle.Fill;
            ca.menuStrip1.Hide();
        }

        private void concerts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
