                                                            
// using System.Data.SqlClient;
// ------------------------------------------
// SqlConnection conn;
// SqlDataReader sdr;
// SqlDataAdapter adapt;
// int id;
// string fname, sname, cls, city, sem;
// string gender;
// ---------------------------------------------

//           conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
//           C:\Users\Documents\student1.mdf;Integrated Security=True;Connect Timeout=30");

// ---------------------------------------------
                                                    // Insert 

            // string sql = "INSERT INTO Table (id,fname,sname,class,sem,gender,city) values (@id,@fname,@sname,@class,@sem,'M',@city)";

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

                                            // Grid view data show total show 

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
            // cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
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
                                        // Delete Data
        
            // conn.Open();
            

            // if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            // {   

            //     SqlCommand cmd = new SqlCommand("Delete Table where id=@id", conn);
            //     cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            //     int v = cmd.ExecuteNonQuery();
            //     MessageBox.Show("Record with Id= " + int.Parse(textBox1.Text) + " is Deleted !", "Delete Confirmation");
            // }
            // else
            // {
            //     MessageBox.Show("Record with Id= " + int.Parse(textBox1.Text) + " is Not Deleted !", "Delete Stop Confirmation");
            // }

            // conn.Close();
// ---------------------------------------------
                                        // Search data grid view 

            // conn.Open();
            // string sqlcmd = "SELECT * FROM Table where id=@id";
            // SqlCommand cmd = new SqlCommand(sqlcmd, conn);
            // cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            // adapt = new SqlDataAdapter(cmd);
            // DataTable dt = new DataTable();
            // adapt.Fill(dt);
            // dataGridView1.DataSource = dt;
            // conn.Close();



                                            // CIE-1

// ---------------------------------------------
// Calculator using windows forms 
// namespace Calculator
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//         }
//         int n1, n2, add, sub, mul, div;
//         private void radioButton1_CheckedChanged(object sender, EventArgs e)
//         {

//         }

//         private void label4_Click(object sender, EventArgs e)
//         {

//         }

//         private void button1_Click(object sender, EventArgs e)
//         {
//             n1 = Convert.ToInt32(textBox1.Text);
//             n2 = Convert.ToInt32(textBox2.Text);
//             if(radioButton1.Checked == true)
//             {
//                 add = n1 + n2;
//                 label4.Text = n1 + "and" + n2 + "Addition is " + add; 
//             }
//             if (radioButton2.Checked == true)
//             {
//                 sub = n1 - n2;
//                 label4.Text = n1 + "and" + n2 + "Substraction is " + sub;
//             }
//             if (radioButton3.Checked == true)
//             {
//                 mul = n1 * n2;
//                 label4.Text = n1 + "and" + n2 + "Multiplication is " + mul;
//             }
//             if (radioButton4.Checked == true)
//             {
//                 div = n1 / n2;
//                 label4.Text = n1 + "and" + n2 + "Division is " + div;
//             }

//         }
//     }
// }

// ---------------------------------------------
   // email Sending direct button code sent
// try
//             {
//                 SmtpClient Smtp_Server = new SmtpClient();
//                 MailMessage e_mail = new MailMessage();
//                 Smtp_Server.UseDefaultCredentials = false;
//                 Smtp_Server.Port = 587;
//                 Smtp_Server.EnableSsl = true;
//                 Smtp_Server.Host = "smtp.gmail.com";
//                 Smtp_Server.Credentials =
//                 new System.Net.NetworkCredential("bkumarsah627@rku.ac.in", "Bibek@@9815##");
//                 e_mail = new MailMessage();
//                 e_mail.From = new MailAddress(textBox1.Text);
//                 e_mail.To.Add(textBox2.Text);
//                 e_mail.Subject = "Email Sending";
//                 e_mail.IsBodyHtml = false;
//                 e_mail.Body = richTextBox1.Text;
//                 Smtp_Server.Send(e_mail);
//                 //Interaction.MsgBox("Mail Sent");
//                 label4.Text = "Mail Sent Successfully";
//             }
//             catch (Exception error_t)
//             {
//                 // Interaction.MsgBox(error_t.ToString);
//                 label4.Text = "Error in Mail Sent";
//             }

// ---------------------------------------------
// combobox
// comboBox1.Items.Add(comboBox1.Text);
//             string[] items = { };
//             comboBox1.Items.AddRange(items);
//             MessageBox.Show("Value Added");

// MessageBox.Show(comboBox1.SelectedIndex.ToString());
// ---------------------------------------------
// datagrid 

// int data = dataGridView1.Rows.Add();
//             dataGridView1.Rows[data].Cells[0].Value = textBox1.Text;
//             dataGridView1.Rows[data].Cells[1].Value = textBox2.Text;
//             dataGridView1.Rows[data].Cells[2].Value = textBox3.Text;
//             dataGridView1.Rows[data].Cells[3].Value = textBox4.Text;
// ----------------------------------------------------------------------
// Listbox
// listBox1.Items.Clear();
// MessageBox.Show(listBox1.Items.Count.ToString());
// listBox1.Items.Remove(textBox1.Text);
// listBox1.Items.Add(textBox1.Text);

// ___________________________________________________________
                            // message show
// MessageBox.Show($ "Welcome {txtname.Text}, you're {txtage.Text} years old.");

// ____________________________________________________________
                    // Addition
// int input1 = Convert.ToInt32(textBox1.Text);
//             int input2 = Convert.ToInt32(textBox2.Text);

//             int result = input1 + input2;
//             // MessageBox.Show(textBox3.Text + result.ToString());
//             textBox3.Text = result.ToString();
// ---------------------------------------------
                // Tree view 
// namespace Tree_View
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//         }

//         private void button1_Click(object sender, EventArgs e)
//         {
//             treeView1.Nodes.Add("folder1");
//             treeView1.Nodes.Add("folder2");
//             treeView1.Nodes.Add("folder3");

//             treeView1.Nodes[0].Nodes.Add("file1");
//             treeView1.Nodes[1].Nodes.Add("file1");
//             treeView1.Nodes[2].Nodes.Add("file1");
//         }

//         private void button2_Click(object sender, EventArgs e)
//         {
//             treeView1.SelectedNode.Remove();
//         }

//         private void button3_Click(object sender, EventArgs e)
//         {
//             treeView1.Nodes.Clear();
//         }

//         private void button4_Click(object sender, EventArgs e)
//         {
//             MessageBox.Show(treeView1.SelectedNode.FullPath.ToString());
//         }
//     }
// }
// ---------------------------------------------
                // Dialog box in C#
// DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
// if (res == DialogResult.OK) {
//     MessageBox.Show("You have clicked Ok Button");
//     //Some task
// }

// ------------------------------------------------------------------
                // Open file dialogue box
// OpenFileDialog ofd = new OpenFileDialog();
// ofd.Title = "Open a Text File";
// ofd.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*"; //Here you can filter which all files you wanted allow to open
// DialogResult dr = ofd.ShowDialog();
// if (dr == DialogResult.OK) {
//     StreamReader sr = new StreamReader(ofd.FileName);
//     txtEx.Text = sr.ReadToEnd();
//     sr.Close();
// }

// ---------------------------------------------------------------------
// SaveFileDialog sfdlg = new SaveFileDialog();
// sfdlg.Filter = "Text Files (*.txt) | *.txt"; //Here you can filter which all files you wanted allow to open
// if (sfdlg.ShowDialog() == DialogResult.OK) {
//     // Code to write the stream goes here.
// }

// -----------------------------------------------------------------------
// //Font Dialog
// FontDialog fdlg = new FontDialog();
// fdlg.ShowDialog();
// txtEx.Font = fdlg.Font;
// //Color Dialog
// ColorDialog cdlg = new ColorDialog();
// cdlg.ShowDialog();
// txtEx.ForeColor = cdlg.color;
// ---------------------------------------------

//InitializeComponent();
//             radioButton1.CheckedChanged += new EventHandler(Form1_Load);
//             radioButton2.CheckedChanged += new EventHandler(Form1_Load);
//             radioButton3.CheckedChanged += new EventHandler(Form1_Load);
//             radioButton4.CheckedChanged += new EventHandler(Form1_Load);
//             radioButton5.CheckedChanged += new EventHandler(Form1_Load);
//             radioButton6.CheckedChanged += new EventHandler(Form1_Load);
//         }

//         private void Form1_Load(object sender, EventArgs e)
//         {
//             if (radioButton1.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.Red;
//             }
//             else if (radioButton2.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.Green;
//             }
//             else if (radioButton3.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.Blue;
//             }
//             else if (radioButton4.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.Black;
//             }
//             else if (radioButton5.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.White;
//             }
//             else if (radioButton6.Checked)
//             {
//                 this.BackColor = System.Drawing.Color.Red;
//             }
//         }

//         private void radioButton1_CheckedChanged(object sender, EventArgs e)
//         {

//         }
//     }
// }
// ---------------------------------------------
// ---------------------------------------------
// ---------------------------------------------