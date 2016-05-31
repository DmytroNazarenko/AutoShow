using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using CourseProject.Model;

namespace CourseProject.Controller
{
    /*--------Классы-для-десериализации-----*/
    class JsonData
    {
        public int total { get; set; }
        public double arithmeticMean { get; set; }
        public double interQuartileMean { get; set; }
        public Percentile percentiles { get; set; }
        public double[] prices { get; set; }
        public int[] classifieds { get; set; }
    }
    class Percentile
    {
        public Dictionary<string, double> a;
    }
    class Item
    {
        public string name;
        public int value;
    } 
    /*--------------------------------------*/


    static class ApiHandler
        // Класс для работы с API сайта
    {
        
        public static double GenerateArray(Auto auto)
        //Генерация массива для статистики из исходных данных    
        {
            string url = ConvertToUrl(auto);
            if (url != "-1") return ArrayCreating(GET(url));
            else return -1;
        }

        static string ConvertToUrl(Auto auto)
        //Создаем URL GET-запроса
        {
            int brandValue = 0, modelValue  = 0;
            try
            {
                var brandJSON = GET("http://api.auto.ria.com/categories/1/marks");
                Item[] data = JsonConvert.DeserializeObject<Item[]>(brandJSON);
                foreach (Item item in data)
                    if (item.name == auto.Brand)
                    {
                        brandValue = item.value;
                        break;
                    }
                //data.Single(x => x.name == auto.Brand);
            }
            catch
            {
                return "-1";}
            try
            {
                var modelJson = GET("http://api.auto.ria.com/categories/1/marks/" + brandValue + "/models");
                Item[] data1 = JsonConvert.DeserializeObject<Item[]>(modelJson);
                foreach (Item item in data1)
                    if (item.name == auto.Model)
                    {
                        modelValue = item.value;
                        break;
                    }
                //data1.Single(x => x.name == auto.Brand);
            }
            catch
            {
                return "-1";
            }
            int r1 = (int)(0.9*auto.Distance);
            int r2 = (int)(1.1*auto.Distance);
            if (modelValue == 0 || brandValue == 0) return "-1";
            string resultUrl = "http://api.auto.ria.com/average?marka_id="+brandValue+"&model_id="+modelValue+ "&raceInt="+r1+ "&raceInt="+r2;
            return resultUrl;
        }

        static double ArrayCreating(string json)
        //Создание массива статистики из десериализованного JSON
        {
            
            //List<double>[] list = new List<double>[13];
            //for (int i = 0; i < 13; i++) {
            //    list[i] = new List<double>();
            //}
            //double[] resultArray = new double[13];
            try
            {
                JsonData data = JsonConvert.DeserializeObject<JsonData>(json);
                return data.arithmeticMean;
            }
            catch
            {   
                return -1;
            }
            //var v =  data.classifieds.Where(x => NoteDateParser.MonthCount(x) <= 12);
            //for (int i = 0; i < data.classifieds.Length; i++ )
            //{                
            //    int delta = NoteDateParser.MonthCount(data.classifieds[i]);
            //    if (delta <= 12) list[delta].Add(data.prices[i]);
            //}
            
            //for (int i = 0; i < list.Length; i++)
            //    if (list[i].Count != 0) resultArray[i] = list[i].Average();
            
        }

        static string GET(string Url, string Data = null)   
        //Получение GET запроса в виде JSON                 
        {
               
                WebRequest req = (Data == null) ? WebRequest.Create(Url) : WebRequest.Create(Url + "?" + Data);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                string Out = "";
                if (stream != null)
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        Out = sr.ReadToEnd();
                    }
                return Out;
           
        }
    }
}
