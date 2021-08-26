using System;
using System.Collections.Generic;

namespace fun_with_quizzes_studio
{
    public class Quiz 
    {
        public List <Question> ListOfQuestions { get; set; }
        public int TotalPointsPossible { get; set; } = 0;
        public int PointsEarned { get; set; } = 0;
        public string CorrectAnswer;
 

        //constructor: total points possible where each question is 1pt
        public Quiz(List<Question> listOfQuestions)
        {
            ListOfQuestions = listOfQuestions;
            TotalPointsPossible = listOfQuestions.Count;
        }


        //method to display set of question and answers and call CheckAnswer metho from Question class
        public void QuizDisplay()
        {
            foreach (Question question in ListOfQuestions)
            {
                Console.WriteLine("\n" + question);
                string userInput = Console.ReadLine();
                PointsEarned += question.CheckAnswer(userInput);
                Console.WriteLine(question.CheckAnswer(userInput));
            }

            
        }
     //method to get grade of the quiz
        public void DisplayGrade()
        {
            Console.WriteLine("\n" + "You scored: " + PointsEarned + "/" + TotalPointsPossible);

        }

    }
}
