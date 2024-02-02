using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int Value;
        public Coin(string discription, int score, int value)
        {
            this.Description = discription;         //Saving the important information, this one is specific to the super class
            this.score = score;
            this.Value = value;
        }
        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");        //Telling the user what item had been collected
        }
        public void UpdateTotalValue()
        {
            Board.TotalValue += this.Value;         //Updating the total item value
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);        //Displaying changed value
        }
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();         //Calling to change the score
            UpdateTotalValue();         //Calling to change the value
        }
    }
}
