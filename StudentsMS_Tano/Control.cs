using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsMS_Tano.Sql_Controls;
using System.Data.SqlClient;

namespace StudentsMS_Tano
{
    public partial class Control : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-FDL70D0\\SQLEXPRESS;Initial Catalog=DBStudentMS_Tano;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Control()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            if (textBox1.Text == "")
            {
                MessageBox.Show("First Name is Required");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Last Name is Required");
            }
            else if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Course is Required");
            }
            else
            {

                if (idd.Text == "")
                {
                    partial();

                    con.Open();


                    SqlDataAdapter sd = new SqlDataAdapter("SELECT  student_no FROM tblStudent WHERE first_name = '"+ textBox1.Text +"' ", con);
                    DataTable dt1 = new DataTable();
                    sd.Fill(dt1);

                    foreach (DataRow dr in dt1.Rows)
                    {
                        sub.set_num(dr["student_no"]);
                            {                     
                            this.Close();
                            sub.Show();
                        }
                    }
                    con.Close();
                    if (validatee.Text == "updating")
                    {
                        sub.get_valid("updatng");
                    }
                    else
                    {
                        sub.get_valid("inserting");
                    }

                }
                else
                {
                    if (validatee.Text == "updating")
                    {
                        sub.get_valid("updating");
                    }
                    else
                    {
                        sub.get_valid("inserting");
                    }
                    sub.set_num(idd.Text);
                    this.Close();
                    sub.Show();
                }



            }
        

        }

        private void Control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBStudentMS_TanoDataSet3.tblSubject' table. You can move, or remove it, as needed.
            this.tblSubjectTableAdapter.Fill(this.dBStudentMS_TanoDataSet3.tblSubject);
            // TODO: This line of code loads data into the 'dBStudentMS_TanoDataSet2.tblAssignedSubject' table. You can move, or remove it, as needed.
            this.tblAssignedSubjectTableAdapter.Fill(this.dBStudentMS_TanoDataSet2.tblAssignedSubject);
            // TODO: This line of code loads data into the 'dBStudentMS_TanoDataSet1.tblCourse' table. You can move, or remove it, as needed.
            this.tblCourseTableAdapter.Fill(this.dBStudentMS_TanoDataSet1.tblCourse);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            subjects.Columns.Add(btn);

            if(idd.Text == "")
            {
                Get_subject();
            }
            else
            {
                editing();
                con.Open();

                SqlDataAdapter sd = new SqlDataAdapter("SELECT assign_no, subject_no FROM tblAssignedSubject WHERE student_no = '"+ Convert.ToInt32(idd.Text) +"' ", con);
                DataTable dt1 = new DataTable();
                sd.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    SqlDataAdapter sd1 = new SqlDataAdapter("SELECT subject_name FROM tblSubject WHERE subject_no='" + dr["subject_no"] + "'", con);
                    DataTable dt = new DataTable();
                    sd1.Fill(dt);

                    foreach (DataRow dr1 in dt.Rows)
                    {     
                            subjects.Rows.Add(dr["assign_no"], dr1["subject_name"]);
                    }
                }
                con.Close();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_info student_Info = new Student_info();
            Query query = new Query();
            if (idd.Text != "" && validatee.Text == "inserting" )
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblStudent WHERE first_name = '" + textBox1.Text + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                    if(con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "SELECT * FROM tblAssignedSubject WHERE student_no='" + Convert.ToInt32(idd.Text) + "'";      
                    SqlDataReader reader1 = cmd1.ExecuteReader();
              
                    if (reader1.HasRows)
                    {
                        con.Close();

                        string select1 = "SELECT * FROM tblAssignedSubject WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        string quer_string1 = "DELETE FROM tblAssignedSubject WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        query.delete_assigned(select1, quer_string1);

                        string selects = "SELECT * FROM tblStudent WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        string quer_string = "DELETE FROM tblStudent WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        query.delete_assigned(selects, quer_string);

                    }
                    else
                    {
                        con.Close();
                        string select2 = "SELECT * FROM tblStudent WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        string quer_string2 = "DELETE FROM tblStudent WHERE student_no = '" + Convert.ToInt32(idd.Text) + "'";
                        query.delete_assigned(select2, quer_string2);

                    }
                }
                this.Close();
                student_Info.Show();
            }
            else
            {
                this.Close();
                student_Info.Show();
            }
       

           // string select = "SELECT * FROM tblAssignedSubject WHERE student_no IS NULL ";
          //  string delete = "DELETE FROM tblAssignedSubject WHERE student_no IS NULL";

            //query.delete1(select, delete);
            //this.Close();
            //student_info.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_info stu = new Student_info();

            int total_subjects = subjects.RowCount;
          
            if (textBox1.Text == "")
                {
                    MessageBox.Show("First Name is Required");
                }
            else if(textBox3.Text == "")
                {
                    MessageBox.Show("Last Name is Required");
                }
            else if (total_subjects < 1)
                {
                    MessageBox.Show("Should Have Atleast one Subject");
                }
            else if (comboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Course is Required");
                }
            else
                {
                
                if (idd.Text == "")
                    {
                        try
                        {
      
                            string query_string = "INSERT INTO tblStudent (first_name, middle_name, last_name, birth_date, course_id) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Value.Date + "', '" + comboBox1.SelectedValue + "')";
                            Query query = new Query();
                            query.insert(query_string);
                        this.Close();
                        stu.Show();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid Input");
                        }
                    }
                else
                    {
                    try
                    {
                        string query_string = "UPDATE tblStudent set first_name='"+ textBox1.Text +"', middle_name='"+ textBox2.Text +"', last_name='"+ textBox3.Text +"', birth_date='"+ dateTimePicker1.Value.Date +"', course_id='"+ comboBox1.SelectedValue +"' WHERE student_no = '"+ Convert.ToInt32(idd.Text) +"'";
                        Query query = new Query();
                        query.insert(query_string);
                        this.Close();
                        stu.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Input");
                    }
                }
                }
            }

        public void Get_subject()
        {
            con.Open();

            SqlDataAdapter sd = new SqlDataAdapter("SELECT subject_no FROM tblAssignedSubject WHERE student_no is NULL ", con);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);

            foreach(DataRow dr in dt1.Rows)
            {
                SqlDataAdapter sd1 = new SqlDataAdapter("SELECT subject_name FROM tblSubject WHERE subject_no='"+ dr["subject_no"] + "' ", con);
                DataTable dt = new DataTable();
                sd1.Fill(dt);
                
                foreach(DataRow dr1 in dt.Rows)
                {
                    subjects.Rows.Add(dr1["subject_name"]);
                }    
            }
            con.Close();
        }

        public void partial()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tblStudent(first_name, middle_name, last_name, birth_date, course_id) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + dateTimePicker1.Value.Date + "', '" + comboBox1.SelectedValue + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Each Field Should have Valid Value to Proceed");
                con.Close();
            }
            
            
        }

        public void set_num(object num)
        {
            idd.Text = Convert.ToString(num);
        }

        public void get_validate(string str)
        {
            validatee.Text = str;
        }

        public void editing()
        {
            con.Open();

            SqlDataAdapter sd = new SqlDataAdapter("SELECT first_name, middle_name, last_name, birth_date, course_id FROM tblStudent WHERE student_no = '"+ Convert.ToInt32(idd.Text) +"'", con);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                SqlDataAdapter sd2 = new SqlDataAdapter("SELECT course_name FROM tblCourse WHERE course_id = '" + Convert.ToInt32(dr["course_id"]) + "'", con);
                DataTable d1 = new DataTable();
                sd2.Fill(d1);

                foreach (DataRow d2 in d1.Rows)
                {
                    comboBox1.Text = Convert.ToString(d2["course_name"]);
                    textBox1.Text = Convert.ToString(dr["first_name"]);
                    textBox2.Text = Convert.ToString(dr["middle_name"]);
                    textBox3.Text = Convert.ToString(dr["last_name"]);
                    dateTimePicker1.Value = Convert.ToDateTime(dr["birth_date"]);
                }    

                
                
            }
            con.Close();
        }

        private void subjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var assign_no = subjects.Rows[e.RowIndex].Cells[0].Value;
                Query query = new Query();

                int ind = subjects.CurrentCell.RowIndex;

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblAssignedSubject WHERE assign_no='" + Convert.ToInt32(assign_no) + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                    string select1 = "SELECT * FROM tblAssignedSubject WHERE assign_no = '" + Convert.ToInt32(assign_no) + "'";
                    string quer_string1 = "DELETE FROM tblAssignedSubject WHERE assign_no = '" + Convert.ToInt32(assign_no) + "'";
                    query.delete_assigned(select1, quer_string1);
                    subjects.Rows.RemoveAt(ind);
                }
                
            }
        }
    }
     }
