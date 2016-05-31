using CourseProject.Controller;
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
    public partial class AddAutoForm : Form
        //Форма добавления авто
    {
        Auto resAuto;
        int SellerID;
        bool Updating = false;
        public AddAutoForm(int id, Auto auto = null)
        {
            InitializeComponent();
            SellerID = id;
            brandBox.DropDownStyle = ComboBoxStyle.DropDownList;  
            if (auto != null)
            {
                Updating = true;
                colorBox.Text = auto.Color;
                distanceBox.Text = auto.Distance.ToString();
                priceBox.Text = auto.Price.ToString();
                brandBox.Enabled = false;
                modelBox.Text = auto.Model;
                modelBox.Enabled = false;
                brandBox.SelectedItem = auto.Brand;
                engineCapacityTrackbar.Value = (int)(auto.Engine*10);
                engineValue.Text = auto.Engine.ToString() + "куб.м";
                addButton.Text = "Изменить";
            }
            engineValue.Text = 0 + " куб.м";
            resAuto = auto;       
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!Updating && adding())
            {
                SellerManager.AddAuto(resAuto);
                this.Close();
            }
            if (Updating)
            {
                if (updating())
                {
                    SellerManager.UpdateAuto(resAuto);
                    this.Close();
                }
            }
        }

        private bool adding()
        {
            bool b = true;
            string brand = null, model = null, color = null;
            int price = 0, distance = 0;
            double engine = 0;
            if (brandBox.SelectedItem != null) brand = brandBox.SelectedItem.ToString();
            else { brandBox.BackColor = Color.Red; b = false;}
            if (modelBox.Text != "") model = modelBox.Text;
            else { modelBox.BackColor = Color.Red; b = false; }
            if (colorBox.Text != "") color = colorBox.Text;
            else { colorBox.BackColor = Color.Red; b = false; }
            try
            {
                price = Convert.ToInt32(priceBox.Text);
                if (price < 0 || price > 5000000) throw new Exception();
            }
            catch { priceBox.BackColor = Color.Red; b = false; }
            try
            {
                 distance = Convert.ToInt32(distanceBox.Text);
                if (distance < 0 || distance > 5000000) throw new Exception();
            }
            catch { distanceBox.BackColor = Color.Red; b = false; }
            engine = (engineCapacityTrackbar.Value/10.0);
            
            resAuto = new Auto(brand, model, color, price, distance, engine,0,SellerID);
            return b;
        }
        private bool updating()
        {
            bool b = true;
            if (colorBox.Text != "") resAuto.Color = colorBox.Text;
            else { colorBox.BackColor = Color.Red; b = false; }
            try
            {
                int price = Convert.ToInt32(priceBox.Text);
                if (price < 0 || price > 5000000) throw new Exception();
                resAuto.Price = price;
            }
            catch { priceBox.BackColor = Color.Red; b = false; }
            try
            {
                int distance = Convert.ToInt32(distanceBox.Text);
                if (distance < 0 || distance > 5000000) throw new Exception();
                resAuto.Distance = distance;
            }
            catch { distanceBox.BackColor = Color.Red; b = false; }
            resAuto.Engine = (engineCapacityTrackbar.Value / 10.0);
            return b;
        }

        private void engineCapacityTrackbar_Scroll(object sender, EventArgs e)
        {
            engineValue.Text = (engineCapacityTrackbar.Value / 10.0).ToString();
        }
    }
}
