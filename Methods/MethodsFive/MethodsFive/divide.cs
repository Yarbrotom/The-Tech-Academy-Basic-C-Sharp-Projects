using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFive
{
    public class MathFunctions
    {
        public void MathFunction(int x, out int answer)
        {
            answer = Convert.ToInt32(x / 2);
        }

        public void MathFunction(int x, int y, out int answerOne, out int answerTwo)
        {
            answerOne = x * 2;
            answerTwo = y * 3;
        }
    }
}
