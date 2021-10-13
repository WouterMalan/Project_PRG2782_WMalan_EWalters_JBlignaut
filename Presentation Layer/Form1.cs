using Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           Login login=new Login();
            this.Hide();
            login.Show();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount=new CreateAccount();
            createAccount.Show();
            this.Hide();
           

        }
    }
}
