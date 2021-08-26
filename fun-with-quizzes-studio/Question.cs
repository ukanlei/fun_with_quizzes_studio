using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    public abstract class Question
    {
        public string QuestionBody { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public string CorrectAnswer { get; set; }
        public int PointValue { get; } = 1;


        public Question(string questionBody)
        {
            QuestionBody = questionBody;

        }

        public Question(string questionBody, List<string> possibleAnswer)
        {
            QuestionBody = questionBody;
            PossibleAnswers = possibleAnswer;
           
        }

        //method to grade the quiz
        public virtual int CheckAnswer(string input)
        {
            if (CorrectAnswer.ToLower() == input.ToLower())
            {
                return PointValue;

            } else
            {
                return 0;
            }

        }

        //toString method
        public override string ToString()
        {
            string questionString = QuestionBody;
            foreach (string option in PossibleAnswers)
            {
                questionString += "\n" + option;
            }
            return questionString;
        }

    }
}
