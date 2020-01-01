using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class payment : UserControl
    {
        public static string id;
        public payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
          
            textBox1.Text = book.name;
            textBox2.Text = book.contact;
            textBox4.Text = book.email;
            textBox3.Text = book.id;
            textBox5.Text = book.dated;
            textBox6.Text = book.type;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionclass.ConnectionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Events values ('" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + label5.Text + "')", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
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

        private void button1_Click(object sender, EventArgs e)
        {
            id = textBox3.Text;
            slip x = new slip();
            x.Show();

        }
    }
}
