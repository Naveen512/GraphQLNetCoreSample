using System.Collections.Generic;
using System.Linq;
using GraphQLSample.Data;
using GraphQLSample.Models;

namespace GraphQLSample.Repositories
{
    public class PlayerRepository: IPlayerRepository
    {
        private readonly SportsContext _sportsContext;
        public PlayerRepository(SportsContext context)
        {
            _sportsContext = context;
        }
        public List<Player> GetAll()
        {
            return _sportsContext.Player.ToList();
        }

        public Player AddPalyer(Player player)
        {
            _sportsContext.Player.Add(player);
            _sportsContext.SaveChanges();
            return player;
        }
    }
}
