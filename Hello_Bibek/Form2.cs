using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hello_Bibek
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlDataReader sdr;
        SqlDataAdapter adapt;
        int id = 0;
        string fname, lname, enroll, ctry, fac, sem, role;

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sqlcmd = "SELECT * FROM bibek where id=@id";
            SqlCommand cmd = new SqlCommand(sqlcmd, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\bibek\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM bibek";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
