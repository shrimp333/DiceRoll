using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DiceRole
{
    class Program
    {
        static ClGame DiceRoller = new ClGame();
        //Create the dice roller object
        static void Main()
        {
            string filePath = "./rolls.txt";
            if (File.Exists(filePath))
            {
                string[] arr = File.ReadAllLines(filePath);
                foreach (string s in arr)
                {
                    DiceRoller.results.Add(int.Parse(s));
                }
            }
            //if the file exists, read the contents and add them to the results list
            while (true)
            {
                int inputNum;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1. Add Die\n2. Roll one Dice\n3. List Rolls\n4. Delete All Rolls\n5. Roll All Dice\n6. Calculate Key Values\n7. Save all\n8. Exit\nEnter the number for the action you wish to complete");
                    string input = Console.ReadLine().Trim();
                    if (Int32.TryParse(input, out inputNum) && inputNum > 0 && inputNum < 9)
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Incorrect Input");
                    Console.WriteLine("Hit enter to continue");
                    Console.ReadLine();
                    //checks to see if input was a digit between 1 and 5 if not loops back on itself
                }

                switch (inputNum)
                {
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the number of sides for the dice you wish to create");
                            string input = Console.ReadLine().Trim();
                            if (Int32.TryParse(input, out int sides) && inputNum > 0)
                            {
                                DiceRoller.AddDie(sides);
                                break;
                            }
                        }
                        Console.WriteLine("Dice Created");
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        break;
                        //create a dice with the number of sides entered
                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("How many sides does this dice have?");
                            string input = Console.ReadLine().Trim();
                            if (Int32.TryParse(input, out int sides) && inputNum > 0)
                            {
                                Die dice = new Die(sides);
                                int roll = dice.roll();
                                Console.WriteLine($"Rolling a {sides} sided dice result was: {roll}");
                                DiceRoller.results.Add(roll);
                                Console.WriteLine("Hit enter to continue");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                        }
                        break;
                        //roll a single die and add the result to the results list
                    case 3:
                        Console.Clear();
                        listAllRolls();
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        break;
                        //lists every roll ever done to the console
                    case 4:
                        Console.Clear();
                        using (StreamWriter writer = new StreamWriter("./rolls.txt", false))
                        {
                            writer.Write("");
                        }
                        break;
                        //clears the file
                    case 5:
                        Console.Clear();
                        if (DiceRoller.Dice == null)
                        {
                            Console.WriteLine("You must create a die before you can roll it");
                        }
                        else
                        {
                            DiceRoller.RollAllDice();
                            Console.WriteLine("Rolled all dice");
                        }
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        break;
                        //Rolls every die created and adds the result to the results list
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"Average:  {DiceRoller.GetAverage()}\nTotal: {DiceRoller.GetTotal()}");
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        break;
                        //calls GetAverage and GetTotal and prints the results to the console
                    case 7:
                        using (StreamWriter writer = new StreamWriter("./rolls.txt", false))
                        {
                            foreach (int i in DiceRoller.results)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Saved");
                        Console.WriteLine("Hit enter to continue");
                        Console.ReadLine();
                        break;
                        //saves the results to a file
                    case 8:
                        Environment.Exit(0);
                        break;
                        //exits the program
                }
            }
        }
        static void listAllRolls()
        {
            while (true)
            {
                Console.Clear();
                foreach (int roll in DiceRoller.results)
                {
                    Console.WriteLine(roll);
                }
            }
        }
        //lists all the rolls that are stored in the list
    }
}