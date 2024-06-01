using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Wybory
{
    public partial class Form1 : Form
    {
        CandidatesDataContext cdc;
        private int i = 0;
        public Form1()
        {
            cdc = new CandidatesDataContext();
            InitializeComponent();
            loadCandidates();
            refreshCandidates(null);
        }
        private void loadCandidates()
        {
            chartMain.Series.Clear();
            foreach(Candidate c in cdc.Candidates)
            {
                UserControlCandidate usc = new UserControlCandidate(++i, c);
                usc.ScoreChanged += updateCandidate;
                usc.ScoreChanged += refreshCandidates;
                usc.CRemoved += removeCandidate;

                flowLayoutPanel1.Controls.Add(usc);

                Series s = new Series();
                s.MarkerSize = 10;
                s.ChartType = SeriesChartType.Point;
                chartMain.Series.Add(s);
                s.Tag = usc;

                refreshCandidates(usc);
            }
        }
        private void refreshCandidates(object sender)
        {
            foreach (Series s in chartMain.Series)
            {
                if (s.Tag != sender) continue;
                if (!(sender is UserControlCandidate)) continue;
                UserControlCandidate ucf = (sender as UserControlCandidate);
                s.Points.Clear();
                s.Points.AddXY(ucf.I, ucf.Votes);
                s.Name = ucf.CName;
            }
            chartMain.ChartAreas.First().RecalculateAxesScale();
        }

        private void updateCandidate(object sender)
        {
            if (!(sender is UserControlCandidate)) return;

            refreshCandidates(sender);
            cdc.SubmitChanges();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Verification v = new Verification();
            if (v.ShowDialog() != DialogResult.OK) return;

            CandinateAdd ca = new CandinateAdd();
            if (ca.ShowDialog() != DialogResult.OK) return;

            Candidate c = new Candidate();
            c.Name = ca.CName;
            c.Surname = ca.CSurname;

            cdc.Candidates.InsertOnSubmit(c);
            cdc.SubmitChanges();

            UserControlCandidate usc = new UserControlCandidate(++i, c);
            usc.ScoreChanged += updateCandidate;
            usc.ScoreChanged += refreshCandidates;
            usc.CRemoved += removeCandidate;

            Series s = new Series();
            s.MarkerSize = 10;
            s.ChartType = SeriesChartType.Point;
            chartMain.Series.Add(s);
            s.Tag = usc;

            flowLayoutPanel1.Controls.Add(usc);
            refreshCandidates(usc);
        }

        private void removeCandidate(object sender)
        {
            if (!(sender is UserControlCandidate)) return;

            UserControlCandidate usc = (sender as UserControlCandidate);

            flowLayoutPanel1.Controls.Remove(usc);

            cdc.Candidates.DeleteOnSubmit(usc.candidate);
            cdc.SubmitChanges();

            chartMain.Series.Remove(chartMain.Series.Single(s => s.Tag == sender));
        }
    }
}
