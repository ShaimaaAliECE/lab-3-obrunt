using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3App
{
    internal class Tool : Collectable
    {
        public virtual void DoAction()
        {
            Console.WriteLine($"{Description} is used");        //Calling the super discription to write
        }
        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");     //Calling the super discription to write
            DoAction();         //Calling the above method
        }
    }
}

