using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranch
{
    public class Factorial
    {
        public static int Calculate(int n)
        {
            int res1 = 1;
            for (int i = 0; i < n; i++)
            {
                res1 *= i;
            }
            return res1;
        }
    }
}
