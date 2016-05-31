using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.Controller;
using CourseProject.Model;

namespace CourseProject.View
{
    //Форма клиента
    public partial class ClientForm : Form
    {
        private int ID;
        public ClientForm(int id)
        {
            InitializeComponent();
            //XmlHandler.Create();
            //XmlHandler.Save(new Auto(), new User(), new User());
            //comboBox1.DataSource = DataHandler.LoadBrands();
            ID = id;
            brandBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectedAutosLV.FullRowSelect = true;
            minPrice.Value = minDist.Value = 0;
            minEngine.Value = 1;
            minEngineLabel.Text = "0.1 куб.м";
            maxPrice.Value = maxEngine.Value = maxDist.Value =  maxPrice.Maximum;
            maxVal.Text = (maxPrice.Maximum*1000).ToString() + '$';
            maxEngineLabel.Text = (maxEngine.Maximum/10.0).ToString() + " куб.м";
            maxDistLabel.Text = (maxDist.Maximum * 10).ToString() + " тыс.км";
        }

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Auto> autos = new List<Auto>();
            bool error = false;
            try
            { 
            string brand = (brandBox.SelectedItem == null) ? null : brandBox.SelectedItem.ToString();
            autos = DataHandler.SelectAutosByParameter(minPrice.Value * 1000, maxPrice.Value * 1000,
                brand, minDist.Value * 10,
                maxDist.Value * 10, minEngine.Value / 10.0, maxEngine.Value / 10.0);
            }
            catch
            {
                error = true;
                minPrice.Value = minDist.Value = 0;
                minEngine.Value = 1;
                maxPrice.Value = maxEngine.Value = maxDist.Value = maxPrice.Maximum;
                MessageBox.Show("Введите корректные данные");
            }
            selectedAutosLV.Items.Clear();
            if (autos.Count == 0 && !error) MessageBox.Show("По данному запросу ничего не найдено");


            for (int i = 0; i < autos.Count; i++)
            {
                ListViewItem lv = new ListViewItem(autos[i].Brand);
                lv.Tag = autos[i];
                lv.SubItems.Add(autos[i].Model);
                lv.SubItems.Add(autos[i].Price.ToString());
                lv.SubItems.Add(autos[i].Distance.ToString());
                selectedAutosLV.Items.Add(lv);
            }
        }

        private void minPrice_Scroll(object sender, EventArgs e)
        {
            
            minVal.Text = (minPrice.Value*1000).ToString()+'$';
            if (minPrice.Value > maxPrice.Value )
            {
                maxPrice.Value = minPrice.Value;
                maxVal.Text = (minPrice.Value*1000).ToString() + '$';
            }
        }

        private void maxPrice_Scroll(object sender, EventArgs e)
        {
            maxVal.Text = (maxPrice.Value*1000).ToString() + '$';
            if (minPrice.Value > maxPrice.Value)
            {
                minPrice.Value = maxPrice.Value;
                minVal.Text = (minPrice.Value*1000).ToString() + '$';
            }
        }

      
        private void minDist_Scroll_1(object sender, EventArgs e)
        {
            minDistLabel.Text = (minDist.Value * 10).ToString() + " тыс.км";
            if (minDist.Value > maxDist.Value)
            {
                maxDist.Value = minDist.Value;
                maxDistLabel.Text = (minDist.Value * 10).ToString() + " тыс.км";
            }
        }

        private void maxDist_Scroll(object sender, EventArgs e)
        {
            maxDistLabel.Text = (maxDist.Value * 10).ToString() + " тыс.км";
            if (minDist.Value > maxDist.Value)
            {
                minDist.Value = maxDist.Value;
                minDistLabel.Text = (minDist.Value * 10).ToString() + " тыс.км";
            }
        }

        private void minEngine_Scroll(object sender, EventArgs e)
        {
            minEngineLabel.Text = (minEngine.Value/10.0).ToString() + " куб.м";
            if (minEngine.Value > maxEngine.Value)
            {
                maxEngine.Value = minEngine.Value;
                maxEngineLabel.Text = (minEngine.Value/10.0).ToString() + " куб.м";
            }
        }

        private void maxEngine_Scroll(object sender, EventArgs e)
        {
            maxEngineLabel.Text = (maxEngine.Value/10.0).ToString() + " куб.м";
            if (minEngine.Value > maxEngine.Value)
            {
                minEngine.Value = maxEngine.Value;
                minEngineLabel.Text = (minEngine.Value/10.0).ToString() + " куб.м";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedAutosLV.SelectedItems.Count != 0)
            {
                var auto = (Auto) selectedAutosLV.SelectedItems[0].Tag;
                var info = new AutoInformation((Auto)selectedAutosLV.SelectedItems[0].Tag);
                info.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedAutosLV.SelectedItems.Count != 0)
            {
                var auto = (Auto)selectedAutosLV.SelectedItems[0].Tag;
                XmlHandler.Save(auto, DataHandler.GetUserById(ID), DataHandler.GetUserById(auto.SellerID));
                XmlHandler.LoadUserPurchases(ID);
            }
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            if (selectedAutosLV.SelectedItems.Count != 0)
            {
                var auto = (Auto)selectedAutosLV.SelectedItems[0].Tag;
                var stat = ApiHandler.GenerateArray(auto);
                if (stat == -1)
                {
                    MessageBox.Show("Авто нет в базе");
                }
                else
                {
                    XmlHandler.LoadNewStatistic(auto, stat);
                    var statArray = XmlHandler.GetWholeStatistic(auto);
                    var f = new StatisticForm(statArray);
                    f.ShowDialog();
                }
            }
            
        }
    }
}
