﻿using System;
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
    public partial class DataDownloader : Form
    {
        ScoutingClient Client;

        public DataDownloader()
        {
            InitializeComponent();
        }

        private void DataDownloader_Load(object sender, EventArgs e)
        {
            Show();
            Client = new ScoutingClient();
        }
    }
}