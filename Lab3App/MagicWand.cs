using System;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string name)
        {
            this.Description = name;
        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
        public override void Display()
        {
            DoAction();
        }
    }
}
