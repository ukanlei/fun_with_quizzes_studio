using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    public class CheckBox : Question
    {
        public List<string> CorrectAnswers { get; set; }

        public CheckBox(string questionBody, List<string> possibleAnswer, List<string> correctAnswers) : base(questionBody, possibleAnswer)
        {
            CorrectAnswers = correctAnswers;
            PossibleAnswers = possibleAnswer;

        }

        
        public override int CheckAnswer(string input)
        {
            int points = 0;
            foreach (string answer in CorrectAnswers)
            {
                if (input.Contains(answer))
                {
                    points += PointValue;
                } 
            }

            return points;
        }
    }
}
