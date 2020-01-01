using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO; //requires this namespace
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class Addvenue : UserControl
    {
        string filename;
        public Addvenue()
        {
            InitializeComponent();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addvenue_Load(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            try
            {
                con.Open();

                string selectquery1 = "select * from avenue";
                SqlCommand cmd1 = new SqlCommand(selectquery1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    int rn2 = dr1.GetInt32(0);
                    int h = rn2 + 1;
                    textBox1.Text = h.ToString();
                }
                dr1.Close();


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

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            if (File.Exists(openFileDialog1.FileName))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into avenue values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',@img)", con);
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    byte[] image = new byte[fs.Length];
                    fs.Read(image, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    SqlParameter sql = new SqlParameter("@img", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                    cmd.Parameters.Add(sql);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("please select image");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM avenue WHERE Venueid = '" + textBox1.Text + "'", con);
            try
            {
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {


                    try
                    {

                        SqlCommand cmd1 = new SqlCommand("DELETE FROM avenue where Venueid=('" + textBox1.Text + "')", con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("deleted");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                    MessageBox.Show("Id not matched");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            if (File.Exists(openFileDialog1.FileName))
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into avenue values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',@img)", con);
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    byte[] image = new byte[fs.Length];
                    fs.Read(image, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                    SqlParameter sql = new SqlParameter("@img", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                    cmd.Parameters.Add(sql);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("please select image");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM avenue WHERE Venueid = '" + textBox1.Text + "'", con);
            try
            {
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {


                    try
                    {

                        SqlCommand cmd1 = new SqlCommand("DELETE FROM avenue where Venueid=('" + textBox1.Text + "')", con);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("deleted");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                    MessageBox.Show("Id not matched");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM avenue WHERE ContractorId = '" + textBox1.Text + "'", con);
            try
            {
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("UPDATE avenue SET VenueName ='" + textBox2.Text + "', VenuePrice=('" + textBox3.Text + "'), AddPrice=('" +pictureBox1.Image + "') where VenueId=('" + textBox1.Text + "')", con);
                        FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        byte[] image = new byte[fs.Length];
                        fs.Read(image, 0, Convert.ToInt32(fs.Length));
                        fs.Close();
                        SqlParameter sql = new SqlParameter("@img", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                        cmd.Parameters.Add(sql);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Updataed");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {

                    MessageBox.Show("Id Not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from avenue ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

