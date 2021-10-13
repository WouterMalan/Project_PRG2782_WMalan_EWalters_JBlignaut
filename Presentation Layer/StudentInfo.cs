using Project_PRG2782_WMalan_EWalters_JBlignaut.Business_Layer;
using Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer;
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

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer
{
    public partial class StudentInfo : Form
    {
        CRUD_operations operations1=new CRUD_operations();
       

       

        public StudentInfo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            lblEnable.Visible = false;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtStudentNumber.Text = row.Cells[0].Value.ToString();
                txtStudentFullname.Text = row.Cells[1].Value.ToString();
              
                cmbGender.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
                cmbModuleCode.Text = row.Cells[6].Value.ToString();

                lblEnable.Visible = true;

                txtAddress.Enabled = false;
                
                txtPhone.Enabled = false;
                txtStudentFullname.Enabled = false;
                txtStudentNumber.Enabled = false;
                cmbGender.Enabled = false;
                cmbModuleCode.Enabled = false;

                try
                {
                    Student student = studentBindingSource.Current as Student;
                    if (student!=null)
                    {
                        if (!string.IsNullOrEmpty(student.Photo))
                        {
                            pictureBox1.Image = Image.FromFile(student.Photo);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operations1.studentSearch(int.Parse(txtSearch.Text));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CRUD_operations operations = new CRUD_operations();
            dataGridView1.DataSource = operations.displayStudent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtStudentNumber.Clear();
            txtStudentFullname.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();

            cmbModuleCode.SelectedIndex = -1;

            lblEnable.Visible = false;

            txtAddress.Enabled = true;
            
            txtPhone.Enabled = true;
            txtStudentFullname.Enabled = true;
            txtStudentNumber.Enabled = true;
            cmbGender.Enabled = true;
            cmbModuleCode.Enabled = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagingInfo managing=new ManagingInfo();
            managing.Show();
            this.Hide();
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "Images|*.jpg;*.png;*.jpeg", ValidateNames = true })

            {
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(odf.FileName);
                    Student student=studentBindingSource.Current as Student;
                    if (student!=null)
                    {
                        student.Photo = Image.FromFile(odf.FileName).ToString();
                    }

                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentNumber.Text) || String.IsNullOrEmpty(txtStudentFullname.Text) || String.IsNullOrEmpty(cmbGender.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(cmbModuleCode.Text))
            {
                if (String.IsNullOrEmpty(txtStudentNumber.Text))
                {
                    txtStudentNumber.BackColor = Color.Red;
                }
                else
                {
                    txtStudentNumber.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtStudentFullname.Text))
                {
                    txtStudentFullname.BackColor = Color.Red;
                }
                else
                {
                    txtStudentFullname.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(cmbGender.Text))
                {
                    cmbGender.BackColor = Color.Red;
                }
                else
                {
                    cmbGender.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtAddress.Text))
                {
                    txtAddress.BackColor = Color.Red;
                }
                else
                {
                    txtAddress.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtPhone.Text))
                {
                    txtPhone.BackColor = Color.Red;
                }
                else
                {
                    txtPhone.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(cmbModuleCode.Text))
                {
                    cmbModuleCode.BackColor = Color.Red;
                }
                else
                {
                    cmbModuleCode.BackColor = SystemColors.Window;
                }
               

                MessageBox.Show("Enter values for all required textboxes");
            }
            else
            {
                CRUD_operations operations = new CRUD_operations();
                if (pictureBox1.Image == null)
                {
                    string msg = operations.addStudent(int.Parse(txtStudentNumber.Text), txtStudentFullname.Text, this.dateTimePicker1.Text, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCode.Text);
                      MessageBox.Show(msg);
                }
                else
                {
                    string msg = operations.addStudent(int.Parse(txtStudentNumber.Text), txtStudentFullname.Text, this.dateTimePicker1.Text, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCode.Text, pictureBox1.Image);
                    MessageBox.Show(msg);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD_operations operations = new CRUD_operations();
                string msg = operations.deleteStudent(int.Parse(txtSearch.Text));
                MessageBox.Show(msg);
            }
            catch
            {
                MessageBox.Show("Could not delete, there seems to be a problem");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD_operations operations = new CRUD_operations();
                if (pictureBox1.Image == null)
                {
                    string msg = operations.updateStudent(int.Parse(txtStudentNumber.Text), txtStudentFullname.Text, this.dateTimePicker1.Text, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCode.Text);
                      MessageBox.Show(msg);
                }
                else
                {
                    string msg = operations.updateStudent(int.Parse(txtStudentNumber.Text), txtStudentFullname.Text, this.dateTimePicker1.Text, cmbGender.Text, txtPhone.Text, txtAddress.Text, cmbModuleCode.Text, pictureBox1.Image);
                    MessageBox.Show(msg);
                }
            }
            catch
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar))&& (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
