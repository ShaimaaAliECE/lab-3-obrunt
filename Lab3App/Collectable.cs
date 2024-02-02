using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Collectable : Displayble
    {
        internal CollectionBoard Board;         //Getting a copy of the collections board
        public string Description;              //Having a generic discription
        public virtual void AddMe(List<Collectable> list)       //Creating the overridable method for all other one to share
        {
            list.Add(this);             //Adding the item to the list
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");     //Displaying the item to the user
        }
    }
}
