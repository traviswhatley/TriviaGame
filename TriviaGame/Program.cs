using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int time = 10;

            int score = 0;

            int correct = 0;

            int incorrect = 0;

            Console.WriteLine("Welcome to the game what is your name?");
            Console.WriteLine();

            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello " + name + " in this game you will have 10 tries to answer random trivia questions! You will be given 100 points for each correct answer, and deducted 100 points for each wrong answer!");
            Console.WriteLine();

            while (time > 0)
            {
                Random random = new Random();

                int randomNum = random.Next(1, 5000);

                var Trivia = GetTriviaList()[randomNum];

                Console.WriteLine(Trivia.Question);
                Console.WriteLine();

                Console.WriteLine("Answer: ");
                Console.WriteLine();

                string input = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (input == Trivia.Answer.ToLower())
                {
                    correct++;
                    score += 100;
                    time--;
                    Console.WriteLine("Well done, you got the correct answer");
                    Console.WriteLine();
                }
                else
                {
                    incorrect++;
                    score += -100;
                    time--;
                    Console.WriteLine("Nice try. The answer was actually " + Trivia.Answer.ToUpper());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("You had " + score + " points! And you had " + correct + " correctt guesses and " + incorrect + " incorrect guesses!");


            //Trivia game function goes here
            Console.ReadKey();
        }


        //This functions gets the full list of trivia questions from the Trivia.txt document
        static List<Trivia> GetTriviaList()
        {
            //Get Contents from the file.  Remove the special char "\r".  Split on each line.  Convert to a list.
            List<string> contents = File.ReadAllText("trivia.txt").Replace("\r", "").Split('\n').ToList();

            //Each item in list "contents" is now one line of the Trivia.txt document.

            //make a new list to return all trivia questions
            List<Trivia> returnList = new List<Trivia>();
            // TODO: go through each line in contents of the trivia file and make a trivia object.
            
            //       add it to our return list.
            foreach (string question in contents)
            {
                Trivia a = new Trivia(question);
                returnList.Add(a);
            }
            //Return the full list of trivia questions
            return returnList;
        }
    }
}
