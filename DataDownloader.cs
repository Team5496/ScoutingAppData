using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoutingAppData
{
    public partial class DataDownloader : Form
    {
        public DataDownloader()
        {
            InitializeComponent();
        }

        private void DataDownloader_Load(object sender, EventArgs e)
        {
        }

        public void ShowUntil(Task T)
        {
            Show();
            while (!T.IsCompleted)
            {
                Application.DoEvents();
                Thread.Sleep(1); // So it doesn't completely blast the CPU
            }
            Close();
        }
    }
}