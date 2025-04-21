namespace StackQueueFilesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse a string using stack
            Console.WriteLine("Enter a word to reverse:");
            string word = Console.ReadLine();


            Stack<char> stack = new Stack<char>();
            foreach (char c in word)
            {
                stack.Push(c);
            }
            string reversedStr = "  ";
            while (stack.Count > 0)
            {
                reversedStr += stack.Pop();
            }
            Console.WriteLine("Reversed string: " + reversedStr);

            





        }
    }
}
