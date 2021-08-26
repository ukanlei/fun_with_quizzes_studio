using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> possibleQuestion2Answers = new List<string> {"1", "4", "5", "8"};
            List<string> question2CorrectAnswers = new List<string> { "4", "8" };
            List<string> possibleQuestion3Answers = new List<string> { "babi", "fire", "boooomm", "diaperr"};

            Question question1TrueFalse = new TrueOrFalse ("Water is liquid: ", "true");
            Question question2CheckBox = new CheckBox("Which ones are even numbers?", possibleQuestion2Answers, question2CorrectAnswers);
            Question question3MultipleChoice = new MultipleChoice("Which word is spell correctly?", possibleQuestion3Answers, "fire");

            List<Question> questionsList = new List<Question> {question1TrueFalse, question2CheckBox, question3MultipleChoice};

            Quiz quiz = new Quiz(questionsList);

            quiz.QuizDisplay();
            quiz.DisplayGrade();
        }
    }
}
