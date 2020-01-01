using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class stage : UserControl
    {
       sound sa = new sound();
        public stage()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
            //pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void school_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(sa);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void birthday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void packegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wedding.Show();
            school.Hide();
            concerts.Hide();
            birthday.Hide();
           wedding.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            wedding.Hide();
            school.Hide();
            concerts.Hide();
            birthday.Show();
            birthday.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            wedding.Hide();
            school.Show();
            concerts.Hide();
            birthday.Hide();
           school.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            wedding.Hide();
            school.Hide();
            concerts.Show();
            birthday.Hide();
            concerts.Dock = DockStyle.Fill;
        }

        private void concerts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stage_Load(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=1", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=2", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=3", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=4", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox23.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=5", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=6", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=7", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=8", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=9", con);

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
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=10", con);

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
            ////1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=11", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AddPicture"]);

                    pictureBox20.Image = new Bitmap(ms);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=12", con);

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
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=13", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=14", con);

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

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=15", con);

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
            //
            //1st image
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select AddPicture from asd where sdid=16", con);

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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void wedding_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
