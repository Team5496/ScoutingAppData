using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace ScoutingAppData
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new MainForm());
        }
    }
}