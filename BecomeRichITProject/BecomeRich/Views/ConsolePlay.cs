using BecomeRich.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Views
{
    public class ConsolePlay
    {
        public static BecomeRichContext context = new BecomeRichContext();
        public static Player player = context.Players.FirstOrDefault();
        private static InOutConsole inOut = new InOutConsole();
        PlayController play = new PlayController(context);

        public ConsolePlay()
        {
            Start();
        }

        public void Start()
        {
            var questions=play.AllQuestion();
            int correctAnswer = 0;
            for (int i = 1; i <= 15; i++)
            {
                var question = play.GetQuestion(i,questions);
               questions.Remove(question);
                inOut.PrintPlayQuestions(question, i);
                Console.Write("Въведи отговор:");
                string answer = Console.ReadLine();
               
                switch (answer)
                {
                    case "A":
                        if (question.A == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "B":
                        if (question.B == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "C":
                        if (question.C == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                    case "D":
                        if (question.D == question.Answear)
                        {
                            correctAnswer++;
                            continue;
                        }
                        else
                        {
                            i = 15;
                        }
                        break;
                }
               
            }
            if (correctAnswer == 15)
            {
                Console.WriteLine("Rich");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }


    }
}


