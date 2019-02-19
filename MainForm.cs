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

        public MainForm()
        {
            InitializeComponent();
            Filters = new List<Filter>();
            UpdateButtons();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Filters.Add(new Filter(KeyBox.Text, OperatorBox.Text[0], ValueBox.Text));
            UpdateFilters();
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
    }
}