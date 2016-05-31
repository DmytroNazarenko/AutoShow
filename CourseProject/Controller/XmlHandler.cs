using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CourseProject.Controller
{
    static class XmlHandler
    {
        public static void Create()
        //Создание xml файла
        {
            using (var writer = new XmlTextWriter("Statistic.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("Statistic");
                writer.WriteEndElement();
            }
        }
        public static void Save(Auto _auto, User _client, User _seller)
        //Запись заявки в xml файл
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Purchases.xml");
            var purchase = doc.CreateElement("Purchase");
            purchase.SetAttribute("ClientId", _client.ID.ToString());
            purchase.SetAttribute("SellerId", _seller.ID.ToString());
            var date = doc.CreateElement("Date");
            date.InnerText = DateTime.Now.ToString();
            purchase.AppendChild(date);
            var seller = doc.CreateElement("Seller");
            var name = doc.CreateElement("Name");
            name.InnerText = _seller.Name;
            var surname = doc.CreateElement("Surname");
            surname.InnerText = _seller.Surname;
            var phone = doc.CreateElement("Phone");
            phone.InnerText = _seller.Phone;
            seller.AppendChild(name);
            seller.AppendChild(surname);
            seller.AppendChild(phone);
            purchase.AppendChild(seller);

            var clientName = doc.CreateElement("Name");
            clientName.InnerText = _client.Name;
            var clientSurname = doc.CreateElement("Surname");
            clientSurname.InnerText = _client.Surname;
            var client = doc.CreateElement("Client");
            client.AppendChild(clientSurname);
            client.AppendChild(clientName);
            purchase.AppendChild(client);
            var auto = doc.CreateElement("Auto");           
            var autoBrand = doc.CreateElement("Brand");
            autoBrand.InnerText = _auto.Brand;
            var autoModel = doc.CreateElement("Model");
            autoModel.InnerText = _auto.Model;
            var autoPrice = doc.CreateElement("Price");
            autoPrice.InnerText = _auto.Price.ToString();
            auto.AppendChild(autoBrand);
            auto.AppendChild(autoModel);
            auto.AppendChild(autoPrice);
            purchase.AppendChild(auto);

            doc.DocumentElement.AppendChild(purchase);
            doc.Save("Purchases.xml");
        }
        static void Add(Auto auto, double statistic)
        //Запись статистики в xml файл
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Statistic.xml");
            var item = doc.CreateElement("Item");
            item.SetAttribute("Brand", auto.Brand);
            item.SetAttribute("Model", auto.Model);
            item.SetAttribute("Date", DateTime.Now.ToString());
            item.InnerText = statistic.ToString();
            doc.DocumentElement.AppendChild(item);
            doc.Save("Statistic.xml");
        }

        public static void LoadNewStatistic(Auto auto, double statistic)
        //Обновление статистики
        {
            XElement root = XElement.Load("Statistic.xml");
            try
            {
                var x = root.Elements("Item").Where(el => (string) el.Attribute("Brand") == auto.Brand
                                                          && (string) el.Attribute("Model") == auto.Model)
                    .Max(el => Convert.ToDateTime((string) el.Attribute("Date")));
                var now = DateTime.Now;
                if ((now.Year - x.Year)*12 + now.Month - x.Month > 0) Add(auto, statistic);
            }
            catch
            {
                Add(auto, statistic);
            }
        }

        public static double[] GetWholeStatistic(Auto auto)
        //Загрузка всей статистики автомобиля
        {
            XElement root = XElement.Load("Statistic.xml");
            var x = root.Elements("Item").Where(el => (string) el.Attribute("Brand") == auto.Brand
                                                      && (string) el.Attribute("Model") == 
                                                      auto.Model).OrderBy(el => 
                                                      Convert.ToDateTime((string)el.Attribute("Date"))).
                                                      Select(el => Convert.ToDouble(el.Value)).ToArray();

            return x;
        }
        static IEnumerable<XElement> LoadUserPurchasesInXML(int userID)
        //Загрузка данных из файла в виде xml
        {
            XElement root = XElement.Load("Purchases.xml");
            var x = from el in root.Elements("Purchase")
                where (string)el.Attribute("SellerId") == userID.ToString() || (string)el.Attribute("ClientId") == userID.ToString()
                select el;
            return x;
        }

        public static void LoadUserPurchases(int userID)
        //Обновление файла заявок
        { 
            IEnumerable<XElement> xml = (IEnumerable<XElement>)LoadUserPurchasesInXML(userID);
            using (var sw = new StreamWriter("MyPurchases.txt", false))
            {
                foreach (XElement x in xml)
                {
                    sw.WriteLine(x.Element("Date").Value);
                    sw.WriteLine("Имя, фамилия: "+x.Element("Seller").Element("Name").Value + " " +
                        x.Element("Seller").Element("Surname").Value + ". " +
                        "Телефон: " + x.Element("Seller").Element("Phone").Value);
                    sw.WriteLine("Имя, фамилия: " + x.Element("Client").Element("Name").Value + " " +
                        x.Element("Client").Element("Surname").Value + ". ");
                    sw.WriteLine("Авто: " + x.Element("Auto").Element("Brand").Value + " " 
                        + x.Element("Auto").Element("Model").Value + " Price:" + x.Element("Auto").Element("Brand").Value+"$");
                    sw.WriteLine();
                }
            }
        }
    }
}
