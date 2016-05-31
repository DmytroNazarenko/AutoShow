using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CourseProject.Controller;

namespace CourseProject.View
{
    public partial class AutorizationForm : Form
        //Форма авторизации
    {
        SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Дмитрий\documents\visual studio 2015\Projects\CourseProject\CourseProject\Autoshow.mdf';Integrated Security = True; Connect Timeout = 30");
        
        public AutorizationForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int userId = DataHandler.IsUserExist(loginTextBox.Text, passwordTextBox.Text, clientRadioButton.Checked);
            if (userId != 0)
            {
                if (clientRadioButton.Checked)
                {
                    ClientForm clientForm = new ClientForm(userId);
                    this.Hide();
                    clientForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    SellerForm sellerForm = new SellerForm(userId);
                    this.Hide();
                    sellerForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                loginTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            //this.Hide();
            this.Enabled = false;
            signUp.Show();
            signUp.FormClosed += SignUp_FormClosed;
       
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
        
    }
}
