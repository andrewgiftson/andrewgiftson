using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class studentGrading
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            int roundOf;
            int con = grades.Count;
            List<int> result = new List<int>();
            for (int i = 0; i < con; i++)
            {
                int temp = grades[i];
                int jCount = temp % 5;
                if (jCount >= 3)
                {
                    for (int j = 0; j <= (5 - jCount); j++)
                    {
                        roundOf = temp % 5;
                        if (roundOf != 0)
                        {
                            temp++;

                        }
                        else if (roundOf == 0 && 40 <= temp)
                        {
                            result.Add(temp);
                        }
                        else
                        {
                            result.Add(grades[i]);
                        }
                    }
                }
                else
                {
                    result.Add(grades[i]);
                }
            }
            return result;
        }


    }

}
