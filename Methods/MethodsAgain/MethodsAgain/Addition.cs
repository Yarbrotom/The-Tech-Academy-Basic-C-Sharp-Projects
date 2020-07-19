using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAgain
{
    public class Addition
    {
        public static int Adding(int x)
        {
            return x + 5;
        }

        public static int Adding(decimal x)
        {
            return Convert.ToInt32(x + 7);
        }

        public static int Adding(string x)
        {
                int number = Convert.ToInt32(x);
                return number + 10;                                    
        }
    }
}
