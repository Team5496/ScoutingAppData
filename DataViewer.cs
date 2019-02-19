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
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
        }

        public void ViewData(Dictionary<string, string> Data)
        {
            DataLabel.Text = "";
            foreach(KeyValuePair<string, string> Pair in Data)
            {
                DataLabel.Text += Pair.Key + ": \"" + Pair.Value + "\"\n";
            }
            Show();
        }
    }
}
