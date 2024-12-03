namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a sentence with no '.' at the end: ");
            string input1 = Console.ReadLine();

            Console.WriteLine($"Enter another sentence with no '.' at the end: ");
            string input2 = Console.ReadLine();

            Console.WriteLine($"\t\t\tExample 1:\n\t\t\tInput: word = \"{input1}\"\n\t\t\tOutput: {LastWordCount(input1)}\n\n");
            Console.WriteLine($"\t\t\tExample 2:\n\t\t\tInput: word = \"{input2}\"\n\t\t\tOutput: {LastWordCount(input2)}");
            
        }

        public static int LastWordCount(string word)
        {
            int length = 0; //word count
            bool inWord = false; //alert when there is a space

            for ( int i = word.Length - 1; i >= 0; i-- )
            {
                char c = word[i];

                if ( c != ' ')
                {
                    inWord = true;
                    length++; //increase counter
                }
                else if (inWord)
                {
                    break; 
                }
            }
            return length;
        }
        
    }
}
