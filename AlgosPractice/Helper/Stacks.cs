using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosPractice.Helper
{
    class Stacks
    {
        public static Stack<int> Sort(Stack<int> unorderedStack)
        {
            Stack<int> finalStack = new Stack<int>(), helperStack = new Stack<int>();

            // helper variables
            int x = 0, y = 0;

            while (unorderedStack.Count != 0)
            {
                x = unorderedStack.Pop();

                // if no data are in finalStack, just push the element
                // else, push the element with caution that items are added
                if (finalStack.Count == 0)
                {
                    finalStack.Push(x);
                }
                else
                {
                    if (finalStack.Peek() <= x)
                    {
                        finalStack.Push(x);
                    }
                    else
                    {
                        while (finalStack.Peek() > x)
                        {
                            y = finalStack.Pop();
                            helperStack.Push(y);
                        }

                        finalStack.Push(x);
                        while (helperStack.Count != 0)
                        {
                            finalStack.Push(helperStack.Pop());
                        }
                    }
                }
                
            }

            return finalStack;
        }
    }
}
