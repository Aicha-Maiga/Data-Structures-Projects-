// written by Aicha Maiga 
// 04/16/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8BaseballGame
{
    public class BaseballGame
    {
        public int Score(List<string> operations)
        {
            List<int> stack = new List<int>();

            foreach (string point in operations)
            {
                if (point == "C")
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else if (point == "D")
                {
                    int last = stack[stack.Count - 1];
                    stack.Add(2 * last);
                }
                else if (point == "+")
                {
                    int last = stack[stack.Count - 1];
                    int secondLast = stack[stack.Count - 2];
                    stack.Add(last + secondLast);
                }
                else
                {
                    stack.Add(int.Parse(point));
                }
            }

            int sum = 0;
            foreach (int score in stack)
            {
                sum += score;
            }

            return sum;
        }

    }
}
