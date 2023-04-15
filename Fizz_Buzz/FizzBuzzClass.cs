using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    internal class FizzBuzzClass
    {
        public List<string> Start(int round)
        {
            var list=new List<string>();
            for (int i = 0; i < round; i++)
            {
                var outPut = i % 3 == 0 ? "Fizz" : "";
                 outPut += i % 5 == 0 ? "Buzz" : "";
                 outPut += outPut==string.Empty?i.ToString():string.Empty;
                list.Add(outPut);
            }
            return list;
        }
    }
}
