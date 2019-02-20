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
            List<string> ConvertedKeys = new List<string>();
            NameConverter Converter = new NameConverter();
            foreach (string S in Data.Keys)
            {
                ConvertedKeys.Add(Converter.Convert(S));
            }

            int TabLength = ConvertedKeys.Max(X => X.Length) + 2;
            string[] Values = Data.Values.ToArray();
            DataLabel.Text = "";
            for (int i = 0; i < Data.Count; i++)
            {
                DataLabel.Text += ConvertedKeys[i].PadRight(TabLength) + Values[i] + "\n";
            }
            Show();
        }
    }
}
