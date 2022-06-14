
using System;
namespace DiceRole
{
    public class Die {
        public int sides { get; set; }

        public Die()
        {
            this.sides = 6;
        }
        public Die(int sides)
        {
            this.sides = sides;
        }
        //Cunstructors for the die, one of them defaults to 6 and the other you can enter as many sides 9as you want
        public int roll()
        {
            Console.WriteLine($"Rolling a {this.sides} sided dice");
            Random rnd = new Random();
            return rnd.Next(1, this.sides + 1);
        }
        //calculates a random number between 1 and the number of sides of the die
    }
}