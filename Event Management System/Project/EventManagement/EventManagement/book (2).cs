using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventManagement
{
    public partial class book : UserControl
    {
        Venue ve = new Venue();
        public book()
        {
            InitializeComponent();
        }

        private void book_Load(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.birthday.Hide();
                ve.concerts.Hide();
                ve.wedding.Show();
                ve.wedding.Dock = DockStyle.Fill;
                ve.panel1.Hide();
                

            }
            if (comboBox1.SelectedIndex == 1)
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.concerts.Hide();
                ve.wedding.Hide();
                ve.birthday.Show();
                ve.birthday.Dock = DockStyle.Fill;
                ve.panel1.Hide();

            }
            if (comboBox1.SelectedIndex == 2)
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.birthday.Hide();
                ve.wedding.Hide();
                ve.concerts.Show();
                ve.concerts.Dock = DockStyle.Fill;
                ve.panel1.Hide();

            }
            if (comboBox1.SelectedIndex == 3)
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.concerts.Hide();
                ve.birthday.Hide();
                ve.wedding.Hide();
                ve.school.Show();
                ve.school.Dock = DockStyle.Fill;
                ve.panel1.Hide();

            }
        }

       

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionclass.ConnectionString);
            //if (textBox3.Text == "")
            //{
            //    MessageBox.Show("insert Id");
            //}
            //else
            //{
            //    try
            //    {
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand("insert into book  values ('" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox11.Text + "','" + textBox8.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "')", con);

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("inserted");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //    finally
            //    {
            //        con.Close();
            //    }
        }
            }

      
        
        }
    

