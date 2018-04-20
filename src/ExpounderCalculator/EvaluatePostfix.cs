using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ExpounderCalculator
{
    class EvaluatePostfix
    {
        Stack EvaluatePF = new Stack();

        private float operate(char symbol, float operand1, float operand2) // Pichup 2 Number and a Peragmatic for a float result 
        {
            switch (symbol)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                default:
                    return 0;
            }
        }

        // evaluate postfix sentence by stack
        public float evaluate(string postfix)
        {
            char[] postfixCH = postfix.ToCharArray();
            float operand1, operand2;
            string baffer = string.Empty;
            foreach (char symbol in postfixCH)
            {
                if (char.IsDigit(symbol) || symbol == '.')
                    baffer += symbol.ToString();

                else if (symbol == ' ')
                {
                    if (baffer == "") continue;
                    EvaluatePF.Push(float.Parse(baffer));
                    baffer = string.Empty;
                }
                else
                {
                    operand2 = (float)(EvaluatePF.Pop());
                    operand1 = (float)(EvaluatePF.Pop());
                    EvaluatePF.Push(operate(symbol, operand1, operand2));
                }
            }
            return (float)(EvaluatePF.Pop());
        }
    }    
}
