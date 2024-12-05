using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeProblem4_2_2
{
    public class BracketChecker
    {

        public static bool IsValid()
        {
            string input = Console.ReadLine();
            Stack<char> stk = new Stack<char>();
            foreach (var c in input.ToCharArray())
            {
                if (c == '(')
                {
                    stk.Push(')');
                }
                else if (c == '[')
                {
                    stk.Push(']');
                }
                else if (c == '{')
                {
                    stk.Push('}');
                }
                else if (stk.Count == 0 || stk.Pop() != c)
                {
                    return false;
                }
            }
            return stk.Count == 0;
        }
    }
}

