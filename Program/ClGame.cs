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

        public override int RollAllDice()
        {
            foreach (Die die in this.Dice) {
                results.Add(die.roll());
            }
            return 1;
        }
        public override void AddDie(int sides)
        {
            Die die = new Die(sides);
            Dice.Add(die);
        }
        public double GetAverage() {
            return results.Average();
        }

        public int GetTotal() {
            return results.Sum();
        }
    }
}