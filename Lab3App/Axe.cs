using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string name)
        {
            this.Description = name;
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
        public override void Display()
        {
            DoAction();
        }
    }
}
