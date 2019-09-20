using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());
            for (int i = 0; i < 10; i++)
                blendables.Add(new Mango());

            Strawberry strawberry = new Strawberry();
            Banana b = new Banana();

            Console.WriteLine(b.Blend());
            blendables.Add(b);
            string mess = "";
            ///whatever you are are i wnat you to use what you are
            /// foreach(dynamic i in blendables)
            //{
             //   mess += i.Blend();
           /// }
            ///the right way would be to override the methode
            foreach (IBlendable i in blendables)
            {
                mess += i.Blend();
            }
            Console.WriteLine(mess);
            
        }
    }
}
