using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct GameObject
{
    public int x;
    public int y;
    public string draw;
    public ConsoleColor color;
}
class FallingRocks
{
    static void PrintOnPosition(int x, int y, string obj, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(obj);
    }


    static void Main()
    {
        int playfieldWidth = 40;
        Console.BufferHeight = Console.WindowHeight = 25;
        Console.BufferWidth = Console.WindowWidth = 40;

        //The gamer - user
        GameObject user = new GameObject();
        user.x = (Console.WindowWidth / 2) - 5;
        user.y = 15;
        user.draw = "<<--<>-->>"; //Length = 10
        user.color = ConsoleColor.Yellow;

        //The falling rocks
        Random randomGenerator = new Random(); //where to show the new falling rock
        List<GameObject> rocks = new List<GameObject>();

        while (true)
        {
            //Add new rock
            {
                GameObject newRock = new GameObject();
                newRock.color = ConsoleColor.Cyan;
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0; //start position - top
                newRock.draw = "#";
                rocks.Add(newRock);
            }

            //Move gamer - user (key pressed left arrow/right arrow)
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                //Faster change the direction while press opposite arrow
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (user.x - 1 >= 0)
                    {
                        user.x = user.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (user.x + 10 < playfieldWidth)
                    {
                        user.x = user.x + 1;
                    }
                }
            }

            //Move cars

            List<GameObject> newList = new List<GameObject>();
            for (int i = 0; i < rocks.Count; i++)
            {
                GameObject oldRock = rocks[i];
                GameObject newRock = new GameObject();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.draw = oldRock.draw;
                newRock.color = oldRock.color;

                newList.Add(newRock);
            }
            rocks = newList;

            //Check if other cars are hitten us

            //Clear the console
            Console.Clear();

            //Redraw playfield
            PrintOnPosition(user.x, user.y, user.draw, user.color);

            foreach (GameObject rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.draw, rock.color);
            }

            //Draw info

            //Slow down the program
            Thread.Sleep(100);
        }


    }
}
