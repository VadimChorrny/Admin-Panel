using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        

        private void AddProductWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
