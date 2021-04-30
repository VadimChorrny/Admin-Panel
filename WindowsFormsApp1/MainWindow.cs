using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Magenta, Color.Aqua };
            cbColors.DataSource = colors;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string caption = String.IsNullOrWhiteSpace(tbCaptionChild.Text) ? "Child Form" : tbCaptionChild.Text;
            ChildForm child = new ChildForm(caption);
            child.ParentForm = this;
            child.BackColor = (Color)cbColors.SelectedItem;
            child.FoundWord += (string s) => this.Text  = $"Hello from {child.Text} : {s}";
            child.Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.ParentForm = this;
            child.BackColor = (Color)cbColors.SelectedItem;
            child.ShowDialog(); // as modal(child locks parent form)
            MessageBox.Show($"Result of dialog {child.DialogResult}");
        }

        private void btnOverloadShow_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.BackColor = (Color)cbColors.SelectedItem;
            child.richTextBox1.ForeColor = child.BackColor;
            child.Show(tbCaptionChild.Text);
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
