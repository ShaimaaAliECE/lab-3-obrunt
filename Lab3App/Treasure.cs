using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public int score;
        public void UpdateTotalScore()
        {
            Board.TotalScore += this.score;       //Changing the total score
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);     //Displaying the newest total score
        }
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);         //Adding the item to the list
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");     //Writing the log of collected things
            UpdateTotalScore();         //Calling to change the score
        }
    }
}
