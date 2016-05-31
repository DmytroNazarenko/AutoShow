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
    public partial class SellerForm : Form
        //Форма продавца
    {
        int ID;
        public SellerForm(int id)
        {           
            InitializeComponent();
            ID = id;
            //listView1.FullRowSelect = true;
            dataGridView1.DataSource = SellerManager.LoadAutoList(id);
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["SellerID"].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.Sort(dataGridView1.SortedColumn, ListSortDirection.Ascending);
            // dataGridView1.Refresh();
            //listView1. = SellerManager.LoadAutoList(ID);
            //showAutos();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //SellerManager.AddAuto()
            AddAutoForm form = new AddAutoForm(ID);
            form.ShowDialog();
            dataRefresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            AddAutoForm form = new AddAutoForm(ID, (Auto)dataGridView1.SelectedRows[0].DataBoundItem);
            form.ShowDialog();
            dataRefresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Auto auto = (Auto)dataGridView1.SelectedRows[0].DataBoundItem;
                if (auto != null)
                    SellerManager.DeleteAuto(auto.ID);
                dataRefresh();
            }
            //listView1.Refresh();
        }

        private void dataRefresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SellerManager.LoadAutoList(ID);
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["SellerID"].Visible = false;
        }
        //private void showAutos()
        //{
        //    List<Auto> autoList = SellerManager.LoadAutoList(ID);
        //    foreach (Auto auto in autoList)
        //    {
        //        ListViewItem item = new ListViewItem(auto.Brand);
        //        item.SubItems.Add(auto.Model);
        //        item.SubItems.Add(auto.Price.ToString());
        //        item.SubItems.Add(auto.Color);
        //        item.SubItems.Add(auto.Distance.ToString());
        //        item.SubItems.Add(auto.Engine.ToString());
        //        listView1.Items.Add(item);
        //    }
        //}
    }
}
