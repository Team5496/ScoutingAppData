using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingAppData
{
    public class Filter
    {
        public char Operator;
        public string A, B;

        public Filter(string A, char Operator, string B)
        {
            this.A = A;
            this.Operator = Operator;
            this.B = B;
        }

        public override string ToString()
        {
            return A + " " + Operator + " " + B;
        }
    }
}