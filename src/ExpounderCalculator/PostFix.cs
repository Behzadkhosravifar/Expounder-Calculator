using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ExpounderCalculator
{
    class PostFix
    {
        Stack stack = new Stack();
        Stack revstack = new Stack();

        string strPostfix = string.Empty; // Final Result is at this 
        string lastnum;
        char[] ramy;
        bool empty = true;

        public string StrPostfix // Encapsulat Field
        {
            get { return strPostfix; }
        }

        public void ConvertToPostfix(string infix)
        {
            ramy = infix.ToCharArray();
            foreach (char c in ramy)
            {
                if (char.IsDigit(c) || c == '.') // if character's is intiger Digit or float digit (Example: 12 or 0.7)
                    lastnum = lastnum + c.ToString();
                else
                {
                    stack.Push(lastnum);
                    lastnum = "";

                    if (empty)
                    {
                        revstack.Push(c);
                        empty = false;
                    }
                    else
                        check(c);
                }
            }

            stack.Push(lastnum);
            lastnum = "";
            checkingIfThereOtherOperator(); // checking if there any other operations
            reversestack(); // reverse the stack
            // displaynig the answer
            strPostfix = "";
            while (revstack.Count != 0)
                strPostfix += revstack.Pop().ToString() + " ";
        }

        private void reversestack()
        {
            while (stack.Count != 0)
                revstack.Push(stack.Pop());
        }

        private void checkingIfThereOtherOperator()
        {
            while (revstack.Count != 0)
                stack.Push(revstack.Pop());
        }

        private void check(char c)
        {
            switch (c)
            {
                case '+':

                    while (revstack.Count != 0)
                        stack.Push(revstack.Pop());
                    revstack.Push(c);
                    break;

                case '-':
                    while (revstack.Count != 0)
                        stack.Push(revstack.Pop());
                    revstack.Push(c);
                    break;

                case '*':
                    while (revstack.Count != 0)
                        if (revstack.Peek().ToString() == "*" || revstack.Peek().ToString() == "/")
                            stack.Push(revstack.Pop());
                        else
                            break;

                    revstack.Push(c);
                    break;

                case '/':
                    while (revstack.Count != 0)
                        if (revstack.Peek().ToString() == "*" || revstack.Peek().ToString() == "/")
                            stack.Push(revstack.Pop());
                        else
                            break;

                    revstack.Push(c);
                    break;
            }
        }
    }
}
