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
    
    
    public partial class Catering : UserControl
    {
        stage so = new stage();
        public Catering()
        {
            InitializeComponent();
        }

        

        private void Catering_Load(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=1", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=2", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=3", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=4", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=5", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox5.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=6", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox3.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=7", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox4.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=8", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox1.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=9", con);

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
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=10", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox7.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=11", con);

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
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=12", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=13", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=14", con);

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
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=15", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox14.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from acatering where catererid=16", con);

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
            //

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

        private void package2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void packegesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel5.Hide();
            panel4.Hide();
           panel2.Hide();
            panel1.Show();
            panel1.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel4.Hide();
            panel1.Hide();
            panel2.Show();
            panel2.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel2.Hide();
            panel1.Hide();
            panel4.Show();
            panel4.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel1.Hide();
            panel2.Hide();
            panel5.Show();
            panel5.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.birthday.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.wedding.Show();
            so.wedding.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.birthday.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.wedding.Show();
            so.wedding.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.birthday.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.wedding.Show();
            so.wedding.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.birthday.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.wedding.Show();
            so.wedding.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.birthday.Show();
            so.birthday.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.birthday.Show();
            so.birthday.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.birthday.Show();
            so.birthday.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Venue.money += 20000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Hide();
            so.birthday.Show();
            so.birthday.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Show();
            so.birthday.Hide();
            so.school.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Show();
            so.birthday.Hide();
            so.school.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Show();
            so.birthday.Hide();
            so.school.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Hide();
            so.school.Show();
            so.birthday.Hide();
            so.school.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Show();
            so.school.Hide();
            so.birthday.Hide();
            so.concerts.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Show();
            so.school.Hide();
            so.birthday.Hide();
            so.concerts.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Show();
            so.school.Hide();
            so.birthday.Hide();
            so.concerts.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Venue.money += 10000;
            this.Hide();
            this.Parent.Controls.Add(so);
            so.wedding.Hide();
            so.concerts.Show();
            so.school.Hide();
            so.birthday.Hide();
            so.concerts.Dock = DockStyle.Fill;
            so.menuStrip1.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void packegesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel5.Hide();
            panel4.Hide();
            panel2.Hide();
            panel1.Show();
            panel1.Dock = DockStyle.Fill;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
