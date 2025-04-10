// written by Aicha Maiga 
// 04/09/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7RobotReturn
{
    public class Robot
    {
        public bool ReturntoOrigin(string moves)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                char c = moves[i];
                if (c == 'U') y++;
                else if (c == 'D') y--;
                else if (c == 'R') x++;
                else if (c == 'L') x--;
            }

            return x == 0 && y == 0;
        }
    }
}
