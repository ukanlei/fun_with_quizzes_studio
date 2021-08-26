using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    public class TrueOrFalse : Question
    {
        //public string CorrectAnswer { get; set;}
        
        public TrueOrFalse(string questionBody, string correctAnswer) : base (questionBody)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = new List<string> { "True", "False" };
                
        }


    }
}
