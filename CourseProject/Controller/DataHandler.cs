using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CourseProject.Controller
{
    static class DataHandler
    //Класс для работы с данными
    {
        static string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Дмитрий\documents\visual studio 2015\Projects\CourseProject\CourseProject\Autoshow.mdf';Integrated Security = True; Connect Timeout = 30";
        private static SqlConnection cn = new SqlConnection(connectionString);
        static SqlCommand cmd = new SqlCommand("");

        public static List<Auto> SelectAutosByParameter(int price1, int price2, string brand, int dist1, int dist2, double engine1, double engine2)
        //Метод подбора авто по критериям
        {
            List<Auto> autoList = new List<Auto>();

            string price = (price1 == 0 && price2 == 0)? "" :" and Price >=" + price1 + " and Price <= " + price2;
            string dist = (dist1 == 0 && dist2 == 0) ? "" : " and Distance >=" + dist1 + " and Distance <= " + dist2;
            string engine = (engine1 == 0.1 && engine2 == 0.1) ? "" : " and EngineCapacity >=" + engine1.ToString(System.Globalization.CultureInfo.InvariantCulture) + " and EngineCapacity <= " + engine2.ToString(System.Globalization.CultureInfo.InvariantCulture);
            
            string sql_query;
            if (brand == null || brand == "")
            {
                sql_query = "select * from Auto where Brand is not null" + price + dist + engine;
            }
            else
            {
                sql_query = "select * from Auto where Brand = '" + brand +"'"+price + dist + engine;
            }
            cn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(sql_query , cn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cn.Close();

            autoList = dt.AsEnumerable().Select(r => new Auto
            {
                Brand = r.Field<string>("Brand"),
                Model = r.Field<string>("Model"),
                Price = (r.IsNull("Price")) ? 0 : r.Field<int>("Price"),
                Color = r.Field<string>("Color"),
                Engine = (r.IsNull("EngineCapacity")) ? 0.0 : (double)r.Field<Decimal>("EngineCapacity"),
                Distance = (r.IsNull("Distance")) ? 0 : r.Field<int>("Distance"),
                SellerID = r.Field<int>("SubjectID"),
                //Status = r.Field<byte>("Status"),
            }).ToList();

            
            return autoList;
            
        }

        public static User GetUserById(int id)
        //Метод поиска пользователя по ID
        {
            string sql_query = "select * from Subject where id = " + id;
            cn.Open();
            var SDA = new SqlDataAdapter(sql_query, cn);
            var dt = new DataTable();
            SDA.Fill(dt);
            cn.Close();
            return dt.AsEnumerable().Select(x => new User(x.Field<string>("Name"), x.Field<string>("Surname"), x.Field<string>("Phone"), false, x.Field<int>("Id"))).Single();
        }

        //public static List<string> LoadBrands()
        //{
        //    List<string> brandList = new List<string>();
        //    cn.Open();
        //    SqlDataAdapter SDA = new SqlDataAdapter("select distinct Brand from Auto order by Brand", cn);
        //    DataTable dt = new DataTable();
        //    SDA.Fill(dt);
        //    cn.Close();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        brandList.Add(dt.Rows[i][0].ToString());
        //    }
        //    return brandList;
        //}


        public static byte UserRegistration(string name, string surname, string email, string password, string phone, bool client)
        //Регистрация пользователя в БД
        {
            byte ERROR_CODE = 0;
            if (password != "" && email != "" && phone != "" && name != "" && surname != "")
            {
                cn.Open();
                cmd.CommandText = "select Count(*) from Subject where email = '" + email + "'";
                if (cmd.ExecuteScalar().Equals(0))
                {
                    try
                    {
                        //cn.Open();
                        cmd.CommandText =
                            "insert into Subject (Name, Surname, Email, Password, Client, Phone) VALUES " +
                            "('" + name + "','" + surname + "','" + email + "','" + password + "'," +
                            Convert.ToByte(client) + ",'" + phone + "')";
                        cmd.Connection = cn;
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        ERROR_CODE = 1;
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Такой email уже занят");
                    ERROR_CODE = 2;
                }
            }
            else return 1;
            return ERROR_CODE;      
        }

        public static int IsUserExist(string login, string password, bool client)
           //Проверка на существование логина и пароля
        {
            int id = 0;
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (var cmd = new SqlCommand("select ID from Subject where Email = '" + login + "' and Password = '" +
                    password + "' and Client = " + Convert.ToByte(client), cn))
                    try
                    {
                        id = (int)cmd.ExecuteScalar();
                    }
                    catch { }               
            }
            return id;
            
        }
    }
}
