using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderProblem
    {
        public void playgame() {
            int initialPosition = 0;
            Console.WriteLine("Started with "+initialPosition+" position");
            Random obj = new Random();
            int diceRoll = obj.Next(1, 7);
            Console.WriteLine("Dice Roll "+diceRoll);
        }
    }
}
