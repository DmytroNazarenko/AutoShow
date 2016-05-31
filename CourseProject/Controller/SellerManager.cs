using CourseProject.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CourseProject.Controller
{
    static class SellerManager
        //Класс для работы с продавцом
    {
        static SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename='C:\Users\Дмитрий\documents\visual studio 2015\Projects\CourseProject\CourseProject\Autoshow.mdf';Integrated Security = True; Connect Timeout = 30");
        static SqlCommand cmd = new SqlCommand("", cn);
        public static void DeleteAuto(int autoId)
            //Удаление авто из бд
        {
            cn.Open();
            cmd.CommandText = "delete from Auto where id = " + autoId;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static BindingList<Auto> LoadAutoList(int userid)
            //Формирование списка автомобилей продавца
        {
            cn.Open();
            string sqlQuery= "select * from Auto where SubjectID =" + userid;
            SqlDataAdapter SDA = new SqlDataAdapter(sqlQuery, cn);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cn.Close();

            

            BindingList<Auto> res = new BindingList<Auto>(dt.AsEnumerable().Select(r => new Auto
            {
                ID = r.Field<int>("ID"),
                Brand = r.Field<string>("Brand"),
                Model = r.Field<string>("Model"),
                Price = (r.IsNull("Price")) ? 0 : r.Field<int>("Price"),
                Color = r.Field<string>("Color"),
                Distance = (r.IsNull("Distance")) ? 0 : r.Field<int>("Distance"),
                Engine = (r.IsNull("EngineCapacity")) ? 0.0 : (double)r.Field<Decimal>("EngineCapacity"),
                SellerID = r.Field<int>("SubjectID"),
                //Status = r.Field<byte>("Status"),
            }).ToList());
            
            
            return res;
        }
        public static void UpdateAuto(Auto auto)
            //Изменение автомобиля в бд
        {
            cn.Open();
            cmd.CommandText = "update Auto set Price = '"+auto.Price+"', Color = '"+auto.Color+"', Distance = "+auto.Distance+", EngineCapacity = "+auto.Engine.ToString(System.Globalization.CultureInfo.InvariantCulture) + " where Id ="+auto.ID;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        //static void AddAuto(string Brand, string Model, int Price, string Color = null, int Distanse = 0, int EngineCapacity = 0)
        //{
        //    cn.Open();
        //    cmd.CommandText = "insert into Auto(Brand,model,price,color) Values ('Mercedes', 'S600', 850000, 'silver')";
        //    cn.Close();
        //}

        public static void AddAuto(Auto auto)
            //Добавление авто в бд
        {
            cn.Open();
            cmd.CommandText = "insert into Auto(Brand,model,price,color,distance,enginecapacity,SubjectId) Values ('" + auto.Brand + "','" + auto.Model + "', " + auto.Price + ", '" + auto.Color + "', " + auto.Distance + ", " + auto.Engine.ToString(System.Globalization.CultureInfo.InvariantCulture) + " ," + auto.SellerID + ")";
            cmd.ExecuteNonQuery();
            cn.Close();
        }



       
    }
}
