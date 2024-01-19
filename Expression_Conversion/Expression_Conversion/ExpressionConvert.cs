using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Conversion
{
    /// <summary>
    /// Provides methods for converting infix, postfix, and prefix expressions.
    /// </summary>
    public class ExpressionConvert
    {
        /// <summary>
        /// Checks if a character is an operator (+, -, *, /, ^).
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>True if the character is an operator; otherwise, false.</returns>
        private static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        }

        /// <summary>
        /// Checks if a string represents a single-character operator.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a single-character operator; otherwise, false.</returns>
        private static bool IsOperator(string s)
        {
            return s.Length == 1 && IsOperator(s[0]);
        }

        /// <summary>
        /// Determines the precedence of an operator.
        /// </summary>
        /// <param name="op">The operator.</param>
        /// <returns>The precedence value (higher value indicates higher precedence).</returns>
        private static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Converts an infix expression to a postfix expression.
        /// </summary>
        /// <param name="infixExpression">The infix expression to convert.</param>
        /// <returns>The resulting postfix expression.</returns>
        public static string InfixToPostfix(string infixExpression)
        {
            CustomStack<string> stack = new CustomStack<string>();
            StringBuilder postfix = new StringBuilder();
            StringBuilder itemReader = new StringBuilder();

            foreach (char c in infixExpression)
            {
                if (char.IsWhiteSpace(c) && itemReader.Length > 0)
                {
                    postfix.Append($"{itemReader} ");
                    itemReader.Clear();
                }
                else if (char.IsLetterOrDigit(c))
                {
                    itemReader.Append(c);
                }
                else if (c == '(')
                {
                    if (itemReader.Length > 0)
                    {
                        postfix.Append($"{itemReader} ");
                        itemReader.Clear();
                    }
                    stack.Push(c.ToString());
                }
                else if (c == ')')
                {
                    if (itemReader.Length > 0)
                    {
                        postfix.Append($"{itemReader} ");
                        itemReader.Clear();
                    }
                    while (!stack.IsEmpty() && stack.Peek() != "(")
                    {
                        postfix.Append($"{stack.Pop()} ");
                    }
                    if (!stack.IsEmpty())
                        stack.Pop(); // Pop '('
                }
                else if (IsOperator(c)) // Operator
                {
                    if (itemReader.Length > 0)
                    {
                        postfix.Append($"{itemReader} ");
                        itemReader.Clear();
                    }
                    while (!stack.IsEmpty() && GetPrecedence(c) <= GetPrecedence(stack.Peek()[0]))
                    {
                        postfix.Append($"{stack.Pop()} ");
                    }
                    stack.Push(c.ToString());
                }
            }

            if (itemReader.Length > 0)
            {
                postfix.Append($"{itemReader} ");
                itemReader.Clear();
            }

            while (!stack.IsEmpty())
            {
                postfix.Append($"{stack.Pop()} ");
            }

            return postfix.ToString().Trim();
        }

        /// <summary>
        /// Converts an infix expression to a prefix expression.
        /// </summary>
        /// <param name="infixExpression">The infix expression to convert.</param>
        /// <returns>The resulting prefix expression.</returns>
        public static string InfixToPrefix(string infixExpression)
        {
            char[] reversedInfix = new char[infixExpression.Length];

            for (int i = 0; i < infixExpression.Length; i++)
            {
                reversedInfix[i] = infixExpression[infixExpression.Length - 1 - i];
            }

            for (int i = 0; i < reversedInfix.Length; i++)
            {
                if (reversedInfix[i] == '(')
                    reversedInfix[i] = ')';
                else if (reversedInfix[i] == ')')
                    reversedInfix[i] = '(';
            }

            string postfixExpression = InfixToPostfix(new string(reversedInfix));
            char[] reversedPostfix = postfixExpression.ToCharArray();
            Array.Reverse(reversedPostfix);
            return new string(reversedPostfix).Trim();
        }

        /// <summary>
        /// Converts a postfix expression to an infix expression.
        /// </summary>
        /// <param name="postfixExpression">The postfix expression to convert.</param>
        /// <returns>The resulting infix expression.</returns>
        public static string PostfixToInfix(string postfixExpression)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string[] tokens = postfixExpression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (char.IsLetterOrDigit(token[0]))
                {
                    stack.Push(token);
                }
                else
                {
                    string operand2 = stack.Pop();
                    string operand1 = stack.Pop();
                    stack.Push($"({operand1} {token} {operand2})");
                }
            }

            return stack.Pop().Trim();
        }

        /// <summary>
        /// Converts a postfix expression to a prefix expression.
        /// </summary>
        /// <param name="postfixExpression">The postfix expression to convert.</param>
        /// <returns>The resulting prefix expression.</returns>
        public static string PostfixToPrefix(string postfixExpression)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string[] tokens = postfixExpression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                if (char.IsLetterOrDigit(token[0]))
                {
                    stack.Push(token);
                }
                else
                {
                    string operand2 = stack.Pop();
                    string operand1 = stack.Pop();
                    stack.Push($"{token} {operand1} {operand2}");
                }
            }

            return stack.Pop().Trim();
        }

        /// <summary>
        /// Converts a prefix expression to an infix expression.
        /// </summary>
        /// <param name="prefixExpression">The prefix expression to convert.</param>
        /// <returns>The resulting infix expression.</returns>
        public static string PrefixToInfix(string prefixExpression)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string[] tokens = prefixExpression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(tokens);

            foreach (var token in tokens)
            {
                if (char.IsLetterOrDigit(token[0]))
                {
                    stack.Push(token);
                }
                else
                {
                    string operand1 = stack.Pop();
                    string operand2 = stack.Pop();
                    stack.Push($"({operand1} {token} {operand2})");
                }
            }

            return stack.Pop().Trim();
        }

        /// <summary>
        /// Converts a prefix expression to a postfix expression.
        /// </summary>
        /// <param name="prefixExpression">The prefix expression to convert.</param>
        /// <returns>The resulting postfix expression.</returns>
        public static string PrefixToPostfix(string prefixExpression)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string[] tokens = prefixExpression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(tokens);

            foreach (var token in tokens)
            {
                if (char.IsLetterOrDigit(token[0]))
                {
                    stack.Push(token);
                }
                else
                {
                    string operand1 = stack.Pop();
                    string operand2 = stack.Pop();
                    stack.Push($"{operand1} {operand2} {token}");
                }
            }

            return stack.Pop().Trim();
        }
    }
}
