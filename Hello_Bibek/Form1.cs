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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader sdr;
        SqlDataAdapter adapt;
        int id;
        string fname, lname, enroll, ctry, fac,sem, role, desc;

        private void button5_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            

            if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {   

                SqlCommand cmd = new SqlCommand("Delete bibek where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                int v = cmd.ExecuteNonQuery();
                MessageBox.Show("Record with Id= " + int.Parse(textBox1.Text) + " is Deleted !", "Delete Confirmation");
            }
            else
            {
                MessageBox.Show("Record with Id= " + int.Parse(textBox1.Text) + " is Not Deleted !", "Delete Stop Confirmation");
            }

            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
 
            
            string sql = "UPDATE bibek SET fname=@fname,lname=@lname,enrollment=@enroll,country=@ctry,description=@desc,faculty=@fac,Semester=@sem,role=@role WHERE id = @id";

            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@fname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lname", textBox3.Text);
            cmd.Parameters.AddWithValue("@enroll", textBox4.Text);
            cmd.Parameters.AddWithValue("@ctry", textBox5.Text);
            cmd.Parameters.AddWithValue("@desc", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@fac", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sem", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@role", comboBox3.SelectedItem.ToString());
            int v = cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully !", "Confirmation");
            conn.Close();


        }

        //string gender;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\bibek\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO bibek (id,fname,lname,enrollment,country,faculty,Semester,role, description) values (@id,@fname,@lname,@enroll,@ctry,@fac,@sem,@role, @desc)";

            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@fname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lname", textBox3.Text);
            cmd.Parameters.AddWithValue("@enroll", textBox4.Text);
            cmd.Parameters.AddWithValue("@ctry", textBox5.Text);
            cmd.Parameters.AddWithValue("@desc", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@fac", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sem", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@role", comboBox3.SelectedItem.ToString());
            int v = cmd.ExecuteNonQuery();

            MessageBox.Show("Record Inserted Successfully !", "Confirmation");
            conn.Close();
        }
    }
}




// using System.Data.SqlClient;
// ------------------------------------------
// SqlConnection conn;
// SqlDataReader sdr;
// SqlDataAdapter adapt;
// int id = 0;
// string fname, sname, cls, city, sem;
// string gender;
// ---------------------------------------------

//           conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
//           C:\Users\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30");
// ---------------------------------------------
// Insert 

// string sql = "INSERT INTO TableClass (id,fname,sname,class,sem,gender,city) values (@id,@fname,@sname,@class,@sem,'M',@city)";

// conn.Open();

// SqlCommand cmd = new SqlCommand(sql, conn);
// cmd.Parameters.AddWithValue("@id", textBox3.Text.ToString());
// cmd.Parameters.AddWithValue("@fname", textBox1.Text);
// cmd.Parameters.AddWithValue("@sname", textBox2.Text);
// cmd.Parameters.AddWithValue("@class", comboBox1.SelectedItem.ToString());
// cmd.Parameters.AddWithValue("@sem", comboBox2.SelectedItem.ToString());
// cmd.Parameters.AddWithValue("@gender", radioButton1.Checked);
// cmd.Parameters.AddWithValue("@city", comboBox3.SelectedItem.ToString());
// int v = cmd.ExecuteNonQuery();

// MessageBox.Show("Record Inserted Successfully !", "Confirmation");
// conn.Close();

// ---------------------------------------------

// Grid view data show

//             string sqlcmd = "SELECT * FROM Table";

//             conn.Open();
//             SqlCommand cmd = new SqlCommand(sqlcmd, conn);
//             adapt = new SqlDataAdapter(cmd);
//             DataTable dt = new DataTable();
//             adapt.Fill(dt);
//             dataGridView1.DataSource = dt;
//             conn.Close();

// ---------------------------------------------
// Update Data

// string sql = "UPDATE Table SET fname=@fname,lname=@lname,enrollment=@enroll,country=@ctry,description=@desc,faculty=@fac,Semester=@sem,role=@role WHERE id = @id";

// conn.Open();

// SqlCommand cmd = new SqlCommand(sql, conn);
// cmd.Parameters.AddWithValue("@id", id);
// cmd.Parameters.AddWithValue("@fname", textBox2.Text);
// cmd.Parameters.AddWithValue("@lname", textBox3.Text);
// cmd.Parameters.AddWithValue("@enroll", textBox4.Text);
// cmd.Parameters.AddWithValue("@ctry", textBox5.Text);
// cmd.Parameters.AddWithValue("@desc", richTextBox1.Text);
// cmd.Parameters.AddWithValue("@fac", comboBox1.SelectedItem.ToString());
// cmd.Parameters.AddWithValue("@sem", comboBox2.SelectedItem.ToString());
// cmd.Parameters.AddWithValue("@role", comboBox3.SelectedItem.ToString());
// int v = cmd.ExecuteNonQuery();

// MessageBox.Show("Record Updated Successfully !", "Confirmation");
// conn.Close();

// ---------------------------------------------
//             //Clear the values
//             textBox1.Text = "";
//             textBox2.Text = "";
//             comboBox1.SelectedItem = null;
//             comboBox2.SelectedItem = null;
//             radioButton1.Checked = false;
//             radioButton2.Checked = false;
//             comboBox3.SelectedItem = null;
//             id = 0;
//         }


//         }


// ---------------------------------------------
// Delete Data

//             string sql = "DELETE from Table WHERE id=" + id;

//             conn.Open();

//             if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
//             {
//                 SqlCommand cmd = new SqlCommand(sql, conn);
//                 int v = cmd.ExecuteNonQuery();
//                 MessageBox.Show("Record with Id= " + id + " is Deleted !", "Delete Confirmation");
//             }
//             else
//             {
//                 MessageBox.Show("Record with Id= " + id + " is Not Deleted !", "Delete Stop Confirmation");
//             }

//             conn.Close();
