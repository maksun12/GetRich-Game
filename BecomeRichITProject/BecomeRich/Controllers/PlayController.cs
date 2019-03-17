using BecomeRich.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecomeRich.Controllers
{
    public class PlayController
    {

        private BecomeRichContext context;

        public PlayController(BecomeRichContext context)
        { 
            this.context = context;
        }

        public List<Question> AllQuestion()
        {
            List<Question> questions = new List<Question>();
            questions = context.Questions.ToList();        
            return questions;
        }

        public Question GetQuestion(int i,List<Question> questions)
        {            
            if (i<=5)
            {
                questions = questions.Where(q => q.CategoryId == 1).ToList();
            }
            else if(i>=10)
            {
                questions = questions.Where(q => q.CategoryId == 3).ToList();
            }
            else
            {
                questions = questions.Where(q => q.CategoryId == 2).ToList();
            }
            Random random = new Random();
            int questionNumber = random.Next(1, questions.Count - 1);
            Question question = questions[questionNumber];
            return question;
        }
        
    }
}
