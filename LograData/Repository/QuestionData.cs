using LograData.Interfaces;
using LograModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LograData.Repository
{
    public class QuestionData : IQuestionData
    {
        readonly LograDbContext DB;
        public QuestionData(LograDbContext db)
        {
            DB = db;
        }
        public async Task<IEnumerable<Question>> GetQuestions(Guid idUser)
        {
          
            var LAnswer = await DB.Answers.Where(x => x.IdUser == idUser).Select(x => x.IdQuestion).ToListAsync();

            string consultaPreguntas = "select top 5 * from Questions ";
           
            //for (int i = 0; i < LAnswer.Count; i++)
            //{
            //    if ( i == 0)
            //    {
            //        consultaPreguntas += "where Id <> ";
            //    }

            //    consultaPreguntas += "'" + LAnswer[i] + "'" ;
            //    if ( i <= LAnswer.Count-1)
            //    {
            //        consultaPreguntas += " and ";
            //    }
            //}
           
            return await DB.Questions.FromSqlRaw(consultaPreguntas).ToListAsync();
        }

        public async Task<bool> PostDeleteQuestion(Question question)
        {
            try
            {
                DB.Questions.Remove(question);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public async Task<bool> PostQuestion(Question question)
        {
            try
            {
                await DB.Questions.AddAsync(question);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> PostUpdateQuestion(Question question)
        {
            try
            {
                DB.Questions.Update(question);
                await DB.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
