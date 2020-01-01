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
using System.Text.RegularExpressions;

namespace EventManagement
{
    public partial class book : UserControl
    {

        Regex numberchk = new Regex(@"^([0-9]*|\d*)$");
        Venue ve = new Venue();
        public static string name;
        public static string contact;
        public static string email;
        public static string id;
        public static string dated;
        public static string type;

        public book()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void book_Load(object sender, EventArgs e)
        {




        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label9.Anchor = AnchorStyles.None;
            panel1.Dock = DockStyle.Top;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox1, "Please Enter Name");
                    errorProvider2.SetError(textBox1, "");
                    errorProvider3.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "");
                    errorProvider2.SetError(textBox1, "");
                    errorProvider3.SetError(textBox1, "Correct");
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            panel2.Dock = DockStyle.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;
            name = textBox1.Text;
            contact = textBox2.Text;
            email = textBox4.Text;
            id = textBox3.Text;
            dated = dateTimePicker1.Text;
            type = comboBox1.Text;

            if (comboBox1.SelectedIndex == 0) //wedding
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.birthday.Hide();
                ve.concerts.Hide();
                ve.wedding.Show();
                ve.wedding.Dock = DockStyle.Fill;
                ve.menuStrip1.Hide();

            }
            if (comboBox1.SelectedIndex == 1) //birthday
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.concerts.Hide();
                ve.wedding.Hide();
                ve.birthday.Show();
                ve.birthday.Dock = DockStyle.Fill;
                ve.menuStrip1.Hide();


            }
            if (comboBox1.SelectedIndex == 2) //concerts
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.school.Hide();
                ve.birthday.Hide();
                ve.wedding.Hide();
                ve.concerts.Show();
                ve.concerts.Dock = DockStyle.Fill;
                ve.menuStrip1.Hide();


            }
            if (comboBox1.SelectedIndex == 3) //school
            {

                this.Hide();
                this.Parent.Controls.Add(ve);
                ve.concerts.Hide();
                ve.birthday.Hide();
                ve.wedding.Hide();
                ve.school.Show();
                ve.school.Dock = DockStyle.Fill;
                ve.menuStrip1.Hide();

            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox1, "Please Enter Your Number");
                    errorProvider2.SetError(textBox1, "");
                    errorProvider3.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "");
                    errorProvider2.SetError(textBox1, "");
                    errorProvider3.SetError(textBox1, "Correct");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox1, "Please Enter Gmail");
                    errorProvider2.SetError(textBox1, "");
                    errorProvider3.SetError(textBox1, "");
                }
                else
                {
                    Regex numberchk = new Regex(@"^[A-Za-z0-9-_]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9]+(\.[A-Za-z0-9]+)*(\.[A-Za-z]{2,4})$");
                    if (numberchk.IsMatch(textBox2.Text))
                    {
                        errorProvider1.SetError(textBox2, "");
                        errorProvider2.SetError(textBox2, "");
                        errorProvider3.SetError(textBox2, "Correct");
                    }
                    else
                    {
                        errorProvider1.SetError(textBox1, "");
                        errorProvider2.SetError(textBox1, "");
                        errorProvider3.SetError(textBox1, "Wrong");
                    }
                }
            }
        }


    }        }
    

