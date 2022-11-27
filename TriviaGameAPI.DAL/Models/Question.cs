using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGameAPI.DAL.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
