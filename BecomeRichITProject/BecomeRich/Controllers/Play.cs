using BecomeRich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Controllers
{
    public class Play
    {
        private static InOutConsole inOut = new InOutConsole();
        private BecomeRichContext context;
        private Player player;
        public Play(BecomeRichContext context, Player player)
        { 
            this.context = context;
            this.player = player;
            Start();
        }

       public void Start()
        {
            int correctAnswer = 0;
            for (int i = 1; i <= 15; i++)
            {
                var question=GetQuestion(i);
                inOut.PrintQuestionInfo(question);
                Console.Write("Въведи отговор:");
                string answer = Console.ReadLine();
                
                switch (answer)
                {
                    case "A":
                        if (question.A==question.Answear)
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
                }

            }
            if (correctAnswer==15)
            {
                Console.WriteLine("Rich");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public Question GetQuestion(int i)
        {
            List<Question> questions = new List<Question>();

            if (i<=5)
            {
                questions = context.Questions.Where(q => q.CategoryId == 1).ToList();
            }
            else if(i>=10)
            {
                questions = context.Questions.Where(q => q.CategoryId == 3).ToList();
            }
            else
            {
                questions = context.Questions.Where(q => q.CategoryId == 2).ToList();
            }
            Random random = new Random();
            int questionNumber = random.Next(1, questions.Count - 1);
            Question question = questions[questionNumber];
            return question;
        }
        
    }
}
