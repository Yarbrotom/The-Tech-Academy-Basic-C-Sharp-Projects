using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFive
{
    public static class divide
    {
        public static void Division(int x, out int answer)
        {
            answer = Convert.ToInt32(x / 2);
        }

        public static void Division(int x, int y, out int answerOne, out int answerTwo)
        {
            answerOne = x * 2;
            answerTwo = y * 3;
        }
    }
}
