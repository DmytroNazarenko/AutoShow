using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View
{
    public partial class AutoInformation : Form
    {
        // Форма отображения информации об авто
        public AutoInformation(Auto auto)
        {
            InitializeComponent();
            var user = Controller.DataHandler.GetUserById(auto.SellerID);
            nameLabel.Text = user.Name;
            surnameLabel.Text = user.Surname;
            phoneLabel.Text = user.Phone;
            brandLabel.Text = auto.Brand;
            modelLabel.Text = auto.Model;
            distLabel.Text = auto.Distance.ToString();
            engineLabel.Text = auto.Engine.ToString();
            priceLabel.Text = auto.Price.ToString();
            colorLabel.Text = auto.Color;
            statusLabel.Text = (auto.Status == 0) ? "В активном поиске" : "Продано";
        }
    }
}
