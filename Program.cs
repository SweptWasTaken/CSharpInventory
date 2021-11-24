using System;
using Inventory;
using Utilities;

namespace Main
{
    public class Program
    {
        private static void Main()
        {
            Pack pack = new Pack(20, 30, 20);
            
            Arrow arrow = new Arrow();
            Bow bow = new Bow();
            Rope rope = new Rope();
            Water water = new Water();
            Food food = new Food();
            Sword sword = new Sword();

            pack.ShowMenu();
            
            while (true)
            {
                int input = Utils.GetInt();
                
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        pack.ShowContents();
                        pack.ShowMenu();
                        break;
                    case 2:
                        pack.Add(arrow);
                        break;
                    case 3:
                        pack.Add(bow);
                        break;
                    case 4:
                        pack.Add(rope);
                        break;
                    case 5:
                        pack.Add(water);
                        break;
                    case 6:
                        pack.Add(food);
                        break;
                    case 7:
                        pack.Add(sword);
                        break;
                    default:
                        Console.WriteLine("What was that again?");
                        break;
                }
            }
        }
    }
}