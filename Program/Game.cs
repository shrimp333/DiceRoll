using System;
using System.Collections.Generic;
namespace DiceRole
{
    public abstract class Game {
        public List<Die> Dice { get; set; }

        public Game()
        {
            Dice = new List<Die>();
        }
        //Creates a list of dice
        public abstract int RollAllDice();

        public abstract void AddDie(int sides);
        //Abstract methods
    }
}