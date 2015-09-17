using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGOnlinePlayerToQualStage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PlayerRankUp(80));
            Console.WriteLine(PlayerRankUp(110));
            Console.ReadLine();
        }

        public static Object PlayerRankUp(int points)
        {
            if (points >= 100)
            {
                return
                    "Well done!You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up.";
            }
            else
            {
                return false;
            }

            //Better code I found after completing the task
            //return points >= 100 ? "Well done! You have advanced to the qualifying stage. Win 2 out of your next 3 games to rank up." : (Object)false;
        }
    }
}
