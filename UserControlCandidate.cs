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
    public partial class UserControlCandidate : UserControl
    {
        private int i;
        public int I
        {
            get { return i; }
        }
        public Candidate candidate;
        public delegate void ActionWithSender(object sender);
        public event ActionWithSender ScoreChanged;
        public event ActionWithSender CRemoved;
        public string CName
        {
            get { return I.ToString() + " | " + textBoxImie.Text + " " + textBoxNazwisko.Text; }
        }

        public int Votes
        {
            get { return candidate.Votes; }
        }
        public UserControlCandidate(int i, Candidate c)
        {
            this.i = i;
            this.candidate = c;
            InitializeComponent();
            groupBoxCandidate.Text = this.i.ToString();
            textBoxImie.Text = candidate.Name;
            textBoxNazwisko.Text = candidate.Surname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            candidate.Votes += 1;
            //MessageBox.Show(candidate.Votes.ToString());
            if(ScoreChanged != null)
            {
                ScoreChanged(this);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (CRemoved == null) return;
            Verification v = new Verification();
            if (v.ShowDialog() != DialogResult.OK) return;

            CRemoved(this);
        }
    }
}
