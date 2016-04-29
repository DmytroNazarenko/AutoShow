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
    {
        SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Дмитрий\documents\visual studio 2015\Projects\CourseProject\CourseProject\Autoshow.mdf';Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd = new SqlCommand();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "" && emailTextBox.Text != "")
            {
                try
                {
                    cn.Open();
                    //SqlCommand cmd = new SqlCommand("update Subject set FirstName='1'", cn);
                    //cmd.CommandText
                    cmd.CommandText = "insert into Subject (FirstName, SecondName, Email, Password) VALUES ('" + firstNameTextBox.Text + "','" + secondNameTextBox.Text + "','" + emailTextBox.Text + "','" + passwordTextBox.Text + "')";
                    //cmd.CommandText = "update Subject set FirstName='1' ";
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    
                }
                catch
                {
                    MessageBox.Show("aaa");
                    //throw new Exception();
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
