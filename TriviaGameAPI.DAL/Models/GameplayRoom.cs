namespace TriviaGameAPI.DAL.Models
{
    public class GameplayRoom
    {
        public Guid Id { get; set; }
        public int MaxPlayers { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
