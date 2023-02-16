using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDataImport
{
    public partial class ImportTask : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DatabaseConnection db = new DatabaseConnection();
        public ImportTask()
        {
            InitializeComponent();
            conn = new SqlConnection(db.GetConnection());
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;
            BindDAtaCSV(textBox1.Text);
        }
        private void BindDAtaCSV(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstline = lines[0];
                string[] headerlabels = firstline.Split(',');
                foreach (string headerword in headerlabels)
                {
                    dt.Columns.Add(new DataColumn(headerword));
                }
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] datawords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerword in headerlabels)
                    {
                        dr[headerword] = datawords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                StudentItem.DataSource = dt;
            }

        }
    

        private void SAVE_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < StudentItem.Rows.Count - 1; i++)
            {
                conn.Open();
                cmd = new SqlCommand("Insert into syStudent(ExternalStudentID,FirstName,LastName,DOB,SSN,Address,City,State,Email,MaritalStatus) values(@externalstudentid,@firstname,@lastname,@dob,@ssn,@Adddress,@City,@State,@Email,@MaritalStatus)", conn);
                cmd.Parameters.AddWithValue("@externalstudentid", StudentItem.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@firstname", StudentItem.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@lastname", StudentItem.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@dob", StudentItem.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@ssn", StudentItem.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@Adddress", StudentItem.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@City", StudentItem.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@State", StudentItem.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@Email", StudentItem.Rows[i].Cells[8].Value);
                cmd.Parameters.AddWithValue("@MaritalStatus", StudentItem.Rows[i].Cells[9].Value);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Saved","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            this.Close();
        }

    }
    }

