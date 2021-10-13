using Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer;
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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Make sure that password and confirm password are the same!!");
                    textBox2.BackColor = Color.Red;
                    textBox3.BackColor = Color.Red;
                }
                else
                {
                    FileHandler fh = new FileHandler();
                    fh.createFile(textBox1.Text, textBox2.Text);
                    MessageBox.Show("Account Created");
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                   
                }
            }
            else
            {
                MessageBox.Show("Enter values for all textboxes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
          Hide();
           

        }
    }
}
