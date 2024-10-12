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
using StudentsMS_Tano.Sql_Controls;
using System.Net.NetworkInformation;

namespace StudentsMS_Tano
{
    public partial class Student_info : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-FDL70D0\\SQLEXPRESS;Initial Catalog=DBStudentMS_Tano;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Student_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Control control = new Control();
            control.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Student_info_Load(object sender, EventArgs e)
        {
            Get_Data();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Delete";
            btn.Name = "Delete";
            btn.Text = "Delete";

           
            btn.DefaultCellStyle.BackColor = Color.Red;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.HeaderText = "Update";
            btn2.Name = "Update";
            btn2.Text = "Update";
            btn.DefaultCellStyle.BackColor = Color.RoyalBlue;
            btn.DefaultCellStyle.ForeColor = Color.White;
            btn2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn2);


        }

        public void Get_Data()
        {
            con.Open();

            SqlDataAdapter sd = new SqlDataAdapter("SELECT  student_no, first_name, last_name, course_id FROM tblStudent", con);
            DataTable dt1 = new DataTable();
            sd.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                SqlDataAdapter sd1 = new SqlDataAdapter("SELECT course_name FROM tblCourse WHERE course_id='" + dr["course_id"] + "' ", con);
                DataTable dt = new DataTable();
                sd1.Fill(dt);

                int student_no = Convert.ToInt32(dr["student_no"]);
                string fname = Convert.ToString(dr["first_name"]);
                string lname = Convert.ToString(dr["last_name"]);

                SqlCommand cmdd = con.CreateCommand();
                cmdd.CommandType = CommandType.Text;
                cmdd.CommandText = "SELECT COUNT(*) FROM tblAssignedSubject WHERE student_no ='" + dr["student_no"] + "' ";
              

                string fullname = $"{fname} {lname}";
                foreach (DataRow dr1 in dt.Rows)
                {


                    dataGridView1.Rows.Add(student_no, fullname, dr1["course_name"], cmdd.ExecuteScalar());
                }
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var student_no = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Query query = new Query();

                int ind = dataGridView1.CurrentCell.RowIndex;

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblAssignedSubject WHERE student_no='" + Convert.ToInt32(student_no) + "'";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                    string select1 = "SELECT * FROM tblAssignedSubject WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    string quer_string1 = "DELETE FROM tblAssignedSubject WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    query.delete_assigned(select1, quer_string1);

                  

                    string select = "SELECT * FROM tblStudent WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    string quer_string = "DELETE FROM tblStudent WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    query.delete(select, quer_string);
                    dataGridView1.Rows.RemoveAt(ind);                  

                }
                else 
                {
                    con.Close();
                    string select2 = "SELECT * FROM tblStudent WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    string quer_string2 = "DELETE FROM tblStudent WHERE student_no = '" + Convert.ToInt32(student_no) + "'";
                    query.delete(select2, quer_string2);
                    dataGridView1.Rows.RemoveAt(ind);
                }
            }
            else if (e.ColumnIndex == 5)
            {
                var student_no = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Query query = new Query();

                int ind = dataGridView1.CurrentCell.RowIndex;

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT student_no FROM tblStudent WHERE student_no='" + Convert.ToInt32(student_no) + "'";
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sd.Fill(dt);
                Control control = new Control();
                foreach (DataRow dr in dt.Rows)
                {
                    
                    control.set_num(dr["student_no"]);
                }
                con.Close();
                Subjects subjv = new Subjects();

                subjv.get_valid("updating");

                this.Hide();
                control.Show();
                control.get_validate("updating");

            }
        }
    }
}
