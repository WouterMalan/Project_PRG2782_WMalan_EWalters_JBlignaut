using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer
{
    public partial class ManagingInfo : Form
    {
        public ManagingInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInfo studentInfo= new StudentInfo();
            studentInfo.Show();
            this.Hide();
           

        }

        private void btnManagingModule_Click(object sender, EventArgs e)
        {
            ModuleInfo moduleInfo= new ModuleInfo();
            moduleInfo.Show();

            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();

            
        }
    }
}
