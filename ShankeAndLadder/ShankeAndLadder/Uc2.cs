using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShankeAndLadder
{
    internal class Uc2
    {
        public static void RollTheDies()
        {
            Random random = new Random();
            int x = random.Next(1, 7);
            Console.WriteLine("Player1 Roll the dice and get the num :" + x);
        }
    }
}
