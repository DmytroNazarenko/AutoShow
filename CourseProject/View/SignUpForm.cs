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
    public partial class SignUpForm : Form
        //Форма регистрации
    {
        
        SqlCommand cmd = new SqlCommand();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Controller.DataHandler.UserRegistration(firstNameTextBox.Text, secondNameTextBox.Text, emailTextBox.Text,
                passwordTextBox.Text,
                phoneTextBox.Text, radioButton1.Checked) == 0)
            {
                this.Close();
            }
            else MessageBox.Show("Неправильный ввод");
        }
    }
}
