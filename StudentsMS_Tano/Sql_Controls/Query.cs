using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace StudentsMS_Tano.Sql_Controls
{
    public class Query : Connection
    {
        public SqlCommand cmd;
        public static void main(string[] args)
        {
            Connection connection = new Connection();
            
        }

        // Adding Data
        public void insert(string query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }  
        }

        // Delete Data
        public void delete(string select_query, string delete_query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = select_query;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
      
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = delete_query;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted");
                        con.Close();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void delete1(string select_query, string delete_query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = select_query;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                    
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = delete_query;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Updating Data
        public void update(string query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Submitted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        // Selecting Data
        public void select(string query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void get_data(string query, DataGridView datagrid)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //Get Subject Number

        public void get_data2(string query, ComboBox combo)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                combo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public void delete_assigned(string select_query, string delete_query)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = select_query;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                  
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = delete_query;
                    cmd.ExecuteNonQuery();
                        con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    


}
