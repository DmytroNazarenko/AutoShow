using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace CourseProject.Controller
{
    static class NoteDateParser
    //Класс для извлечения даты с сайта
    {
        
        static DateTime parseForDate(int noteId)
            //Парсинг сайта на дату заметки
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument doc = htmlWeb.Load("https://auto.ria.com/auto___"+noteId+".html");
            HtmlNodeCollection elements = doc.DocumentNode.SelectNodes("//strong[@id='final_page__add_date']");

            string result = null;
            if (elements != null) result = elements[0].InnerText.Split(' ')[0];
            
            DateTime d = DateTime.Parse(result);
            return d;         
        }

        public static int MonthCount(int noteID)
            //Расчет времени
        {
            DateTime cur = DateTime.Now;
            DateTime res = parseForDate(noteID);
            return (cur.Year - res.Year)*12 + cur.Month - res.Month;            
        }
    }
}
