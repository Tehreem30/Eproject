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
    public partial class sound : UserControl
    {
        payment pa = new payment();
        public sound()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Venue.money += 2000;
            this.Hide();
            this.Parent.Controls.Add(pa);
            pa.label5.Text = Venue.money.ToString();
        }

        private void sound_Load(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            //1st image
            try
            {
                con.Open();

            SqlCommand  cmd = new SqlCommand("select AddPicture from asound where sid=1", con);

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
            //2nd image
            try
            {
                con.Open();

            SqlCommand  cmd = new SqlCommand("select AddPicture from asound where sid=2", con);

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
        }
    }
}
