using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutingAppData
{
    class NameConverter
    {
        public string Convert(string Name)
        {
            string Result = char.ToUpper(Name[0]).ToString();

            for (int i = 1; i < Name.Length; i++)
            {
                if (char.IsUpper(Name[i]))
                {
                    Result += " " + Name[i];
                }
                else
                {
                    Result += Name[i];
                }
            }
            return Result;
        }

        public string Unconvert(string Name)
        {
            return char.ToLower(Name[0]) + Name.Replace(" ", "").Remove(0, 1);
        }
    }
}
