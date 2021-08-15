using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class FormDB : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-QTLH4POT\SQLEXPRESS;Initial Catalog=Task;Integrated Security=True");
        public FormDB()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            try
            {
                if(connect.State != ConnectionState.Open)
                {
                connect.Open();
                }
                string query = "Select * from std";
                SqlCommand cmd = new SqlCommand(query, connect); 
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                student_list.Rows.Clear();

                int sn = 0;
                foreach (DataRow dataRow in dt.Rows)
                {
                    sn++;
                    student_list.Rows.Add(sn, dataRow["name"], dataRow["address"], dataRow["Contact"], dataRow["photos"], "Edit", dataRow["id"]);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if(connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        string file_Name = "";
        string path = "";
        private void add_Click(object sender, EventArgs e)
        { 
            try
            {
                if(connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string st_name = stdName.Text;
                string st_address = stdAddress.Text;
                string st_contact = stdPhone.Text;
                
                if(openFileDialog != null)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        file_Name = Path.GetFileName(openFileDialog.FileName);
                        path = Application.StartupPath + "\\UploadedImages\\" + file_Name;
                        if(!Directory.Exists(Application.StartupPath + "\\UploadedImages"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\UploadedImages");
                        }
                        File.Copy(openFileDialog.FileName, path);
                    }
                }

                string query = "Insert into std (Name, Address, Contact, photos) values (@parameter_name, @parameter_address, @parameter_phone, @parameter_photo)";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@parameter_name", st_name);
                cmd.Parameters.AddWithValue("@parameter_address", st_address);
                cmd.Parameters.AddWithValue("@parameter_phone", st_contact);
                cmd.Parameters.AddWithValue("@parameter_photo", path);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if(connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            DisplayData();
            //student_list.Rows.Add(student_list.Rows.Count+1, name, address);
        }

        

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                if(connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                if (student_list.SelectedRows.Count > 0)
                {
                    // for deleting single rows
                    //student_list.Rows.RemoveAt(student_list.SelectedRows[0].Index);

                    // for deleting multiple rows
                    foreach (DataGridViewRow row in student_list.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string query = "Delete from std where id = @parameter_id";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@parameter_id", id);
                        cmd.ExecuteNonQuery();
                        student_list.Rows.RemoveAt(row.Index);
                       // MessageBox.Show("Removed Successfully");
                    }
                    int i = 0; 
                    foreach(DataGridViewRow row in student_list.Rows)
                    {
                        i++;
                        row.Cells["SN"].Value = i;
                    }

                }
                else
                {
                    MessageBox.Show("Selected the row first");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if(connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        int student_id;
        private void student_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == student_list.Columns["Action"].Index)
            {
                //student_sn = Convert.ToInt32(student_list.CurrentRow.Cells["SN"].Value.ToString());
                string student_name = student_list.CurrentRow.Cells["Name"].Value.ToString();
                string student_address = student_list.CurrentRow.Cells["Address"].Value.ToString();
                string student_phone = student_list.CurrentRow.Cells["Contact"].Value.ToString();
                string photo_path = student_list.CurrentRow.Cells["FilePath"].Value.ToString();
                student_id = Convert.ToInt32(student_list.CurrentRow.Cells["id"].Value.ToString());
                //MessageBox.Show(student_id.ToString());


                stdName.Text = student_name;
                stdAddress.Text = student_address;
                stdPhone.Text = student_phone;
                photo.Image = Image.FromFile(photo_path);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_id != 0)
                {
                    if(connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    string st_name = stdName.Text;
                    string st_address = stdAddress.Text;
                    string st_contact = stdPhone.Text;
                    string query = "Update std set Name=@parameter_name, Address=@parameter_address, Contact=@parameter_phone where id=@parameter_id";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@parameter_name", st_name);
                    cmd.Parameters.AddWithValue("@parameter_address", st_address);
                    cmd.Parameters.AddWithValue("@parameter_phone", st_contact);
                    //cmd.Parameters.AddWithValue("@parameter_photo", path);
                    cmd.Parameters.AddWithValue("@parameter_id", student_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    MessageBox.Show(path);

                    stdName.Text = "";
                    stdAddress.Text = "";
                    stdPhone.Text = "";
                    student_id = 0; 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                if(connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            DisplayData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            stdName.Text = "";
            stdAddress.Text = "";
            stdPhone.Text = "";
            student_id = 0;
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void SelectPhoto_Click(object sender, EventArgs e)
        {
            //openFileDialog.Filter = "Images only |(*.jpeg)|(*.jpg)|*.txt|All files (*.*)|*.*";
            openFileDialog.Filter = "Images only. |*jpg;|*.jpeg;|*.png";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Cancel Dialog Box");
            }
        }
    }
}
