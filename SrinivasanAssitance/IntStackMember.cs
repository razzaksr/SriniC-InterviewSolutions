using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrinivasanAssitance
{
    internal class IntStackMember:StackMember<Int32>
    {
        public override void Value()
        {
            base.Value();
            int sum = 0;
            Array.ForEach(arr, a =>
            {
                sum += a;
            });
            Console.WriteLine("Sum is " + sum);
        }
    }
}
