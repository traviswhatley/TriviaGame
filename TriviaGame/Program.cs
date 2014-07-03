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
           //time is equal to amount of guesses
            int time = 10;
            //counts score
            int score = 0;
            //counts amount of correct guesses
            int correct = 0;
            //counts amount of incorrect guesses
            int incorrect = 0;
            //welcome to the game
            Console.WriteLine("Welcome to the game what is your name?");
            Console.WriteLine();
            //reads users input
            string name = Console.ReadLine();
            Console.WriteLine();
            //greets user with the name they've given and gives rules
            Console.WriteLine("Hello " + name + " in this game you will have 10 tries to answer random trivia questions! You will be given 100 points for each correct answer, and deducted 100 points for each wrong answer!");
            Console.WriteLine();
            //while guesses are more than zero run the game
            while (time > 0)
            {
                //generating a random number
                Random random = new Random();
                //between 1 and 5k
                int randomNum = random.Next(1, 5000);
                //making Trivia choose a random question out of the list
                var Trivia = GetTriviaList()[randomNum];
                //printing the question
                Console.WriteLine(Trivia.Question);
                Console.WriteLine();
                //asking the user to answer the question
                Console.WriteLine("Answer: ");
                Console.WriteLine();

                string input = Console.ReadLine().ToLower();
                Console.WriteLine();
                //seeing if the answer is correct
                if (input == Trivia.Answer.ToLower())
                {
                    //if it is congrats, add 1 to correct, minus 1 on time, and add 100 points to score
                    correct++;
                    score += 100;
                    time--;
                    Console.WriteLine("Well done, you got the correct answer");
                    Console.WriteLine();
                }
                else
                {
                    //if false print the correct answer, add 1 to incorrect, subtract 100 from score, subract 1 from time
                    incorrect++;
                    score += -100;
                    time--;
                    Console.WriteLine("Nice try. The answer was actually " + Trivia.Answer.ToUpper());
                    Console.WriteLine();
                }
            }
            //printing the score, amount of correct and incorrect answers
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
