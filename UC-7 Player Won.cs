﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4SankeAndLadder
{
    internal class UC_7_Player_Won
    {
        public static void snakeAndLadder()
        {
            String Player = "Rishi";
            int position = 0;

            Random random = new Random();

            int dice = random.Next(1, 7);

            Console.WriteLine("{1} got {0} from dice", dice, Player);

            //updating position 

            position += dice;


            //looping till postion equal to 100 UC4

            int dieCount = 1;

            while (position <= 100)
            {

                //checking option UC3

                int check = random.Next(0, 3);

                if (check == 0)
                {
                    Console.WriteLine("No Play");
                    Console.WriteLine(Player + " postion is " + position);
                    Console.WriteLine("");
                }
                else if (check == 1)
                {
                    Console.WriteLine("Ladder");
                    dice = random.Next(1, 7);
                    position += dice;
                    //UC5
                    //if (position > 100)
                    //{
                    //    position = 100;
                    //}
                    Console.WriteLine("Number in die is {0}", dice);
                    Console.WriteLine("{0} position is {1}", Player, position);
                    Console.WriteLine("");
                    dieCount++; //UC6 die count

                }
                else
                {
                    Console.WriteLine("Snake");
                    dice = random.Next(1, 7);
                    position -= dice;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("Number in die is {0}", dice);
                    Console.WriteLine("{0} postion is {1}", Player, position);
                    Console.WriteLine("");
                    dieCount++;// UC6 die count
                }




            }

            Console.WriteLine("Die is rolled {0} times to win", dieCount);

        }

    }
}
