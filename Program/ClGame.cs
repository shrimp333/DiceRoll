using System;
using System.Collections.Generic;
using System.Linq;
namespace DiceRole
{
    public class ClGame: Game {
        public List<int> results { get; set; }

        public ClGame()
        {
            results = new List<int>();
        }
        //creates the result list property
        public override int RollAllDice()
        {
            foreach (Die die in this.Dice) {
                results.Add(die.roll());
            }
            return 1;
        }
        //override method that will role all of the dice created
        public override void AddDie(int sides)
        {
            Die die = new Die(sides);
            Dice.Add(die);
        }
        //override method that will call the die cunstructor
        public double GetAverage() {
            if (results.Count == 0) {
                return 0;
            }
            int total = GetTotal();
            double average = total / (double)results.Count();
            return average;
        }
        //calculates the average of the results
        public int GetTotal() {
            return results.Sum();
        }
        //calculates the total of the results
    }
}