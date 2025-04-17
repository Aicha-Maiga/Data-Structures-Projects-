// written by Aicha Maiga
// 04/16/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8StudentsLunch
{
    public class Lunch
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>(students);
            int index = 0;
            int rotations = 0;

            while (queue.Count > 0 && rotations < queue.Count)
            {
                if (queue.Peek() == sandwiches[index])
                {
                    queue.Dequeue();
                    index++;
                    rotations = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    rotations++;
                }
            }

            return queue.Count;

        }

    }
}
