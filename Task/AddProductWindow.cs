using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;

namespace Task
{
    public partial class AddProductWindow : Form
    {
        internal Form1 Parent { get; set; }
        public AddProductWindow(Form1 forms)
        {
            InitializeComponent();
            Parent = forms;
        }
        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            { Name = tbName.Text,Description = tbDescription.Text,Price = (int)nudPrice.Value};
            Parent.lbProducts.Items.Add(product);
            Parent.cbTypeProduct.Items.Add(product.Name);
        }
        

        public void SerializeJSON<T>(string path, T obj)
        {
            Product product = new Product()
            { Name = tbName.Text, Description = tbDescription.Text, Price = (int)nudPrice.Value };
            string json = JsonSerializer.Serialize<Product>(product);
        }

        private void AddProductWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
