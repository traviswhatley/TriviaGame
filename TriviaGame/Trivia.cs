using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
<<<<<<< HEAD
        //setting properties for our object
        public string Question { get; set; }
        public string Answer { get; set; }
        //setting the constructor for the object
        public Trivia(string splitString)
        {
            //creating a new list to hold our string to be split
            List<string> questionAndAnswer = new List<string>();
            //splitting the string on the '*'
            questionAndAnswer = splitString.Split('*').ToList();
            //questions is everything before the '*'
            this.Question = questionAndAnswer[0];
            //answer is everything after the '*'
            this.Answer = questionAndAnswer[1];
        }
=======
        //TODO: Fill out the Trivia Object
        
>>>>>>> origin/master
    }
}
