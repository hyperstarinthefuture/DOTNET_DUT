using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace DOTNET_DUT.Lessons.Connect_to_Database_with_ADO.NET
{
    public partial class Form_Connect_to_Database : Form
    {
        public Form_Connect_to_Database()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=DESKTOP-C3KDUDI;Initial Catalog=QLSVLSH;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionSTR);
            //string sql = "select count (*) from SV";
            //string sql = "select * from SV";
            //SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlCommand cmd = new SqlCommand(textBox1.Text, cnn);
            cnn.Open();
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[]
            //{
            //    new DataColumn("MSSV",typeof(string)),
            //    new DataColumn("NameSV",typeof(string)),
            //    new DataColumn("Gender",typeof(bool)),
            //    new DataColumn("NS",typeof(DateTime)),
            //    new DataColumn("ID_Lop",typeof(int))
            //}) ;
            ////int n = (int)cmd.ExecuteScalar();
            //SqlDataReader r = cmd.ExecuteReader();
            //while(r.Read())
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["MSSV"] = r["MSSV"];
            //    dr["NameSV"] = r["NameSV"];
            //    dr["Gender"] = r["Gender"];
            //    dr["NS"] = r["NS"];
            //    dr["ID_Lop"] = r["ID_Lop"];
            //    dt.Rows.Add(dr);
            //}
            //cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ok");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                Show();
            }
            cnn.Close();
            ////MessageBox.Show(cnn.State.ToString());
            ////MessageBox.Show(n.ToString());
            //dataGridView1.DataSource = dt;
            //Show();
        }
        public void Show()
        {

        }
    }
}
