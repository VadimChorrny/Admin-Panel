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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }
        internal event Action<string> FoundWord;

        public MainWindow ParentForm { get; set; }



        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        public ChildForm(string caption)
            :this()
        {
            this.Text = caption;
        }

        internal void Show(string richText)
        {
            richTextBox1.Text = richText;
            this.Show();
        }

        string word = "C++";
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ParentForm.lblInfoChild.Text = richTextBox1.Text;
            if(richTextBox1.Text.Contains(word))
            {
                FoundWord?.Invoke($"Was found word {word}");
            }
        }
    }
}
