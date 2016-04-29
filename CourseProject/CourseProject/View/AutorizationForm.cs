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

namespace CourseProject.View
{
    public partial class AutorizationForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Дмитрий\documents\visual studio 2015\Projects\CourseProject\CourseProject\Autoshow.mdf';Integrated Security = True; Connect Timeout = 30");
        
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            Int32 count = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("select Count(*) from Subject where Email = '" + loginTextBox.Text + "' and Password = '" + passwordTextBox.Text + "'", cn);
                cn.Open();
                    //where Email = '" + loginTextBox.Text + "' and Password = '" + passwordTextBox.Text + "'", cn);
                count = (Int32) cmd.ExecuteScalar();
            }
            catch { }
            finally
            {
                cn.Close();
            }
            if (count != 0)
            {
                this.Hide();
                clientForm.Show();
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
            this.Hide();
            signUp.Show();
        }
    }
}
