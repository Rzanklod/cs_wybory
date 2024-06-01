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
    public partial class Verification : Form
    {
        private string password = "2137";
        public Verification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password != textBoxPassword.Text)
            {
                MessageBox.Show("Niepoprawne haslo! Sproboj ponownie.");
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
