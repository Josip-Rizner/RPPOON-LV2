using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random randomGenerator = new Random();        2. zadatak
            //DiceRoller firstRoller = new DiceRoller();       1. - 3. zadatak
            //DiceRoller secondRoller = new DiceRoller(new ConsoleLogger());        4. zadatak

            /*   1. zadatak
            for (int i = 0; i < 20; i++)
            {
                firstRoller.InsertDie(new Die(6));
            }*/

            /*      2. zadatak   
            for (int i=0; i<20; i++)
            {
                firstRoller.InsertDie(new Die(6, randomGenerator));
            }*/

            /*  3. zadatak
            for (int i = 0; i < 20; i++)
            {
                firstRoller.InsertDie(new Die(6));
            }*/


            /*      1.-3. zadatak
            firstRoller.RollAllDice();
            firstRoller.PrintDiceResults();
            */


            /*          4. zadatak
            for (int i = 0; i < 20; i++)
            {
                secondRoller.InsertDie(new Die(6));
            }


            secondRoller.RollAllDice();
            secondRoller.LogRollingResults();
            */



            DiceRoller thirdRoller = new DiceRoller();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("LogDat.txt");

            for (int i = 0; i < 20; i++)
            {
                thirdRoller.InsertDie(new Die(6));
            }

            thirdRoller.RollAllDice();
            consoleLogger.Log(thirdRoller);
            fileLogger.Log(thirdRoller);

          
        }
    }
}
