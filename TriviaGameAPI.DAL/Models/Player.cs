using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGameAPI.DAL.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Score { get; set; }
        public DateTime LastGameDate { get; set; }
        public bool IsGameOrganizer { get; set;}
        public string? ConnectionId { get; set; }
        public string? CharacterColor { get; set; }
    }
}
