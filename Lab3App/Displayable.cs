using System;

namespace Lab3App
{
	internal class Displayble
	{

		public virtual void Display()       //Creating an overrideble method for all inheritors
		{
			Console.WriteLine(this + "was displayed");      //Output for users
		}
	}
}