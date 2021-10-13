using Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer
{
    public partial class ModuleInfo : Form
    {


       CRUD_operations operations=new CRUD_operations();
      
        public ModuleInfo()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModuleInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operations.displayModule();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtModuleCode.Text) || String.IsNullOrEmpty(txtModuleDescipt.Text) || String.IsNullOrEmpty(txtModuleName.Text) || String.IsNullOrEmpty(txtLinks.Text))
            {
                if (String.IsNullOrEmpty(txtModuleCode.Text))
                {
                    txtModuleCode.BackColor = Color.Red;
                }
                else
                {
                    txtModuleCode.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtModuleName.Text))
                {
                    txtModuleName.BackColor = Color.Red;
                }
                else
                {
                    txtModuleName.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtModuleDescipt.Text))
                {
                    txtModuleDescipt.BackColor = Color.Red;
                }
                else
                {
                    txtModuleDescipt.BackColor = SystemColors.Window;
                }
                if (String.IsNullOrEmpty(txtLinks.Text))
                {
                    txtLinks.BackColor = Color.Red;
                }
                else
                {
                    txtLinks.BackColor = SystemColors.Window;
                }
                MessageBox.Show("Enter values for all required textboxes");
            }
            else
            {
                string msg = operations.addModule(txtModuleCode.Text, txtModuleName.Text, txtModuleDescipt.Text, txtLinks.Text);
                MessageBox.Show(msg);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModuleCode.Clear();
            txtModuleName.Clear();
            txtModuleDescipt.Clear();
            txtLinks.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string msg = operations.updateModule(txtModuleCode.Text, txtModuleName.Text, txtModuleDescipt.Text, txtLinks.Text);
                MessageBox.Show(msg);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                string msg = operations.deleteModule(txtSearch.Text);
                MessageBox.Show(msg);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagingInfo managingInfo=new ManagingInfo();
            managingInfo.Show();
            this.Hide();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = operations.moduleSearch(txtSearch.Text) ;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtModuleCode.Text = row.Cells[0].Value.ToString();
                txtModuleName.Text = row.Cells[1].Value.ToString();
                txtModuleDescipt.Text = row.Cells[2].Value.ToString();
                txtLinks.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
