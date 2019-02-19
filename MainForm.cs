using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingAppData
{
    public partial class MainForm : Form
    {
        List<Filter> Filters;
        ScoutingClient Client;
        List<Dictionary<string, string>> MatchDatas;

        public MainForm()
        {
            InitializeComponent();
            Filters = new List<Filter>();
            Client = new ScoutingClient();
            MatchDatas = new List<Dictionary<string, string>>();
            Show();

            DataDownloader Downloader = new DataDownloader();
            Downloader.ShowUntil(GetItems());
            UpdateButtons();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Filters.Add(new Filter(KeyBox.Text, OperatorBox.Text[0], ValueBox.Text));
            UpdateFilters();
            UpdateButtons();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Filters.RemoveAt(FiltersBox.SelectedIndex);
            UpdateFilters();
            UpdateButtons();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            DataDownloader Downlaoder = new DataDownloader();
            Downlaoder.ShowUntil(Apply());
        }
    
        async Task GetItems()
        {
            EventBox.Items.Clear();
            EventBox.Items.AddRange((await Client.GetEvents()).ToArray());
            EventBox.Text = EventBox.Items[0].ToString();

            KeyBox.Items.Clear();
            string Team = (await Client.GetTeams(EventBox.Text))[0];
            string Match = (await Client.GetMatches(EventBox.Text, Team))[0];
            KeyBox.Items.AddRange((await Client.GetMatch(EventBox.Text, Team, Match)).Keys.ToArray());
            KeyBox.Text = "team";
        }

        async Task Apply()
        {
            DataBox.Items.Clear();
            MatchDatas.Clear();
            string Event = EventBox.Text;
            List<string> Teams = await Client.GetTeams(Event);
            foreach(string Team in Teams)
            {
                List<string> Matches = await Client.GetMatches(Event, Team);
                foreach(string Match in Matches)
                {
                    Dictionary<string, string> MatchData = await Client.GetMatch(Event, Team, Match);
                    if (TestFilters(MatchData))
                    {
                        MatchDatas.Add(MatchData);
                        DataBox.Items.Add("Team " + Team + " in match " + Match);
                    }
                }
            }
        }

        bool TestFilters(Dictionary<string, string> Data)
        {
            foreach(Filter F in Filters)
            {
                int ResultA, ResultB;
                switch (F.Operator)
                {
                    case '=':
                        if (Data[F.A] != F.B) return false;
                        break;
                    case '>':
                        if (!int.TryParse(Data[F.A], out ResultA) || !int.TryParse(F.B, out ResultB)) return false;
                        if (ResultA <= ResultB) return false; 
                        break;
                    case '<':
                        if (!int.TryParse(Data[F.A], out ResultA) || !int.TryParse(F.B, out ResultB)) return false;
                        if (ResultA >= ResultB) return false;
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }

        void UpdateButtons()
        {
            AddBtn.Enabled = (KeyBox.Text != "" && ValueBox.Text != "" && OperatorBox.Text != "");
            RemoveBtn.Enabled = (FiltersBox.SelectedItem != null);
        }

        void UpdateFilters()
        {
            FiltersBox.Items.Clear();
            foreach(Filter F in Filters)
            {
                FiltersBox.Items.Add(F.ToString());
            }
        }

        private void KeyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void OperatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void KeyBox_TextUpdate(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void FiltersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void DataBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataViewer Viewer = new DataViewer();
            Viewer.ViewData(MatchDatas[DataBox.SelectedIndex]);
        }
    }
}