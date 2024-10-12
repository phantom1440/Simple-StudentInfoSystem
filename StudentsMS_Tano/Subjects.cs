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

namespace StudentsMS_Tano
{
    public partial class Subjects : Form
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-FDL70D0\\SQLEXPRESS;Initial Catalog=DBStudentMS_Tano;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBStudentMS_TanoDataSet.tblSubject' table. You can move, or remove it, as needed.
            this.tblSubjectTableAdapter.Fill(this.dBStudentMS_TanoDataSet.tblSubject);

            string sql_query = "Select * From tblSubject";

            var query = new Query();
            query.get_data(sql_query, dataGridView1); 

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Select";
            btn.Name = "Select";
            btn.Text = "Select";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control c = new Control();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tblAssignedSubject WHERE student_no = '" + Convert.ToInt32(iddtxt.Text) + "'";
           
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                con.Close();
              
                c.set_num(iddtxt.Text);
                
                
                if (validd.Text == "updating")
                {
                    c.get_validate(validd.Text);
                }
                else
                {
                    c.get_validate("inserting");
                }
                this.Close();
                c.Show();

            }  
            else
            {
                MessageBox.Show("Select Subject First");
                con.Close();
            }
            con.Close();

            {


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            var query = new Query();

       //    int ind = dataGridView1.CurrentCell.RowIndex;

            if (e.ColumnIndex == 2)
            {
                if(iddtxt.Text == "")
                {
                    var idd = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    string query_str = "INSERT INTO tblAssignedSubject (subject_no) VALUES ('" + Convert.ToInt32(idd) + "')";
                    query.insert(query_str);
                  //  dataGridView1.Rows.RemoveAt(ind);
                }
                else
                {
                    var idd = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    string query_str = "INSERT INTO tblAssignedSubject (student_no ,subject_no) VALUES ('"+ Convert.ToInt32(iddtxt.Text) +"','" + Convert.ToInt32(idd) + "')";
                    query.insert(query_str);
                  //  dataGridView1.Rows.RemoveAt(ind);
                }
            }
        }

        public void set_num(object num)
        {
            iddtxt.Text = Convert.ToString(num);
        }

        public void get_valid(string str)
        {
            validd.Text = str;
        }
    }
}
