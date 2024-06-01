using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wybory
{
    public partial class CandinateAdd : Form
    {
        public string CName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string CSurname
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public CandinateAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            DialogResult = DialogResult.OK;
        }
    }
}
