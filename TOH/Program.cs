using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOH
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> src = new Stack<int>();
            Stack<int> tmp = new Stack<int>();
            Stack<int> dst = new Stack<int>();

            src.Push(8);
            src.Push(7);
            src.Push(6);
            src.Push(5);
            src.Push(4);
            src.Push(3);
            src.Push(2);
            src.Push(1);

            Move(8, ref src, ref dst, ref tmp);
        }

        static Stack<int> Move (int amountOfDisks, ref Stack<int> from, ref Stack<int> to, ref Stack<int> temporaryStack)
        {
            //base
            if (amountOfDisks == 1)
            {
                to.Push(from.Pop());
            }
            else
            {
                //Move n-1 disks to tmpStack

                //Move 1 disk from "from" to "to"

                //Move n-1 disks to "to"
            }
        }
    }
}
