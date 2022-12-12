using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleManagement
{
    public partial class DetailReceipt : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;

        public DetailReceipt()
        {
            InitializeComponent();
            con = new SqlConnection(strConn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetailReceipt_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String cmd = "select * from receipt";
            adapt = new SqlDataAdapter(cmd, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
