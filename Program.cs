namespace StackQueueFilesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse a string using stack
            //Console.WriteLine("Enter a word to reverse:");
            //string word = Console.ReadLine();


            //Stack<char> stack = new Stack<char>();
            //foreach (char c in word)
            //{
            //    stack.Push(c);
            //}
            //string reversedStr = "  ";
            //while (stack.Count > 0)
            //{
            //    reversedStr += stack.Pop();
            //}
            //Console.WriteLine("Reversed string: " + reversedStr);

            //Evaluate a postfix expression using stack

            Console.WriteLine("Enter a postfix expression:");
            string postfix = Console.ReadLine();

            Stack<int> stack2 = new Stack<int>();
            foreach (char c in postfix)
            {
                if (char.IsDigit(c))
                {
                    stack2.Push(c - '0');
                }

                else
                {
                    int b = stack2.Pop();
                    int a = stack2.Pop();
                    switch (c)
                    {
                        case '+':
                            stack2.Push(a + b);
                            break;
                        case '-':
                            stack2.Push(a - b);
                            break;
                        case '*':
                            stack2.Push(a * b);
                            break;
                        case '/':
                            stack2.Push(a / b);
                            break;
                    }
                }
            }
            Console.WriteLine("Result of postfix expression: " + stack2.Pop());








        }
    }
}
