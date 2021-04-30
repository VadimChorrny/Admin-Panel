using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace admin_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region properties
        public Product product { get; set; }
        public int counterItem; // check lbProducts items index 
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetProduct set = new SetProduct(this);
            set.ShowDialog();
        }

        private void lbProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetProduct set = new SetProduct(this);
            set.ShowDialog();

            // create object
            Product product = new Product()
            { Name = set.tbDescription.Text, Description = set.tbDescription.Text, Price = (int)set.nudPrice.Value };

            lbProducts.Items[lbProducts.SelectedIndex] = product;
            if(btnAdd.DialogResult == DialogResult.OK)
            {
                lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
            }
            //lbProducts.Items[lbProducts.SelectedIndex] = set.tbName;
            //lbProducts.Items[lbProducts.SelectedIndex] = set.tbDescription;
            //lbProducts.Items[lbProducts.SelectedIndex] = set.nudPrice;

        }
    }
}
