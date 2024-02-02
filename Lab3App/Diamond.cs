using System;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(string discription, int score)
        {
            this.Description = discription;         //Storing important information, with this one calling the super class
            this.score = score;
        }
        public override void Display()
        {
            Console.WriteLine("Diamond " + this.Description + " is displayed");     //Displaying the item to the user
        }
    }
}
