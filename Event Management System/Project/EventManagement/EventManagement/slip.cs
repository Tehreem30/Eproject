using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventManagement
{
    public partial class slip : Form
    {
        public slip()
        {
            InitializeComponent();
        }

        private void slip_Load(object sender, EventArgs e)
        {
            CrystalReport1 obj = new CrystalReport1();
            DataSet table = new DataSet();
            string conx = connectionclass.ConnectionString;
            SqlConnection con = new SqlConnection(conx);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from Events where id='" + payment.id+ "'", con);
            adp.Fill(table, "Events");
            obj.SetDataSource(table);
            crystalReportViewer1.ReportSource = obj;
        }
    }
}
