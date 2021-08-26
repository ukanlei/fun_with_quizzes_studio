using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    public class MultipleChoice : Question
    {
        //public string CorrectAnswer { get; set; }

        public MultipleChoice(string questionBody, List<string> possibleAnswer, string correctAnswer) : base(questionBody, possibleAnswer)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswer;

        }
    }
}
