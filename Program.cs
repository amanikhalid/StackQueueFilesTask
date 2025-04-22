using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace StackQueueFilesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; //Declare and initialize choice
            while (true)
            {

                try //handle the exception if the user enter invalid input
                {
                    //Menu System
                    Console.Clear();
                    Console.WriteLine("\nSelect a Program:");
                    Console.WriteLine("1. Reverse a String Using Stack ");
                    Console.WriteLine("2. Evaluate Postfix Expression Using Stack");
                    Console.WriteLine("3. Browser History Navigation Using Stack");
                    Console.WriteLine("4. XML/HTML Tag Validator Using Stack");
                    Console.WriteLine("5. Rotate Queue Elements by K");
                    Console.WriteLine("6. Sort a Queue Using Only Queue Operations ");
                    Console.WriteLine("7. Sliding Window Maximum Using Queue");
                    Console.WriteLine("8. Write Names to File ");
                    Console.WriteLine("9. Search for a Word in a File  ");
                    Console.WriteLine("10. Count Lines, Words, and Characters in a File");
                    Console.WriteLine("11. Word Frequency Counter in a File");
                    Console.WriteLine("12. Filter and Save Specific Lines in a File");
                    Console.WriteLine("13. Split and Merge Files");
                    Console.WriteLine("14. Exit");


                    Console.Write("Enter your choice : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: ReverseAStringUsingStack(); break;
                        case 2: EvaluatePostfixExpressionUsingStack(); break;
                        case 3: BrowserHistoryNavigationUsingStack(); break;
                        //case 4: XMLHTMLTagValidatorUsingStack(); break;
                        case 5: RotateQueueElementsbyK(); break;
                        //case 6: SortaQueueUsingOnlyQueueOperations(); break;
                        //case 7: SlidingWindowMaximumUsingQueue(); break;
                        //case 8: WriteNamestoFile(); break;
                        //case 9: SearchForWordinaFile(); break;
                        //case 10: CountLinesWordsandCharactersinaFile(); break;
                        //case 11: WordFrequencyCounterinaFile(); break;
                        //case 12: FilterandSaveSpecificLinesinaFile(); break;
                        //case 13: SplitandMergeFiles(); break;
                        case 14: return;

                        default: Console.WriteLine("Invalid Choice! Try again."); break;
                    }
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user input

                }
                catch (Exception e)//show exception message if the user enter invalid input
                {
                    Console.WriteLine(e.Message);


                    Console.WriteLine("Invalid Choice! Try again.");
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user inputConsole.ReadLine();
                }

            }
        }
        //Reverse a string using stack
        static void ReverseAStringUsingStack()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            //Push each character of the string onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }
            //Pop characters from the stack to get the reversed string
            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }
            Console.WriteLine("Reversed string: " + reversed);
        }
       static void EvaluatePostfixExpressionUsingStack()
        {
            Console.WriteLine("Enter a postfix expression (e.g., 23 34 + 45 *):");
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            string[] tokens = input.Split(' ');
            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            stack.Push(a / b);
                            break;
                        default:
                            Console.WriteLine("Invalid operator: " + token);
                            return;
                    }
                }
            }
            Console.WriteLine("Result: " + stack.Pop());
        }


        //Browser history navigation using stack
        static void BrowserHistoryNavigationUsingStack()
        { 
        }

            
            //XML/HTML Tag validation using stack
            static void XMLHTMLTagValidatorUsingStack()
            {
                
            }
            
            static void RotateQueueElementsbyK()
            {
                //Rotate queue elements by K
               Queue<int> queue = new Queue<int>();
            Console.WriteLine("Enter the number of elements in the queue:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the queue:");
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter the value of K:");
            int k = int.Parse(Console.ReadLine());
            if (k > n)
            {
                Console.WriteLine("K cannot be greater than the number of elements in the queue.");
                return;
            }
            //Rotate the queue
            for (int i = 0; i < k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine("Rotated queue:");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
        }



            static void SortaQueueUsingOnlyQueueOperations()
            {

            }

            static void SlidingWindowMaximumUsingQueue()
            {
            }

            static void WriteNamestoFile()
            {

            }

            static void SearchForWordinaFile()
            {

            }

            static void CountLinesWordsandCharactersinaFile()
            {

            }

            static void WordFrequencyCounterinaFile()
            {

            }

            static void FilterandSaveSpecificLinesinaFile()
            {

            }
            static void SplitandMergeFiles()
            {

            }

        }
    }

