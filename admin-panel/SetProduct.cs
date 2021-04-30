using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace admin_panel
{
    public partial class SetProduct : Form
    {
        public SetProduct()
        {
            InitializeComponent();
        }
        public SetProduct(Form1 forms)
        {
            InitializeComponent();
            Parent = forms;
        }

        #region properties
        internal Form1 Parent { get; set; }
        internal string getJsonProperties { get; set; } = null;

        #endregion

        private void FileWorker()
        {
            string path = @"item.json";
            Product product = new Product()
            { Name = tbName.Text, Description = tbDescription.Text, Price = (int)nudPrice.Value };

            string json = JsonConvert.SerializeObject(product);
            File.WriteAllText(path, json);
            json = getJsonProperties;
            Product p = JsonConvert.DeserializeObject<Product>(json);


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            { Name = tbName.Text, Description = tbDescription.Text, Price = (int)nudPrice.Value };
            Parent.lbProducts.Items.Add(product);
            FileWorker();


        }

    }
}
