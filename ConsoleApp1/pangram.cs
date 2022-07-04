using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class pangram
    {
        public static void Checkpangram()
        {
            string s = "We promptly judged antique ivory buckles for the next prize";
            string sLower = s.ToLower();
            sLower = sLower.Replace(" ", "");
            sLower = string.Concat(sLower.OrderBy(ch => ch));
            var unique = new HashSet<char>(sLower);

            string result = string.Empty;
            foreach (char c in unique)
            {
                result = result + c;
            }
            if (result.Length == 26)
            {
                result = "pangram";
            }
            else
            {
                result = "not pangram";
            }
            return result;
        }
    }
}
