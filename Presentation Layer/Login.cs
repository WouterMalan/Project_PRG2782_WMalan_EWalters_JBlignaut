using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer
{
    public partial class Login : Form
    {
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
            {
                ManagingInfo mi = new ManagingInfo();
                this.Hide();
                mi.Show();
                
            }
            else
            {
                MessageBox.Show("The username and/or password is incorrect");
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;  
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (StreamReader ac = new StreamReader("Accounts.txt"))
            {
                string line = "";
                while ((line = ac.ReadLine()) != null)
                {
                    string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    users.Add(components[0]);
                    pass.Add(components[1]);
                }
            }
           
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
        }
    }
}
